using System;
using System.Data;
using System.Data.SqlClient;

namespace Employee_managment_system
{
    public static class AuthService
    {
        public class LoginResult
        {
            public bool Success { get; set; }
            public string Message { get; set; } = "";
            public string Username { get; set; } = "";
            public string Role { get; set; } = "";
            public int UserID { get; set; }
            public string EmployeeID { get; set; } = "";
        }

        public static LoginResult Login(string username, string password)
        {
            var result = new LoginResult();

            try
            {
                string query = @"
                    SELECT UserID, Username, PasswordHash, Salt, Role, EmployeeID, IsActive
                    FROM Users 
                    WHERE Username = @Username";

                SqlParameter[] parameters = { new SqlParameter("@Username", username.Trim()) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    result.Message = "Invalid username or password.";
                    return result;
                }

                DataRow row = dt.Rows[0];

                // Check if account is active
                bool isActive = row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"]);
                if (!isActive)
                {
                    result.Message = "Account is deactivated. Please contact administrator.";
                    return result;
                }

                string storedPassword = row["PasswordHash"]?.ToString() ?? "";
                string storedSalt = row["Salt"]?.ToString() ?? "";
                bool passwordValid = false;

                // Check if password is hashed (has salt)
                if (!string.IsNullOrEmpty(storedSalt))
                {
                    // Verify using hash + salt
                    passwordValid = PasswordHelper.VerifyPassword(password, storedPassword, storedSalt);
                }
                else
                {
                    // Plain text password - verify directly
                    passwordValid = (storedPassword == password);

                    // If valid, upgrade to hashed password automatically
                    if (passwordValid)
                    {
                        UpgradeToHashed(username, password);
                    }
                }

                if (!passwordValid)
                {
                    result.Message = "Invalid username or password.";
                    return result;
                }

                // Login successful
                result.Success = true;
                result.Message = "Login successful!";
                result.Username = username;
                result.Role = row["Role"]?.ToString() ?? "User";
                result.UserID = Convert.ToInt32(row["UserID"]);
                result.EmployeeID = row["EmployeeID"]?.ToString() ?? "";

                // Log successful login
                LogUserAction(result.UserID, "Login successful");

                return result;
            }
            catch (Exception ex)
            {
                result.Message = $"Error during login: {ex.Message}";
                return result;
            }
        }

        // Upgrade plain text password to hashed
        private static void UpgradeToHashed(string username, string password)
        {
            try
            {
                string salt = PasswordHelper.GenerateSalt();
                string hash = PasswordHelper.HashPassword(password, salt);

                string query = @"
                    UPDATE Users 
                    SET PasswordHash = @PasswordHash, 
                        Salt = @Salt 
                    WHERE Username = @Username";

                SqlParameter[] parameters = {
                    new SqlParameter("@PasswordHash", hash),
                    new SqlParameter("@Salt", salt),
                    new SqlParameter("@Username", username)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch
            {
                // Silent fail - password stays as plain text
            }
        }

        // Create admin user (only if no users exist)
        public static bool CreateAdminUserIfNeeded()
        {
            try
            {
                // Check if any users exist
                string checkQuery = "SELECT COUNT(*) FROM Users";
                object result = DatabaseHelper.ExecuteScalar(checkQuery);
                int count = Convert.ToInt32(result);

                // Only create admin if NO users exist
                if (count > 0)
                    return false;

                // Create admin with plain text password (will be upgraded on first login)
                string query = @"
                    INSERT INTO Users (Username, PasswordHash, Salt, Role, IsActive, CreatedAt) 
                    VALUES ('admin', '123456', NULL, 'Admin', 1, GETDATE())";

                DatabaseHelper.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Log user actions
        public static void LogUserAction(int userId, string action)
        {
            try
            {
                string query = @"
                    INSERT INTO AuditLog (UserID, Action, ActionTime) 
                    VALUES (@UserID, @Action, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", userId),
                    new SqlParameter("@Action", action)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch
            {
                // Silent fail
            }
        }

        // Create a new user with hashed password
        public static bool CreateUser(string username, string password, string role = "User", string employeeID = null)
        {
            try
            {
                if (UserExists(username))
                    return false;

                string salt = PasswordHelper.GenerateSalt();
                string hash = PasswordHelper.HashPassword(password, salt);

                string query = @"
                    INSERT INTO Users (Username, PasswordHash, Salt, Role, EmployeeID, IsActive, CreatedAt) 
                    VALUES (@Username, @PasswordHash, @Salt, @Role, @EmployeeID, 1, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username.Trim()),
                    new SqlParameter("@PasswordHash", hash),
                    new SqlParameter("@Salt", salt),
                    new SqlParameter("@Role", role),
                    new SqlParameter("@EmployeeID", string.IsNullOrEmpty(employeeID) ? (object)DBNull.Value : employeeID)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool UserExists(string username)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlParameter[] parameters = { new SqlParameter("@Username", username.Trim()) };
                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return Convert.ToInt32(result) > 0;
            }
            catch
            {
                return false;
            }
        }

        // Reset admin password (if admin exists)
        public static bool ResetAdminPassword(string newPassword)
        {
            try
            {
                string salt = PasswordHelper.GenerateSalt();
                string hash = PasswordHelper.HashPassword(newPassword, salt);

                string query = @"
                    UPDATE Users 
                    SET PasswordHash = @PasswordHash, 
                        Salt = @Salt 
                    WHERE Username = 'admin'";

                SqlParameter[] parameters = {
                    new SqlParameter("@PasswordHash", hash),
                    new SqlParameter("@Salt", salt)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
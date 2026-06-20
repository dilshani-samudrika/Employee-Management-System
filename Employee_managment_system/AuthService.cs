using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        // Login user with database authentication
        public static LoginResult Login(string username, string password)
        {
            var result = new LoginResult();

            try
            {
                // Get user from database - matching your table structure
                string query = @"
                    SELECT UserID, Username, PasswordHash, Role, EmployeeID, IsActive
                    FROM Users 
                    WHERE Username = @Username";

                SqlParameter[] parameters = { new SqlParameter("@Username", username) };
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

                // Get stored password hash
                string storedHash = row["PasswordHash"]?.ToString() ?? "";

                // Verify password (no salt in your table, so we use empty salt)
                bool passwordValid = storedHash == password;

                // If you want to use hashed passwords, uncomment this:
                // bool passwordValid = PasswordHelper.VerifyPassword(password, storedHash, "");

                if (!passwordValid)
                {
                    // Log failed attempt
                    LogAudit(0, username, "Login Failed", "Invalid password attempt");
                    result.Message = "Invalid username or password.";
                    return result;
                }

                // Login successful
                int userId = Convert.ToInt32(row["UserID"]);
                string role = row["Role"]?.ToString() ?? "User";
                string employeeID = row["EmployeeID"]?.ToString() ?? "";

                // Log successful login
                LogAudit(userId, username, "Login", "User logged in successfully");

                result.Success = true;
                result.Message = "Login successful!";
                result.Username = username;
                result.Role = role;
                result.UserID = userId;
                result.EmployeeID = employeeID;

                return result;
            }
            catch (Exception ex)
            {
                result.Message = $"Error during login: {ex.Message}";
                return result;
            }
        }

        // Audit logging
        private static void LogAudit(int userId, string username, string action, string details)
        {
            try
            {
                string query = @"
                    INSERT INTO AuditLog (UserID, Username, Action, ActionTime, Details)
                    VALUES (@UserID, @Username, @Action, GETDATE(), @Details)";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", userId > 0 ? (object)userId : DBNull.Value),
                    new SqlParameter("@Username", string.IsNullOrEmpty(username) ? (object)DBNull.Value : username),
                    new SqlParameter("@Action", action),
                    new SqlParameter("@Details", details)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch { /* Silent fail for audit logging */ }
        }

        // Optional: Create admin user directly in database
        // Use this method if you want to create admin user programmatically
        public static bool CreateAdminUser(string username, string password)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlParameter[] checkParams = { new SqlParameter("@Username", username) };
                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, checkParams));

                if (count > 0)
                {
                    return true; // User already exists
                }

                // Store password directly (or hash if you prefer)
                string query = @"
                    INSERT INTO Users (Username, PasswordHash, Role, IsActive, CreatedAt)
                    VALUES (@Username, @Password, 'Admin', 1, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password) // Store as plain text or hash
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
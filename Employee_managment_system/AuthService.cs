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

        // LOGIN 
        public static LoginResult Login(string username, string password)
        {
            var result = new LoginResult();

            try
            {
                string query = @"
                    SELECT UserID, Username, Password, Role, EmployeeID, IsActive
                    FROM Users 
                    WHERE Username = @Username AND Password = @Password";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username.Trim()),
                    new SqlParameter("@Password", password.Trim())
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    result.Message = "Invalid username or password.";
                    return result;
                }

                DataRow row = dt.Rows[0];

                bool isActive = row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"]);
                if (!isActive)
                {
                    result.Message = "Account is deactivated. Please contact administrator.";
                    return result;
                }

                result.Success = true;
                result.Message = "Login successful!";
                result.Username = username;
                result.Role = row["Role"]?.ToString() ?? "User";
                result.UserID = Convert.ToInt32(row["UserID"]);
                result.EmployeeID = row["EmployeeID"]?.ToString() ?? "";

                LogUserAction(result.UserID, "Login successful");

                return result;
            }
            catch (Exception ex)
            {
                result.Message = $"Error during login: {ex.Message}";
                return result;
            }
        }

        // CHANGE PASSWORD 
        public static bool ChangePassword(int userId, string currentPassword, string newPassword)
        {
            try
            {
                // Verify current password
                string verifyQuery = @"
                    SELECT COUNT(*) FROM Users 
                    WHERE UserID = @UserID AND Password = @Password";

                SqlParameter[] verifyParams = {
                    new SqlParameter("@UserID", userId),
                    new SqlParameter("@Password", currentPassword.Trim())
                };

                object result = DatabaseHelper.ExecuteScalar(verifyQuery, verifyParams);
                int count = Convert.ToInt32(result);

                if (count == 0)
                    return false;

                // Update to new password
                string updateQuery = @"
                    UPDATE Users 
                    SET Password = @NewPassword 
                    WHERE UserID = @UserID";

                SqlParameter[] updateParams = {
                    new SqlParameter("@NewPassword", newPassword.Trim()),
                    new SqlParameter("@UserID", userId)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);

                if (rowsAffected > 0)
                {
                    LogUserAction(userId, "Password changed");
                }

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }

        // ADMIN CREATE (First time setup)
        public static bool CreateAdminUserIfNeeded()
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM Users";
                object result = DatabaseHelper.ExecuteScalar(checkQuery);
                int count = Convert.ToInt32(result);

                if (count > 0)
                    return false;

                string query = @"
                    INSERT INTO Users (Username, Password, Role, IsActive, CreatedAt) 
                    VALUES ('admin', '123456', 'Admin', 1, GETDATE())";

                DatabaseHelper.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // LOG USER ACTION
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
            catch { }
        }

        //GET USER ID
        public static int GetUserId(string username)
        {
            try
            {
                string query = "SELECT UserID FROM Users WHERE Username = @Username";
                SqlParameter[] parameters = { new SqlParameter("@Username", username.Trim()) };
                object result = DatabaseHelper.ExecuteScalar(query, parameters);
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
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

        public static LoginResult Login(string username, string password)
        {
            var result = new LoginResult();

            try
            {
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

                // Check IsActive
                bool isActive = true;
                if (row["IsActive"] != DBNull.Value)
                {
                    isActive = Convert.ToBoolean(row["IsActive"]);
                }

                if (!isActive)
                {
                    result.Message = "Account is deactivated. Please contact administrator.";
                    return result;
                }

                string storedPassword = row["PasswordHash"]?.ToString() ?? "";

                // Compare directly (plain text)
                if (storedPassword != password)
                {
                    result.Message = "Invalid username or password.";
                    return result;
                }

                int userId = Convert.ToInt32(row["UserID"]);
                string role = row["Role"]?.ToString() ?? "User";
                string employeeID = row["EmployeeID"]?.ToString() ?? "";

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
    }
}
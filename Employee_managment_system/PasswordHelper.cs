using System;
using System.Security.Cryptography;
using System.Text;

namespace Employee_managment_system
{
    public static class PasswordHelper
    {
        // Generate a random salt
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Hash password with salt using SHA256
        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                string combined = password + salt;
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combined));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Verify password
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            string computedHash = HashPassword(password, storedSalt);
            return computedHash == storedHash;
        }
    }
}
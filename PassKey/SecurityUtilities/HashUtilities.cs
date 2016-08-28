using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.SecurityUtilities
{
    public static class HashUtilities
    {
        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);
            string hashPassword = Convert.ToBase64String(hashBytes);

            return hashPassword;
        }

        public static byte[] HashKey(string key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            var sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(bytes);

            return hashBytes;
        }
    }
}

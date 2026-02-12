using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Teknoroma.BLL.DesignPatterns.GenericRepository.Helpers
{
    public static class PasswordHasher
    {
        public static void CreateHash(string password, out string hash, out string salt) 
        {
            using HMACSHA512 hmac = new HMACSHA512();

            salt = Convert.ToBase64String(hmac.Key);
            hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        public static bool Verify(string password, string storedHash, string storedSalt) 
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            using HMACSHA512 hmac = new HMACSHA512(saltBytes);

            byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(computedHash) == storedHash;
        }
    }
}

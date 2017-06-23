using System;
using System.Security.Cryptography;
using System.Text;

namespace GRM
{
    public sealed class Util
    {
        public static string Hash(string msg) {
            using (SHA256 sha = SHA256.Create())
            {
                return Convert.ToBase64String( sha.ComputeHash(Encoding.ASCII.GetBytes(msg)) );
            }
        }
    }
}
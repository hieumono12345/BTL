using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class SHA1_HASH
    {
        private static SHA1_HASH instance;

        public static SHA1_HASH Instance
        {
            get { if (instance == null) instance = new SHA1_HASH(); return instance; }
            private set { instance = value; }
        }

        private SHA1_HASH() { }

        public string Hash(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
    }
}

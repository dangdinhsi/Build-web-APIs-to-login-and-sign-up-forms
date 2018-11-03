using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIsNetCore031118.Security
{
    public class HashPassword
    {
        public string Md5(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            string result = BitConverter.ToString(bytes).Replace("-", String.Empty);
            return result.ToLower();
        }
    }
}

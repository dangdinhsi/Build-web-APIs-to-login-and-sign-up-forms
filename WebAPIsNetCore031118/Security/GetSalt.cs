using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WebAPIsNetCore031118.Security
{
    public class GetSalt
    {
        public String Salt()
        {
            byte[] ramdomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {


                rng.GetBytes(ramdomBytes);

            }

            string randomString = Convert.ToBase64String(ramdomBytes);

            return randomString.Remove(8);
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Verifier.Domain
{
    public static class Verifier
    {
        public static bool Verify(byte[] data)
        {
            byte[] publicKey =
                File.ReadAllBytes(@"../Resources/publicKey.der");

            byte[] signature =
                    File.ReadAllBytes("C:\\Users\\AbouzarKamaee\\Documents\\visual studio 2013\\Projects\\Ashkan\\Ashkan\\signed_file");

            RSACryptoServiceProvider csp = Utility.DecodeX509PublicKey(publicKey);

            // Hash the data
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(data);

            // Verify the signature with the hash
            bool res = csp.VerifyData(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
        }
    }
}

using System;
using System.IO;
using System.Security.Cryptography;

namespace Verifier.Utility
{
    public static class Verifier
    {
        public static bool Verify(byte[] data, byte[] signature)
        {
            string basePath =
                System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\";
            byte[] publicKey = File.ReadAllBytes(basePath + "Resources\\publicKey.der");

            RSACryptoServiceProvider csp = RSACryptoServiceHelper.DecodeX509PublicKey(publicKey);

            // Hash the data
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(data);

            // Verify the signature with the hash
            bool res = csp.VerifyData(hash, CryptoConfig.MapNameToOID("SHA1"), signature);

            return res;
        }
    }
}

using System.IO;
using System.Security.Cryptography;

namespace Verifier.Utility
{
    public static class Verifier
    {
        public static bool Verify(byte[] data)
        {
            byte[] publicKey =
                File.ReadAllBytes(@"../Resources/publicKey.der");

            byte[] signature =
                    File.ReadAllBytes("C:\\Users\\AbouzarKamaee\\Documents\\visual studio 2013\\Projects\\Ashkan\\Ashkan\\signed_file");

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

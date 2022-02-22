using PgpCore;
using System.IO;

namespace Rki.CancerDataGenerator.StaticHelper
{
    public class Encryption
    {
        public static void GenerateTestKeys()
        {
            // generate keys
            using (PGP pgp = new PGP())
            {
                pgp.GenerateKey(@"C:\TEMP\public.asc", @"C:\TEMP\private.asc", "email@email.com", "password");
            }
        }
        public static string EncryptString(string content, string publicKey)
        {
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);
            PGP mypgp = new PGP(encryptionKeys);
            return mypgp.EncryptArmoredString(content);
        }

        public static string SignString(string content)
        {
            FileInfo privateKey = new FileInfo(@"C:\temp\<secretKey>.gpg");
            EncryptionKeys encryptionKeys = new EncryptionKeys(privateKey, "secret");
            PGP mypgp = new PGP(encryptionKeys);
            return mypgp.SignArmoredString(content);
        }


        public void EncryptFile(string contentFullPath, string encryptetFullPath, string publicKeyFullPath)
        {
            // Load keys
            FileInfo publicKey = new FileInfo(publicKeyFullPath);
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);

            // Reference input/output files
            FileInfo inputFile = new FileInfo(contentFullPath);
            FileInfo encryptedFile = new FileInfo(encryptetFullPath); // .pgp

            // Encrypt
            PGP mypgp = new PGP(encryptionKeys);
            mypgp.EncryptFile(inputFile, encryptedFile);
            return;
        }
    }
}

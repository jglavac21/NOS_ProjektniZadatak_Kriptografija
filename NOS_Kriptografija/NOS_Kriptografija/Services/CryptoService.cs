using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOS_Kriptografija.Services
{
    public class CryptoService
    {
        //1. Generiranje kljuceva
        public void GenerateSymmetricKey(string keyFilePath)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.GenerateKey();
                aes.GenerateIV();

                string keyBase64 = Convert.ToBase64String(aes.Key);
                string ivBase64 = Convert.ToBase64String(aes.IV);

                File.WriteAllLines(keyFilePath, new[] { keyBase64, ivBase64 });
            }
        }
        public void GenerateAsymmetricKeys(string publicKeyPath, string privateKeyPath)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    string publicKeyXml = rsa.ToXmlString(false);
                    string privateKeyXml = rsa.ToXmlString(true);

                    File.WriteAllText(publicKeyPath, publicKeyXml);
                    File.WriteAllText(privateKeyPath, privateKeyXml);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        // 2. Simetricna kriptografija
        public void EncryptSymmetric(string inputFile, string outputFile, string keyFilePath)
        {
            LoadSymmetricKey(keyFilePath, out byte[] key, out byte[] iv);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (var fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (var cryptoTransform = aes.CreateEncryptor())
                using (var cryptoStream = new CryptoStream(fsOutput, cryptoTransform, CryptoStreamMode.Write))
                {
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }
        public void DecryptSymmetric(string inputFile, string outputFile, string keyFilePath)
        {
            LoadSymmetricKey(keyFilePath, out byte[] key, out byte[] iv);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (var fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (var fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (var cryptoTransform = aes.CreateDecryptor())
                using (var cryptoStream = new CryptoStream(fsInput, cryptoTransform, CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(fsOutput);
                }
            }
        }

        // 3. Asimetricna (hibridna) kriptografija
        public void EncryptAsymmetricHybrid(string inputFile, string outputFile, string publicKeyPath) { }
        public void DecryptAsymmetricHybrid(string inputFile, string outputFile, string privateKeyPath) { }

        // 4. Hash
        public void ComputeHash(string inputFile, string hashFilePath) { }

        // 5. Digitalni potpis
        public void SignFile(string inputFile, string privateKeyPath, string signatureFilePath) { }
        public bool VerifySignature(string inputFile, string publicKeyPath, string signatureFilePath) { return false; }

        // Helper – ucitavanje AES kljuca
        private void LoadSymmetricKey(string keyFilePath, out byte[] key, out byte[] iv)
        {
            string[] lines = File.ReadAllLines(keyFilePath);
            key = Convert.FromBase64String(lines[0]);
            iv = Convert.FromBase64String(lines[1]);
        }
    }
}

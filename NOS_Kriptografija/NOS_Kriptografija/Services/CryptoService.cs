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
        public void EncryptAsymmetricHybrid(string inputFile, string outputFile, string publicKeyPath)
        {
            // Ucitavanje javnog RSA kljuca iz datoteke
            string publicKeyXml = File.ReadAllText(publicKeyPath);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(publicKeyXml);

                // Generiranje novog nasumicnog AES kljuca + IV (za ovu datoteku)
                using (var aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.GenerateKey();
                    aes.GenerateIV();
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;

                    // Spajanje KEY i IV u jedan byte[]
                    byte[] keyIv = new byte[aes.Key.Length + aes.IV.Length];
                    Buffer.BlockCopy(aes.Key, 0, keyIv, 0, aes.Key.Length);
                    Buffer.BlockCopy(aes.IV, 0, keyIv, aes.Key.Length, aes.IV.Length);

                    // RSA-om se kriptira (KEY + IV)
                    byte[] encryptedKeyIv = rsa.Encrypt(keyIv, true);

                    using (var fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    using (var fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    {
                        // U izlaznu datoteku prvo se upisuje duljina RSA-bloka (4 bajta)
                        byte[] lengthBytes = BitConverter.GetBytes(encryptedKeyIv.Length);
                        fsOutput.Write(lengthBytes, 0, lengthBytes.Length);

                        // Zatim se upisuje RSA-kriptirani (KEY + IV)
                        fsOutput.Write(encryptedKeyIv, 0, encryptedKeyIv.Length);

                        // Ostatak datoteke kriptira se AES-om
                        using (var encryptor = aes.CreateEncryptor())
                        using (var cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cryptoStream);
                        }
                    }
                }
            }
        }

        public void DecryptAsymmetricHybrid(string inputFile, string outputFile, string privateKeyPath)
        {
            // Ucitavanje privatnog RSA kljuca
            string privateKeyXml = File.ReadAllText(privateKeyPath);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(privateKeyXml);

                using (var fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                {
                    // Citanje prvih 4 bajta -> duljina RSA dijela
                    byte[] lengthBytes = new byte[4];
                    int read = fsInput.Read(lengthBytes, 0, lengthBytes.Length);
                    if (read != 4)
                        throw new InvalidDataException("Invalid encrypted file format (missing RSA header length).");

                    int encryptedKeyIvLength = BitConverter.ToInt32(lengthBytes, 0);
                    if (encryptedKeyIvLength <= 0 || encryptedKeyIvLength > 4096)
                        throw new InvalidDataException("Invalid RSA key block length in encrypted file.");

                    // Citanje RSA-kriptirani (KEY + IV)
                    byte[] encryptedKeyIv = new byte[encryptedKeyIvLength];
                    int totalRead = 0;
                    while (totalRead < encryptedKeyIvLength)
                    {
                        int bytesRead = fsInput.Read(encryptedKeyIv, totalRead, encryptedKeyIvLength - totalRead);
                        if (bytesRead == 0)
                            throw new EndOfStreamException("Unexpected end of file while reading encrypted AES key.");
                        totalRead += bytesRead;
                    }

                    // RSA-om se desifrira (KEY + IV)
                    byte[] keyIv = rsa.Decrypt(encryptedKeyIv, true);

                    using (var aes = Aes.Create())
                    {
                        aes.KeySize = 256;
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        int keySizeBytes = aes.KeySize / 8;          // 256 / 8 = 32 bajta
                        int ivSizeBytes = aes.BlockSize / 8;        // npr. 128 / 8 = 16 bajtova

                        if (keyIv.Length != keySizeBytes + ivSizeBytes)
                            throw new InvalidDataException("Decrypted key/IV length does not match expected AES sizes.");

                        byte[] key = new byte[keySizeBytes];
                        byte[] iv = new byte[ivSizeBytes];

                        Buffer.BlockCopy(keyIv, 0, key, 0, keySizeBytes);
                        Buffer.BlockCopy(keyIv, keySizeBytes, iv, 0, ivSizeBytes);

                        aes.Key = key;
                        aes.IV = iv;

                        // Ostatak ulazne datoteke je AES-kriptirani sadrzaj
                        using (var fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                        using (var decryptor = aes.CreateDecryptor())
                        using (var cryptoStream = new CryptoStream(fsInput, decryptor, CryptoStreamMode.Read))
                        {
                            cryptoStream.CopyTo(fsOutput);
                        }
                    }
                }
            }
        }

        // 4. Hash
        public void ComputeHash(string inputFile, string hashFilePath)
        {
            using (var sha = SHA256.Create())
            using (var fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            {
                // Izracun hash (byte[])
                byte[] hashBytes = sha.ComputeHash(fs);

                // Pretvaranje u hex string
                string hashHex = BitConverter.ToString(hashBytes).Replace("-", "");

                // Spremanje u tekstualnu datoteku
                File.WriteAllText(hashFilePath, hashHex);
            }
        }

        // 5. Digitalni potpis
        public void SignFile(string inputFile, string privateKeyPath, string signatureFilePath)
        {
            // Ucitavanje privatnog kljuca iz datoteke
            string privateKeyXml = File.ReadAllText(privateKeyPath);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(privateKeyXml);

                // Otvaranje ulazne datoteke kao stream
                using (var fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                {
                    // Potpisivanje podataka u streamu koristeci SHA-256
                    byte[] signatureBytes = rsa.SignData(fs, CryptoConfig.MapNameToOID("SHA256"));

                    // Pretvaranje potpisa u Base64 string radi lakseg spremanja u .txt
                    string signatureBase64 = Convert.ToBase64String(signatureBytes);

                    // Spremanje potpisa u potpisnu datoteku (npr. .sig ili .txt)
                    File.WriteAllText(signatureFilePath, signatureBase64);
                }
            }
        }

        public bool VerifySignature(string inputFile, string publicKeyPath, string signatureFilePath)
        {
            // Ucitavanje javnog kljuca
            string publicKeyXml = File.ReadAllText(publicKeyPath);

            // Ucitavanje potpisa iz datoteke
            string signatureBase64 = File.ReadAllText(signatureFilePath);
            byte[] signatureBytes = Convert.FromBase64String(signatureBase64);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(publicKeyXml);

                // Otvaranje originalne datoteke i izracun SHA-256 hash-a
                using (var fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (var sha = SHA256.Create())
                {
                    byte[] hash = sha.ComputeHash(fs);

                    // Provjera digitalnog potpisa nad hashom
                    bool isValid = rsa.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA256"), signatureBytes);
                    return isValid;
                }
            }
        }

        // Helper – ucitavanje AES kljuca
        private void LoadSymmetricKey(string keyFilePath, out byte[] key, out byte[] iv)
        {
            string[] lines = File.ReadAllLines(keyFilePath);
            key = Convert.FromBase64String(lines[0]);
            iv = Convert.FromBase64String(lines[1]);
        }
    }
}
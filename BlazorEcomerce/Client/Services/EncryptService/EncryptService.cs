namespace BlazorEcomerce.Client.Services.EncryptService
{

    using System;
    using System.IO;
    using System.Security.Cryptography;
    public class EncryptService : IEncryptService
    {
        private readonly Aes myAes = Aes.Create();


        public string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (myAes.Key == null || myAes.Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (myAes.IV == null || myAes.IV.Length <= 0)
                throw new ArgumentNullException("IV");

    
            string plaintext = null;

          
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = myAes.Key;
                aesAlg.IV = myAes.IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

    

        public byte[] EncryptStringToBytes_Aes(string plainText)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (myAes.IV == null || myAes.IV.Length <= 0)
                throw new ArgumentNullException("Key");
            if (myAes.IV == null || myAes.IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = myAes.Key;
                aesAlg.IV = myAes.IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }
    }
}

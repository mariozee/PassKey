namespace PassKey.SecurityUtilities
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public static class CryptographicUtilities
    {
        public static string Encrypt(string text, byte[] key)
        {
            byte[] plainTextBytes = ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = key;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(Constants.IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encypted = crypto.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encypted);
        }

        public static string Decrypt(string encrypted, byte[] key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = key;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(Constants.IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] secret = crypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            crypto.Dispose();
            return ASCIIEncoding.ASCII.GetString(secret);
        }
    }
}

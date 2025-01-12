using System.Security.Cryptography;
using System.Text;

namespace SprayProcessSystem.Helper
{
    public class AESHelper
    {
        public static string EncryptKey { get; set; } = "nevermorey98@gmail.com";

        // AES加密函数
        public static string Encrypt(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                // 将密钥和IV生成
                aes.Key = GenerateKey(key);
                aes.IV = new byte[16]; // 初始化为全零向量，可以根据需要自定义

                // 创建加密器
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        // AES解密函数
        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                // 将密钥和IV生成
                aes.Key = GenerateKey(key);
                aes.IV = new byte[16]; // 初始化为全零向量，需与加密时一致

                // 创建解密器
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cryptoStream))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }

        // 密钥生成（确保密钥为16字节）
        private static byte[] GenerateKey(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                byte[] aesKey = new byte[16];
                Array.Copy(hash, aesKey, 16);
                return aesKey;
            }
        }
    }
}

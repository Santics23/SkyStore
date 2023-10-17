using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace appWebSkyStore.Logica
{
    public class ClEncriptarAES
    {
        public string cifrarTextoAES(string textoCifrar)
        {
            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes("1234567891234567");
            byte[] saltValueBytes = Encoding.ASCII.GetBytes("Encriptacion_Exposicion");
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(textoCifrar);

            PasswordDeriveBytes password = new PasswordDeriveBytes("Encriptacion_Exposicion", saltValueBytes, "SHA1", 22);

            byte[] keyBytes = password.GetBytes(128 / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform encryptor =
                symmetricKey.CreateEncryptor(keyBytes, InitialVectorBytes);

            MemoryStream memoryStream = new MemoryStream();

            CryptoStream cryptoStream =
                new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            cryptoStream.FlushFinalBlock();

            byte[] cipherTextBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            string textoCifradoFinal = Convert.ToBase64String(cipherTextBytes);

            return textoCifradoFinal;

        }


        public string descifrarTextoAES(string textoCifrado)
        {
            byte[] InitialVectorBytes = Encoding.ASCII.GetBytes("1234567891234567");
            byte[] saltValueBytes = Encoding.ASCII.GetBytes("Encriptacion_Exposicion");

            byte[] cipherTextBytes = Convert.FromBase64String(textoCifrado);

            PasswordDeriveBytes password = new PasswordDeriveBytes("Encriptacion_Exposicion", saltValueBytes, "SHA1", 22);

            byte[] keyBytes = password.GetBytes(128 / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();

            symmetricKey.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, InitialVectorBytes);

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            memoryStream.Close();
            cryptoStream.Close();

            string textoDescifradoFinal = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);

            return textoDescifradoFinal;

        }
    }
}
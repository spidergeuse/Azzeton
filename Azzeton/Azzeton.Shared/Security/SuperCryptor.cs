using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Azzeton.Shared.Security
{
    public class SuperCryptor
    {
        public static byte[] Encrypt(byte[] byte_array, byte[] key, byte[] iv)
        {
            MemoryStream _memorystream = new MemoryStream();
            Rijndael _algorithm = Rijndael.Create();
            _algorithm.Key = key;
            _algorithm.IV = iv;
            CryptoStream _cryptostream = new CryptoStream( _memorystream,_algorithm.CreateEncryptor(),CryptoStreamMode.Write);   
            _cryptostream.Write(byte_array, 0, byte_array.Length);
            _cryptostream.Close();
            byte[] encryptedData = _memorystream.ToArray();
            return encryptedData;
        }
        public static string Encrypt(string value, string password)
        {
                byte[] _byte_array = System.Text.Encoding.Unicode.GetBytes(value);
                PasswordDeriveBytes _password_derive_bytes = new PasswordDeriveBytes(password,
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61});
                byte[] encryptedData = Encrypt(_byte_array,_password_derive_bytes.GetBytes(32), _password_derive_bytes.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
        }
        public static byte[] Encrypt(byte[] clearData, string password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61});
            return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
        }
        public static void Encrypt(string input_file,string output_file, string password) 
        { 
            FileStream fsIn = new FileStream(input_file,FileMode.Open, FileAccess.Read); 
            FileStream fsOut = new FileStream(output_file,FileMode.OpenOrCreate, FileAccess.Write); 

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, 
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61}); 

            Rijndael alg = Rijndael.Create(); 
            alg.Key = pdb.GetBytes(32); 
            alg.IV = pdb.GetBytes(16); 
            CryptoStream cs = new CryptoStream(fsOut, 
                alg.CreateEncryptor(), CryptoStreamMode.Write); 
            int bufferLen = 4096;
            byte[] buffer = null;
            int bytesRead; 

            do { 
                bytesRead = fsIn.Read(buffer, 0, bufferLen); 
                cs.Write(buffer, 0, bytesRead); 
            } while(bytesRead != 0); 

            cs.Close(); 
            fsIn.Close();     
        }
        public static byte[] Decrypt(byte[] cipher_data,byte[] key, byte[] iv)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = key;
            alg.IV = iv;
            CryptoStream cs = new CryptoStream(ms,
                alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipher_data, 0, cipher_data.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }
        public static string Decrypt(string cipher_text, string password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipher_text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61});
            byte[] decryptedData = Decrypt(cipherBytes,
                pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
        public static byte[] Decrypt(byte[] cipher_data, string password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password,
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61});
            return Decrypt(cipher_data, pdb.GetBytes(32), pdb.GetBytes(16));
        }
        public static void Decrypt(string input_file,string output_file, string password) 
        { 
            FileStream fsIn = new FileStream(input_file,FileMode.Open, FileAccess.Read); 
            FileStream fsOut = new FileStream(output_file,FileMode.OpenOrCreate, FileAccess.Write); 
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, 
                new byte[] {0x6F, 0x6C, 0x69, 0x76, 0x65, 0X72, 0x73, 0x61}); 
            Rijndael alg = Rijndael.Create(); 
            alg.Key = pdb.GetBytes(32); 
            alg.IV = pdb.GetBytes(16); 
            CryptoStream cs = new CryptoStream(fsOut,alg.CreateDecryptor(), CryptoStreamMode.Write); 
            int bufferLen = 4096;
            byte[] buffer = null;
            int bytesRead; 

            do
            { 
                bytesRead = fsIn.Read(buffer, 0, bufferLen); 
                cs.Write(buffer, 0, bytesRead); 

            } while(bytesRead != 0); 
            cs.Close(); 

            fsIn.Close();     
        }
    }
}

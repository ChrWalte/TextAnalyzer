using System;
using System.Security.Cryptography;
using System.Text;

namespace textAnalyzer
{
    internal class Hash
    {
        public static String md5(string input)
        {
            MD5 mdFive = MD5.Create();
            byte[] temp = mdFive.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                stringBuilder.Append(temp[i].ToString("x2"));
            return stringBuilder.ToString();
        }

        public static String sha1(string input)
        {
            SHA1 shaOne = SHA1.Create();
            byte[] temp = shaOne.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                stringBuilder.Append(temp[i].ToString("x2"));
            return stringBuilder.ToString();
        }

        public static String sha256(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] temp = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                stringBuilder.Append(temp[i].ToString("x2"));
            return stringBuilder.ToString();
        }

        public static String sha384(string input)
        {
            SHA384 sha384 = SHA384.Create();
            byte[] temp = sha384.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                stringBuilder.Append(temp[i].ToString("x2"));
            return stringBuilder.ToString();
        }

        public static String sha512(string input)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] temp = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
                stringBuilder.Append(temp[i].ToString("x2"));
            return stringBuilder.ToString();
        }
    }
}
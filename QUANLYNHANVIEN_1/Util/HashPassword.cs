using System;
using System.Security.Cryptography;
using System.Text;

namespace QUANLYNHANVIEN_1.Util
{
    internal class HashPassword
    {
        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển đổi password sang mảng byte sử dụng UTF-8
                byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BytesToHex(hashedPassword);
            }
        }

        private static string BytesToHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.AppendFormat("{0:x2}", b); // Chuyển mỗi byte sang dạng hexadecimal
            }
            return sb.ToString();
        }
    }
}

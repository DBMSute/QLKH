using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instace
        {
            get
            {
                if (instance == null) return new TaiKhoanBUS();
                return instance;
            }
        }

        public bool checkAccount(string tenTk, string passwd)
        {
   
            if (DAO.TaiKhoanDAO.Instance.Check2(tenTk, passwd) == EnCrypt(ReverseString(tenTk.ToUpper()) + passwd))
                return true;
            return false;
        }

        public string ReverseString(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mãng ký tự
            Array.Reverse(arr); // đảo ngược mãng
            return new string(arr); // trả về chuỗi mới sau khi đảo mãng
        }

        public string EnCrypt(string strEnCrypt) //mã hóa sang SHA1
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();

                //compute hash from the bytes of text  
                sha1.ComputeHash(Encoding.ASCII.GetBytes(strEnCrypt));

                //get hash result after compute it  
                byte[] result = sha1.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("X2"));
                }
                return strBuilder.ToString();
            }
            catch (Exception) {
                return null;
            }
         
        }
    }
}

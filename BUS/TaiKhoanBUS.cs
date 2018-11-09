using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
   
            if (DAO.TaiKhoanDAO.Instance.CheckAccount(tenTk) == EnCrypt(ReverseString(tenTk.ToUpper()) + passwd))
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
                sha1.ComputeHash(Encoding.ASCII.GetBytes(strEnCrypt));   
                byte[] result = sha1.Hash;          
                return Encoding.ASCII.GetString(result);
            }
            catch (Exception) {
                return null;
            }
         
        }

        public void updateAvatar(string id, string path)
        {         
            byte[] avt = File.ReadAllBytes(path);                      
            DAO.TaiKhoanDAO.Instance.updateAvatar(id, avt);
        }

        public void loadData(string tentk,Label id, PictureBox avt, Label tk, Label hovatendem, Label ten, Label ngaysinh, Label diachi, Label lastlogin, Label createdate, Label pers, Label tinhtrang)
        {
            DTO.TaiKhoan temp = DAO.TaiKhoanDAO.Instance.loadData(tentk);
            id.Text = temp.ID;
            try
            {
                avt.Image = ByteToImage(temp.AVT);
            }
            catch (Exception)
            {           
                avt.Image = null;
            }
            tk.Text = "Hi, " + char.ToUpper(temp.TENTK[0]) + temp.TENTK.Substring(1);
            ten.Text = temp.TEN;
            hovatendem.Text = temp.HOVATENDEM;Color.FromArgb(0, 101, 167);
            ngaysinh.Text = temp.NGAYSINH;
            diachi.Text = temp.DIACHI;
            lastlogin.Text = temp.LASTLOGIN;
            createdate.Text = temp.CREATEDAY;
            pers.Text = (temp.PERS == 1) ? "admin" : (temp.PERS == 2) ? "manager" : "employeer";
            tinhtrang.Text = (temp.TINHTRANG == 1) ? "Active" : "Banned";
        }

        public Bitmap ByteToImage(byte[] blob) //Covert Byte to Image
        {
            Bitmap image;
            using (MemoryStream stream = new MemoryStream(blob))
            {
                image = new Bitmap(stream);
            }
            return image;
        }

        public void updateLastLogin(string tentk)
        {
            DAO.TaiKhoanDAO.Instance.updateLastLogin(tentk);
        }

        public void updateInfo(string id, string hovatendem, string ten, string ngaysinh, string diachi, string pers, string tinhtrang)
        {
            int tempPers, tempST;
            tempPers = (pers == "admin") ? 1 : (pers == "manager") ? 2 : 3;
            tempST = (tinhtrang == "Active") ? 1 : 0;
            DAO.TaiKhoanDAO.Instance.updateInfo(id, hovatendem, ten, ngaysinh, diachi, tempPers, tempST);
        }

        public void updatePW(string id, string opw, string npw)
        {
            DAO.TaiKhoanDAO.Instance.updatePW(id, opw, npw);
        }
    }
}

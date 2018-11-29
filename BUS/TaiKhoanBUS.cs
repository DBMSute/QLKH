using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS INSTANCE
        {
            get
            {
                if (instance == null) return new TaiKhoanBUS();
                return instance;
            }
        }

        public int checkAccount(string tenTk, string passwd)
        {
            return DAO.TaiKhoanDAO.INSTANCE.CheckAccount(tenTk, passwd);

        }

        public void updateAvatar(string id, string path)
        {         
            byte[] avt = File.ReadAllBytes(path);                      
            DAO.TaiKhoanDAO.INSTANCE.updateAvatar(id, avt);
        }

        public void loadData(string tentk,Label id, PictureBox avt, Label tk, Label hovatendem, Label ten, Label ngaysinh, Label diachi, Label lastlogin, Label createdate, Label pers, Label tinhtrang, Label idQuanLy, Label tenQuanLy)
        {
            DTO.TaiKhoan temp = DAO.TaiKhoanDAO.INSTANCE.loadData(tentk);
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
            pers.Text = temp.PERS == 1 ? "Quản trị tối cao" : (temp.PERS == 2 ? "Quản lý" : "Nhân viên");
            tinhtrang.Text = temp.TINHTRANG == 1 ? "Đang hoạt động": "Bị khóa";
            idQuanLy.Text = temp.QUANLY;
            tenQuanLy.Text = temp.TENQUANLY;
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
            DAO.TaiKhoanDAO.INSTANCE.updateLastLogin(tentk);
        }

        public void updateInfo(string id, string hovatendem, string ten, string ngaysinh, string diachi, string pers, string tinhtrang)
        {
            int tempPers, tempST;
            tempPers = (pers == "admin") ? 1 : (pers == "manager") ? 2 : 3;
            tempST = (tinhtrang == "Active") ? 1 : 0;
            DAO.TaiKhoanDAO.INSTANCE.updateInfo(id, hovatendem, ten, ngaysinh, diachi, tempPers, tempST);
        }

        public void updatePW(string id, string opw, string npw)
        {
            DAO.TaiKhoanDAO.INSTANCE.updatePW(id, opw, npw);
        }
    }
}

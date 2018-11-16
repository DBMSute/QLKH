using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string id, tenTk, passWd, hovatendem, ten, diachi, lastLogin, ngaySinh, createDay; 
        private int pers, tinhTrang;
        private byte[] avt;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TENTK
        {
            get { return tenTk; }
            set { tenTk = value; }
        }
        public string PASSWD
        {
            get { return passWd; }
            set { passWd = value; }
        }
        public byte[] AVT
        {
            get { return avt; }
            set { avt = value; }
        }
        public string HOVATENDEM
        {
            get { return hovatendem; }
            set { hovatendem = value; }
        }
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }
        public string DIACHI
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string LASTLOGIN
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
        public string NGAYSINH
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string CREATEDAY
        {
            get { return createDay; }
            set { createDay = value; }
        }
        public int PERS
        {
            get { return pers; }
            set { pers = value; }
        }
        public int TINHTRANG
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public TaiKhoan(string id, string tenTk, string passWd, byte[]avt, string hovatendem, string ten, string ngaySinh, string diachi, string lastLogin, string createDay, int pers, int tinhTrang)
        {
            this.ID = id;
            this.TENTK = tenTk;
            this.PASSWD = passWd;
            this.AVT = avt;
            this.HOVATENDEM = hovatendem;
            this.TEN = ten;
            this.NGAYSINH = ngaySinh;
            this.DIACHI = diachi;
            this.LASTLOGIN = lastLogin;
            this.CREATEDAY = createDay;
            this.PERS = pers;
            this.TINHTRANG = tinhTrang;
        }
        public TaiKhoan(string id, string passWd, byte[] avt, string hovatendem, string ten, string ngaySinh, string diachi, int pers, int tinhTrang)
        {
            this.ID = id;
            this.PASSWD = passWd;
            this.AVT = avt;
            this.HOVATENDEM = hovatendem;
            this.TEN = ten;
            this.NGAYSINH = ngaySinh;
            this.DIACHI = diachi;
            this.PERS = pers;
            this.TINHTRANG = tinhTrang;
        }
        public TaiKhoan(string id, string hovatendem, string ten, string ngaySinh, string diachi, int pers, int tinhTrang)
        {
            this.ID = id;      
            this.HOVATENDEM = hovatendem;
            this.TEN = ten;
            this.NGAYSINH = ngaySinh;
            this.DIACHI = diachi;
            this.PERS = pers;
            this.TINHTRANG = tinhTrang;
        }
        public TaiKhoan()
        {

        }

    }
}

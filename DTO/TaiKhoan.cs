using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string id, tenTk, passWd, hovatendem, ten, diachi, lastLogin, ngaySinh, createDay;
        int pers;
        bool tinhTrang;
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
        public bool TINHTRANG
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public TaiKhoan(string id, string tenTk, string passWd, string hovatendem, string ten, string ngaySinh, string diachi, string lastLogin, string createDay, int pers, bool tinhTrang)
        {
            this.id = id;
            this.tenTk = tenTk;
            this.passWd = passWd;
            this.hovatendem = hovatendem;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diachi = diachi;
            this.lastLogin = lastLogin;
            this.createDay = createDay;
            this.pers = pers;
            this.tinhTrang = tinhTrang;
        }
        public TaiKhoan( string tenTk, string passWd, string hovatendem, string ten, string ngaySinh, string diachi, string lastLogin, string createDay, int pers, bool tinhTrang)
        {
            this.tenTk = tenTk;
            this.passWd = passWd;
            this.hovatendem = hovatendem;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.diachi = diachi;
            this.createDay = createDay;
            this.pers = pers;
            this.tinhTrang = tinhTrang;
        }
        public TaiKhoan()
        {

        }

    }
}

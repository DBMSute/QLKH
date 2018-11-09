using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Kho
    {
        private string id,  ten, diaChi, taiKhoan;
        private int gioiHan;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public Kho(string id,string ten, string diaChi, string taiKhoan, int gioiHan)
        {
            this.ID = id;
            this.TAIKHOAN = taiKhoan;
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.GIOIHAN = gioiHan;
        }
        public Kho( string ten, string diaChi,string taiKhoan, int gioiHan)
        {
            this.TAIKHOAN = taiKhoan;
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.GIOIHAN = gioiHan;
        }
        public Kho( string ten, string diaChi, int gioiHan)
        {
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.GIOIHAN = gioiHan;
        }
      public Kho()
        {

        }
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }
        public string DIACHI
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string TAIKHOAN
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public int GIOIHAN
        {
            get { return gioiHan; }
            set { gioiHan = value; }
        }
    }
}

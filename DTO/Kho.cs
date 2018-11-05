using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Kho
    {
        public string id,  ten, diaChi, taiKhoan;
        public bool tinhTrang;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public Kho(string id,string ten, string diaChi, string taiKhoan, bool tinhTrang)
        {
            this.id = id;
            this.taiKhoan = taiKhoan;
            this.ten = ten;
            this.diaChi = diaChi;
            this.tinhTrang = tinhTrang;
        }
        public Kho( string ten, string diaChi,string taiKhoan, bool tinhTrang)
        {
            this.taiKhoan = taiKhoan;
            this.ten = ten;
            this.diaChi = diaChi;
            this.tinhTrang = tinhTrang;
        }
        public Kho( string ten, string diaChi, bool tinhTrang)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.tinhTrang = tinhTrang;
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
        public bool TINHTRANG
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
    }
}

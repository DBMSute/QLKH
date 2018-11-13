using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Kho
    {
        private string id,  ten, diaChi, mng;
        private int gioiHan, soLuongHang = 0;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public Kho(string id,string ten, string diaChi, string mng, int gioiHan, int soLuongHang)
        {
            this.ID = id;
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.MNG = mng;
            this.GIOIHAN = gioiHan;
            this.SOLUONGHANG = soLuongHang;
        }
        public Kho(string id, string ten, string diaChi, string mng, int gioiHan)
        {
            this.ID = id;
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.MNG = mng;
            this.GIOIHAN = gioiHan;
        }
        public Kho(string ten, string diaChi, string mng, int gioiHan)
        {
            this.TEN = ten;
            this.DIACHI = diaChi;
            this.MNG = mng;
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
        public string MNG
        {
            get { return mng; }
            set { mng = value; }
        }
        public int GIOIHAN
        {
            get { return gioiHan; }
            set { gioiHan = value; }
        }
        public int SOLUONGHANG
        {
            get { return soLuongHang; }
            set { soLuongHang = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SanPham
    {
        private string id, ten, idLoai, tenLoai, idKho, donViTinh, tinhTrang;
        private double donGia;
        private int soluong;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }
        public string IDLoai
        {
            get { return idLoai; }
            set { idLoai = value; }
        }
        public string TENLOAI
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
        public string IDKho
        {
            get { return idKho; }
            set { idKho = value; }
        }
        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string DONVITINH
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        public double DONGIA
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public string TINHTRANG
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public SanPham(string id, string ten, string idLoai, string tenLoai, string idKho, int soluong, double donGia, string donViTinh, string tinhTrang)
        {
            this.ID = id;
            this.TEN = ten;
            this.IDLoai = idLoai;
            this.TENLOAI = tenLoai;
            this.IDKho = idKho;
            this.SOLUONG = soluong;
            this.DONVITINH = donViTinh;
            this.DONGIA = donGia;
            this.TINHTRANG = tinhTrang;
        }
        public SanPham()
        { 
        }
    }
}

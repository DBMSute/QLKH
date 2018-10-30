using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string id, ten, idLoai, idKho, donViTinh,tenKho,diaChi;
        public float donGia;
        public bool tinhTrang;
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
        public string IDKho
        {
            get { return idKho; }
            set { idKho = value; }
        }
        public string DONVITINH
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        public float DONGIA
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public bool TINHTRANG
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public string TENKHO
        {
            get { return tenKho; }
            set { tenKho = value; }
        }
        public string DIACHI
        {
            get { return diaChi; }
            set {diaChi = value; }
        }
        public SanPham(string id,string ten,string idLoai,string idKho,float donGia,string donViTinh
            ,string tenKho,string diaChi,bool tinhTrang)
        {
            this.id = id;
            this.ten = ten;
            this.idLoai = idLoai;
            this.idKho = idKho;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.tinhTrang = tinhTrang;
            this.tenKho = tenKho;
            this.diaChi = diaChi;
        }
        public SanPham(string id, string ten, string idKho, float donGia, string donViTinh
           , string tenKho, string diaChi, bool tinhTrang)
        {
            this.id = id;
            this.ten = ten;
            this.idKho = idKho;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.tinhTrang = tinhTrang;
            this.tenKho = tenKho;
            this.diaChi = diaChi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private string idpn, tensp, tenncc, tenlsp, tenkho, dvtiente;
        private int soLuong;
        private double donGia, tong;

        public string IDPN
        {
            get { return idpn; }
            set { idpn = value; }
        }
        
        public string TENSP
        {
            get { return tensp; }
            set { tensp = value; }
        }
        
        public string TENNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }
        public string TENLSP
        {
            get { return tenlsp; }
            set { tenlsp = value; }
        }
        
        public string TENKHO
        {
            get { return tenkho; }
            set { tenkho = value; }
        }
        public double DONGIA
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public double TONG
        {
            get { return tong; }
            set { tong = value; }
        }
        public string DVTIENTE
        {
            get { return dvtiente; }
            set { dvtiente = value; }
        }
        public ChiTietPhieuNhap(string idpn, string tensp, string tenncc, string tenlsp, string tenkho, double donGia, int soLuong, double tong, string dvtiente)
        {
            this.IDPN = idpn;
            this.TENSP = tensp;
            this.TENNCC = tenncc;
            this.TENLSP = tenlsp;
            this.TENKHO = tenkho;
            this.DONGIA = donGia;
            this.SOLUONG = soLuong;
            this.TONG = tong;
            this.DVTIENTE = dvtiente;
        }
        public ChiTietPhieuNhap(string idpn, string tensp, string tenloai, string tenkho, string tenncc, double dongia, int soluong, string dvtiente)
        {
            this.IDPN = idpn;
            this.TENSP = tensp;
            this.TENLSP = tenloai;
            this.TENKHO = tenkho;
            this.TENNCC = tenncc;
            this.DONGIA = dongia;
            this.SOLUONG = soluong;
            this.DVTIENTE = dvtiente;
        }
        public ChiTietPhieuNhap()
        {

        }
    }
}

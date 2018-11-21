using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ChiTietPhieuXuat
    {
        private string idpn, tensp, tenkh, tenlsp, tenkho, dvtiente;
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

        public string TENKH
        {
            get { return tenkh; }
            set { tenkh = value; }
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
        public ChiTietPhieuXuat(string idpn, string tensp, string tenkh, string tenlsp, string tenkho, double donGia, int soLuong, double tong, string dvtiente)
        {
            this.IDPN = idpn;
            this.TENSP = tensp;
            this.TENKH = tenkh;
            this.TENLSP = tenlsp;
            this.TENKHO = tenkho;
            this.DONGIA = donGia;
            this.SOLUONG = soLuong;
            this.TONG = tong;
            this.DVTIENTE = dvtiente;
        }
        public ChiTietPhieuXuat(string idpn, string tensp, string tenkho, string tenkh, double dongia, int soluong, string dvtiente)
        {
            this.IDPN = idpn;
            this.TENSP = tensp;
            this.TENKHO = tenkho;
            this.TENKH = tenkh;
            this.DONGIA = dongia;
            this.SOLUONG = soluong;
            this.DVTIENTE = dvtiente;
        }
        public ChiTietPhieuXuat()
        {

        }
    }
}

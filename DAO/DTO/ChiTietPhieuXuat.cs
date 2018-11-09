using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ChiTietPhieuXuat
    {
        public string idpx, idsp, idkh, idkho, soLuong, tongTien;
        public string IDPX
        {
            get { return idpx; }
            set { idpx = value; }
        }
        public string IDSP
        {
            get { return idsp; }
            set { idsp = value; }
        }
        public string IDKH
        {
            get { return idkh; }
            set { idkh = value; }
        }
        public string IDKHO
        {
            get { return idkho; }
            set { idkho = value; }
        }
        public string SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string TONGTIEN
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public ChiTietPhieuXuat(string idpx, string idsp, string idkh, string idkho, string
            soLuong, string tongTien)
        {
            this.idpx = idpx;
            this.idsp = idsp;
            this.idkh = idkh;
            this.idkho = idkho;
            this.soLuong = soLuong;
            this.tongTien = tongTien;
        }
    }
}

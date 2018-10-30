using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChiTietPhieuNhap
    {
       public string idpn, idsp, idncc, donGia, soLuong, tong;
       public string IDPN
       {
           get { return idpn; }
           set { idpn = value; }
       }
       public string IDSP
       {
           get { return idsp; }
           set { idsp = value; }
       }
       public string IDNCC
       {
           get { return idncc; }
           set { idncc = value; }
       }
       public string DONGIA
       {
           get { return donGia; }
           set { donGia = value; }
       }
       public string SOLUONG
       {
           get { return soLuong; }
           set { soLuong = value; }
       }
       public string TONG
       {
           get { return tong; }
           set { tong = value; }
       }
       public ChiTietPhieuNhap(string idpn,string idsp,string idncc,string donGia,
           string soLuong,string tong)
       {
           this.idpn = idpn;
           this.idsp = idsp;
           this.idncc = idncc;
           this.donGia = donGia;
           this.soLuong = soLuong;
           this.tong = tong;
       }
    }
}

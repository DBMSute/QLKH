using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Kho
    {
      public string id, ten, diaChi, taiKhoan;
       bool tinhTrang;
       public Kho(string id,string ten,string diaChi,string taiKhoan,bool tinhTrang)
       {
           this.id = id;
           this.ten = ten;
           this.diaChi = diaChi;
           this.taiKhoan = taiKhoan;
           this.tinhTrang = tinhTrang;
       }
       public Kho(string id, string ten, string diaChi, bool tinhTrang)
       {
           this.id = id;
           this.ten = ten;
           this.diaChi = diaChi;
           this.tinhTrang = tinhTrang;
       }
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
           set{tinhTrang=value;}
       }
    }
}

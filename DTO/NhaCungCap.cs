using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhaCungCap
    {
       public string id, ten, diaChi, soDT, qGia;
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
       public string SODT
       {
           get { return soDT; }
           set { soDT = value; }
       }
       public string QGIA
       {
           get { return qGia; }
           set {qGia = value; }
       }
       public NhaCungCap(string id,string ten,string diaChi,string soDT,string qGia)
       {
           this.id = id;
           this.ten = ten;
           this.diaChi = diaChi;
           this.soDT = soDT;
           this.qGia = qGia;
       }
    }
}

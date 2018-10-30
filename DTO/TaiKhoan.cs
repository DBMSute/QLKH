using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan
    {
       public string id, tenTk, passWd, createDay;
       int pers;
       bool tinhTrang;
       public string ID
       {
           get { return id; }
           set { id = value; }
       }
       public string TENTK
       {
           get { return tenTk; }
           set { tenTk = value; }
       }
       public string PASSWD
       {
           get { return passWd; }
           set { passWd = value; }
       }
       public string CREATEDAY
       {
           get { return createDay; }
           set { createDay = value; }
       }
       public int PERS
       {
           get { return pers; }
           set { pers = value; }
       }
       public bool TINHTRANG
       {
           get { return tinhTrang; }
           set { tinhTrang = value; }
       }
       public TaiKhoan(string id,string tenTk,string passWd,string createDay,int pers,bool tinhTrang)
       {
           this.id = id;
           this.tenTk = tenTk;
           this.passWd = passWd;
           this.createDay = createDay;
           this.pers = pers;
           this.tinhTrang = tinhTrang;
       }
    }
}

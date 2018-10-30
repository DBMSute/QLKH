using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class MatKhauCu
    {
       public string id, idTk, passWd;
       public string ID
       {
           get { return id; }
           set { id = value; }
       }
       public string IDTK
       {
           get { return idTk; }
           set { idTk = value; }
       }
       public string PASSWD
       {
           get { return passWd; }
           set { passWd = value; }
       }
       public MatKhauCu(string id,string idTk,string passWd)
       {
           this.id = id;
           this.idTk = idTk;
           this.passWd = passWd;
       }
    }
}

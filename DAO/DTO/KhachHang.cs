using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHang
    {

        public string id, ten, soDT, diaChi;
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
        public string SODT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public string DIACHI
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public KhachHang()
        {

        }
        public KhachHang( string ten, string soDT, string diaChi)
        {
            this.ten = ten;
            this.soDT = soDT;
            this.diaChi = diaChi;
        }
        public KhachHang(string id, string ten, string soDT, string diaChi)
        {
            this.id = id;
            this.ten = ten;
            this.soDT = soDT;
            this.diaChi = diaChi;
        }
    }
}

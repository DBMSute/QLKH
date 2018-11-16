using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHang
    {

        private string id, ten, soDT, diaChi;
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
        public KhachHang(string ten, string soDT, string diaChi)
        {
            this.TEN = ten;
            this.SODT = soDT;
            this.DIACHI = diaChi;
        }
        public KhachHang(string id, string ten, string soDT, string diaChi)
        {
            this.ID = id;
            this.TEN = ten;
            this.SODT = soDT;
            this.DIACHI = diaChi;
        }
    }
}

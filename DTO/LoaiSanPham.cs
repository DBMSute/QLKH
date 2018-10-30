using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        public string id, ten, moTa;
        public string ID
        {
            get { return id; }
            set { id = value;}
        }
        public string TEN
        {
            get { return ten; }
            set { ten = value; }
        }
        public string MOTA
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public LoaiSanPham(string id,string ten,string moTa)
        {
            this.id = id;
            this.ten = ten;
            this.moTa = moTa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PhieuXuat
    {
        private string id, ngayGio, taiKhoan;
        private int trangThai;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NGAYGIO
        {
            get { return ngayGio; }
            set { ngayGio = value; }
        }
        public int TRANGTHAI
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string TAIKHOAN
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public PhieuXuat(string id, string ngayGio, int trangThai,string taiKhoan)
        {
            this.ID = id;
            this.NGAYGIO = ngayGio;
            this.TRANGTHAI = trangThai;
            this.TAIKHOAN = taiKhoan;
        }

        public PhieuXuat()
        {

        }
    }
}

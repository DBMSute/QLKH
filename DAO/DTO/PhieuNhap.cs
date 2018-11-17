using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PhieuNhap
    {
        private string id, ngayGio;
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
        public PhieuNhap(string id, string ngayGio, int trangThai)
        {
            this.ID = id;
            this.NGAYGIO = ngayGio;
            this.TRANGTHAI = trangThai;
        }
        public PhieuNhap()
        {

        }
    }
}

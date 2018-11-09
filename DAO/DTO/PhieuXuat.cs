using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PhieuXuat
    {
        public string id, ngayGio, trangThai;
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
        public string TRANGTHAI
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public PhieuXuat(string id, string ngayGio, string trangThai)
        {
            this.id = id;
            this.ngayGio = ngayGio;
            this.trangThai = trangThai;
        }
    }
}

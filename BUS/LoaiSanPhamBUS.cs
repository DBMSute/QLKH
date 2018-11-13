using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        private static LoaiSanPhamBUS instance;
        public static LoaiSanPhamBUS Instance
        {
            get
            {
                if (instance == null) return new LoaiSanPhamBUS();
                return instance;
            }
        }

        public List<string> loadDataTen()
        {
            List<string> lten = new List<string>();
            foreach (DTO.LoaiSanPham lsp in DAO.LoaiSanPhamDAO.Instace.loadData())
            {
                lten.Add(lsp.TEN);
            }
            return lten;
        }
    }
}

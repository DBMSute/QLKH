using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instace
        {
            get
            {
                if (instance == null) return new NhanVienBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv)
        {
            dgv.DataSource = DAO.NhanVienDAO.Instance.loadData();
        }

        public void Insert(string tentk, string passWd, byte[] avt, string hovatendem, string ten, string ngaysinh, string diachi, int pers, int tinhtrang)
        {
            DTO.TaiKhoan tk = new DTO.TaiKhoan();
            tk.TENTK = tentk;
            tk.PASSWD = passWd;
            tk.AVT = avt;
            tk.HOVATENDEM = hovatendem;
            tk.TEN = ten;
            tk.NGAYSINH = ngaysinh;
            tk.DIACHI = diachi;
            tk.PERS = pers;
            tk.TINHTRANG = tinhtrang;
            DAO.NhanVienDAO.Instance.Insert(tk);
        }

        public void saveEdit(DataGridView dgv)
        {
            List<DTO.TaiKhoan> lNV = new List<DTO.TaiKhoan>();
            DTO.TaiKhoan tk = new DTO.TaiKhoan();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                tk = new DTO.TaiKhoan(
                    dr.Cells[0].Value.ToString().Trim(),
                    dr.Cells[4].Value.ToString().Trim(),
                    dr.Cells[5].Value.ToString().Trim(),
                    dr.Cells[7].Value.ToString().Trim(),
                    dr.Cells[6].Value.ToString().Trim(),
                    (int)dr.Cells[10].Value,
                    (int)dr.Cells[11].Value);
                lNV.Add(tk);
            }
            DAO.NhanVienDAO.Instance.saveEdit(lNV);
        }

        public void Delete(string id)
        {
            DAO.NhanVienDAO.Instance.Delete(id);
        }

        public void searchByKeyword(DataGridView dgv, string keyword, int status)
        {
            dgv.DataSource = DAO.NhanVienDAO.Instance.searchByKeyword(keyword, status);
        }
    }
}

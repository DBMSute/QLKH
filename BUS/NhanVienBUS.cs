using System;
using System.Collections.Generic;
using System.Data;
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
        public static NhanVienBUS INSTANCE
        {
            get
            {
                if (instance == null) return new NhanVienBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv, string idper)
        {
            dgv.DataSource = DAO.NhanVienDAO.INSTANCE.loadData(idper);
        }

        public List<string> loadIdMng()
        {
            List<string> lMng = new List<string>();
            foreach (DataRow dr in DAO.KhoDAO.INSTANCE.loadDataMng().Rows)
                lMng.Add(dr[1].ToString());
            return lMng;
        }

        public void Insert(string tentk, string passWd, byte[] avt, string hovatendem, string ten, string ngaysinh, string diachi, int pers, int tinhtrang, string quanLy)
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
            tk.QUANLY = quanLy;
            DAO.NhanVienDAO.INSTANCE.Insert(tk);
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
                    (int)dr.Cells[11].Value,
                    dr.Cells[12].Value.ToString().Trim());
                lNV.Add(tk);
            }
            DAO.NhanVienDAO.INSTANCE.saveEdit(lNV);
        }

        public void Delete(string id)
        {
            DAO.NhanVienDAO.INSTANCE.Delete(id);
        }

        public void searchByKeyword(DataGridView dgv, string keyword, int status)
        {
            dgv.DataSource = DAO.NhanVienDAO.INSTANCE.searchByKeyword(keyword, status);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
   public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS INSTANCE
        {
            get
            {
                if (instance == null) return new KhachHangBUS();
                return instance;
            }
        }

        public void loadData(DataGridView dgv)
        {
            dgv.DataSource = DAO.KhachHangDAO.INSTANCE.loadData();
        }

        public List<string> loadDataTen()
        {
            List<string> lTen = new List<string>();
            foreach (DTO.KhachHang kh in DAO.KhachHangDAO.INSTANCE.loadData())
                lTen.Add(kh.TEN.ToString());
            return lTen;
        }

        public void searchByKeyword(DataGridView dgv, string keyword)
        {
            dgv.DataSource = DAO.KhachHangDAO.INSTANCE.searchByKeyword(keyword);
        }

        public void Insert(DataGridView dgv)
        {
            dgv.DataSource = DAO.KhachHangDAO.INSTANCE.Insert();
        }

        public void Delete(string id)
        {
            DAO.KhachHangDAO.INSTANCE.Delete(id);
        }

        public void saveInsert(DataGridView dgv)
        {
            DTO.KhachHang kh = new DTO.KhachHang();
            kh = new DTO.KhachHang(
                    dgv.Rows[0].Cells[1].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[2].Value.ToString().Trim(),
                    dgv.Rows[0].Cells[3].Value.ToString().Trim());
            DAO.KhachHangDAO.INSTANCE.saveInsert(kh);
        }

        public void saveEdit(DataGridView dgv)
        {
            List<DTO.KhachHang> lKH = new List<DTO.KhachHang>();
            DTO.KhachHang kh = new DTO.KhachHang();

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                kh = new DTO.KhachHang(
                    dr.Cells[0].Value.ToString().Trim(),
                    dr.Cells[1].Value.ToString().Trim(),
                    dr.Cells[2].Value.ToString().Trim(),
                    dr.Cells[3].Value.ToString().Trim());
                lKH.Add(kh);
            }
            DAO.KhachHangDAO.INSTANCE.saveEdit(lKH);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
   public class KhoBUS
    {
       private static KhoBUS instance;
       int index;
       public static KhoBUS Instance
        {
            get
            {
                if (instance == null) return new KhoBUS();
                return instance;
            }
        }
       public void loadData(DataGridView dt)
       {
          dt.DataSource = DAO.KhoDAO.Instance.loadData();
       }
       public void timKiem(DataGridView dt,string strTimKiem)
       {
          dt.DataSource = DAO.KhoDAO.Instance.timKiem(strTimKiem);
       }
       public void LuuThem(DataGridView dgv)
       {
              List<DTO.Kho> lKho = new List<DTO.Kho>();
               try
               {
                   foreach (DataGridViewRow dr in dgv.Rows)
                   {
                       DTO.Kho k = new DTO.Kho(dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString()
                           , (bool)dr.Cells[4].Value);
                       lKho.Add(k);
                   }
                   DAO.KhoDAO.Instance.LuuThem(lKho);
               }
               catch
               {
                   MessageBox.Show("lỗi rồi !");
               }
               finally
               {
                   MessageBox.Show(" Thêm thành công  !");
               }
       }
       public void LuuSua(DataGridView dgv)
       {
           List<DTO.Kho> lKho = new List<DTO.Kho>();
           try
           {
               foreach (DataGridViewRow dr in dgv.Rows)
               {
                   DTO.Kho k = new DTO.Kho(dr.Cells[0].Value.ToString(),
                       dr.Cells[1].Value.ToString(),
                       dr.Cells[2].Value.ToString(),
                       dr.Cells[3].Value.ToString()
                       , (bool)dr.Cells[4].Value);
                   lKho.Add(k);
               }
               DAO.KhoDAO.Instance.LuuSua(lKho);
           }
           catch
           {
               MessageBox.Show("lỗi rồi !");
           }
           finally
           {
               MessageBox.Show(" Sửa thành công  !");
           }
       }
       public void themKho(DataGridView dt)
       {
           dt.DataSource = DAO.KhoDAO.Instance.themKho();
       }
       public void xoaKho(DataGridView dt,string str)
       {
           try {
            index = dt.CurrentCell.RowIndex;
            string id = dt.Rows[index].Cells[0].Value.ToString();
            DAO.KhoDAO.Instance.xoaKho(id);
           }
           catch
           {
               MessageBox.Show("Không xóa được !");
           }
           finally
           {
               MessageBox.Show("Xóa thành công !");
           }
           timKiem(dt, str);
       }
    }
}

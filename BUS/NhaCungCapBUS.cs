    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
   public class NhaCungCapBUS
    {
       private static NhaCungCapBUS instance;
       public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null) return new NhaCungCapBUS();
                return instance;
            }
        }
       public void loadData(DataGridView dgv)
       {
           dgv.DataSource = DAO.NhaCungCapDAO.Instance.loadData();
       }
       public void TimKiem(DataGridView dgv,string str)
       {
           dgv.DataSource = DAO.NhaCungCapDAO.Instance.timKiem(str);
       }

       public void Them(DataGridView dgv)
       {
           dgv.DataSource = DAO.NhaCungCapDAO.Instance.Them();
       }
       public void LuuThem(DataGridView dgv)
       {
           List<DTO.NhaCungCap> lncc = new List<DTO.NhaCungCap>();
           try
           {
               foreach(DataGridViewRow dr in dgv.Rows)
               {
                   DTO.NhaCungCap ncc = new DTO.NhaCungCap(dr.Cells[1].Value.ToString(),
                     dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString());
                   lncc.Add(ncc);
               }
               DAO.NhaCungCapDAO.Instance.LuuThem(lncc);
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
       public void Xoa(DataGridView dgv,string str)
       {
           try{
          int index = dgv.CurrentCell.RowIndex;
           string id = dgv.Rows[index].Cells[0].Value.ToString();
           DAO.NhaCungCapDAO.Instance.Xoa(id);
           }
           catch
           {
               MessageBox.Show("Không xóa được !");
           }
           finally
           {
               MessageBox.Show("Xóa thành công !");
           }
           TimKiem(dgv,str);
       }
       public void LuuSua(DataGridView dgv)
       {
           List<DTO.NhaCungCap> lncc = new List<DTO.NhaCungCap>();
           try
           {
               foreach (DataGridViewRow dr in dgv.Rows)
               {
                   DTO.NhaCungCap ncc = new DTO.NhaCungCap(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(),
                     dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString());
                   lncc.Add(ncc);
               }
               DAO.NhaCungCapDAO.Instance.LuuSua(lncc);
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

    }
}

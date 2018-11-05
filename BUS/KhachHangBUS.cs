using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
   public class KhachHangBUS
    {
       private static KhachHangBUS instance;
       public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null) return new KhachHangBUS();
                return instance;
            }
        }
       public  void loadData(DataGridView dgv)
       {
           dgv.DataSource = DAO.KhachHangDAO.Instance.loadData();
       }
       public void timKiem(DataGridView dgv,string str)
       {
           dgv.DataSource = DAO.KhachHangDAO.Instance.timKiem(str);
       }
       public void Them(DataGridView dgv)
       {
           dgv.DataSource = DAO.KhachHangDAO.Instance.Them();
       }
       public void Xoa(DataGridView dt,string str)
       {
           try
           {
               int index = dt.CurrentCell.RowIndex;
               string id = dt.Rows[index].Cells[0].Value.ToString();
               DAO.KhachHangDAO.Instance.Xoa(id);
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
       public void LuuThem(DataGridView dgv)
       {
           List<DTO.KhachHang> lKh = new List<DTO.KhachHang>();
           try
           {
               foreach (DataGridViewRow dr in dgv.Rows)
               {
                   DTO.KhachHang kh = new DTO.KhachHang(dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString());
                   lKh.Add(kh);
               }
               DAO.KhachHangDAO.Instance.LuuThem(lKh);
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
           List<DTO.KhachHang> lKh = new List<DTO.KhachHang>();
           try
           {
               foreach (DataGridViewRow dr in dgv.Rows)
               {
                   DTO.KhachHang kh = new DTO.KhachHang(dr.Cells[0].Value.ToString(), 
                       dr.Cells[1].Value.ToString(),
                       dr.Cells[2].Value.ToString(),
                       dr.Cells[3].Value.ToString());
                   lKh.Add(kh);
               }
               DAO.KhachHangDAO.Instance.LuuSua(lKh);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;
        public static KhoDAO Instance
        {
            get
            {
                if (instance == null) return new KhoDAO();
                return instance;
            }
        }
        public List<Kho> loadData()
        {
            List<Kho> lKho = new List<Kho>();
            string str = "SELECT * FROM dbo.VI_Kho_LoadData";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["diachi"].ToString();
                string mng = item["manager"].ToString();
                int gioiHan = (int)item["gioihan"];
                int soLuongHang = (int)item["soluonghang"];
                Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                lKho.Add(kh);
            }
            return lKho;
        }
        public DataTable loadDataMng()
        {
            string str = "SELECT * FROM dbo.FN_TaiKhoan_GetNameByPers(2)";
            return DataConn.Instance.ExecuteQueryTable(str);
        }
        public List<Kho> searchByKeyword(string keyword)
        {
            List<Kho> lKho = new List<Kho>();
            string str = "SELECT * FROM dbo.FN_Kho_SearchByKeyword(N'" + keyword + "')";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);
            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["diachi"].ToString();
                string mng = item["manager"].ToString();
                int gioiHan = (int)item["gioihan"];
                int soLuongHang = (int)item["soluonghang"];
                Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                lKho.Add(kh);
            }
            return lKho;
        }

        public List<Kho> searchByNum(int num, int comp, int type)
        {
            List<Kho> lKho = new List<Kho>();
            if(type == 1)
            {
                string str = "SELECT * FROM dbo.FN_Kho_SearchByLimite(" + num + "," + comp + ")";
                DataTable data = DataConn.Instance.ExecuteQueryTable(str);
                foreach (DataRow item in data.Rows)
                {
                    string id = item["id"].ToString();
                    string ten = item["ten"].ToString();
                    string diaChi = item["diachi"].ToString();
                    string mng = item["manager"].ToString();
                    int gioiHan = (int)item["gioihan"];
                    int soLuongHang = (int)item["soluonghang"];
                    Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                    lKho.Add(kh);
                }
            }
            else
            {
                string str = "SELECT * FROM dbo.FN_Kho_SearchByAmount(" + num + "," + comp + ")";
                DataTable data = DataConn.Instance.ExecuteQueryTable(str);
                foreach (DataRow item in data.Rows)
                {
                    string id = item["id"].ToString();
                    string ten = item["ten"].ToString();
                    string diaChi = item["diachi"].ToString();
                    string mng = item["manager"].ToString();
                    int gioiHan = (int)item["gioihan"];
                    int soLuongHang = (int)item["soluonghang"];
                    Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                    lKho.Add(kh);
                }
            }
            return lKho;
        }

        public void saveInsert(Kho k)
        {
            string str = "EXEC dbo.sp_Insert_Kho @ten = N'" + k.TEN + "'," +
                         "@dchi = N'" + k.DIACHI + "'," +
                         "@mng = N'" + k.MNG + "'," +
                         "@gioihan = " + k.GIOIHAN;
            DataConn.Instance.ExecuteQueryTable(str);
        }

        public void saveEdit(List<Kho> lKho)
        {
            for (int i = 0; i < lKho.Count; i++)
            {
                string str = "EXEC dbo.sp_Update_Kho @id = '" + lKho[i].ID + "'," +
                             "@ten = N'" + lKho[i].TEN + "'," +
                             "@dchi = N'" + lKho[i].DIACHI + "'," +
                             "@mng = N'" + lKho[i].MNG + "'," +
                             "@gioihan = " + lKho[i].GIOIHAN;

                DataConn.Instance.ExecuteQueryTable(str);
            }
        }

        public List<Kho> Insert()
        {
            List<Kho> lKho = new List<Kho>();
            Kho k = new Kho();
            lKho.Add(k);
            string str = "SELECT * FROM dbo.VI_Kho_LoadData";
            DataTable data = DataConn.Instance.ExecuteQueryTable(str);

            foreach (DataRow item in data.Rows)
            {
                string id = item["id"].ToString();
                string ten = item["ten"].ToString();
                string diaChi = item["diachi"].ToString();
                string mng = item["manager"].ToString();
                int gioiHan = (int)item["gioihan"];
                int soLuongHang = (int)item["soluonghang"];
                Kho kh = new Kho(id, ten, diaChi, mng, gioiHan, soLuongHang);
                lKho.Add(kh);
            }
            return lKho;
        }

        public void Delete(string id)
       {
            string str = "EXEC dbo.sp_Delete_Kho @id = '" + id + "'";
           DataConn.Instance.ExecuteQueryTable(str);
       }
    }

}


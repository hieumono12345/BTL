using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.DTO;

namespace BTL.DAO
{
    public class QuanLyQnDAO
    {
        private static QuanLyQnDAO instance;

        public static QuanLyQnDAO Instance
        {
            get { if (instance == null) instance = new QuanLyQnDAO(); return instance; }
            private set { instance = value; }
        }

        private QuanLyQnDAO() { }

        public DataTable getDanhSachQN()
        {
            return DataProvider.Instance.ExecuteQuery("select a.MaQN, a.TenQN, b.TenDV,c.TenCV from QuanNhan a,DonVi b, ChucVu c where a.MaDV=b.MaDV and a.MaCV=c.MaCV");
        }
        public QuanNhan getChiTietQN(int id)
        {
            //return DataProvider.Instance.ExecuteQuery("select a.MaQN, a.TenQN, b.TenDV,c.TenCV from QuanNhan a,DonVi b, ChucVu c where a.MaDV=b.MaDV and a.MaCV=c.MaCV and MaQN="+id);
            List<QuanNhan> list = new List<QuanNhan>();
            //QuanNhan chiTiet = new QuanNhan(0,"");

            string query = "select a.MaQN, a.TenQN, b.TenDV,c.TenCV,a.GioiTinh GioiTinh from QuanNhan a,DonVi b, ChucVu c where a.MaDV=b.MaDV and a.MaCV=c.MaCV and MaQN=" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QuanNhan food = new QuanNhan(item);
                list.Add(food);
            }

            return list[0];
        }

    }
}

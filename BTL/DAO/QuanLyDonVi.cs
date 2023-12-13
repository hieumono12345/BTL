using BTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class QuanLyDonVi
    {
        private static QuanLyDonVi instance;

        public static QuanLyDonVi Instance
        {
            get { if (instance == null) instance = new QuanLyDonVi(); return instance; }
            private set { instance = value; }
        }

        private QuanLyDonVi() { }

        public List<DonVi> getListDonVi()
        {
            //return DataProvider.Instance.ExecuteQuery("select a.MaQN, a.TenQN, b.TenDV,c.TenCV from QuanNhan a,DonVi b, ChucVu c where a.MaDV=b.MaDV and a.MaCV=c.MaCV and MaQN="+id);
            List<DonVi> list = new List<DonVi>();
            //ChiTietQuanNhan chiTiet = new ChiTietQuanNhan(0,"");

            string query = "select * from DonVi" ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DonVi DV = new DonVi(item);
                list.Add(DV);
            }

            return list;
        }
    }
}

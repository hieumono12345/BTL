using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class QuanLyViPham
    {
        private static QuanLyViPham instance;

        public static QuanLyViPham Instance
        {
            get { if (instance == null) instance = new QuanLyViPham(); return instance; }
            private set { instance = value; }
        }

        private QuanLyViPham() { }

        public DataTable GetListViPham()
        {
            return DataProvider.Instance.ExecuteQuery("select c.TenQN ,a.TenViPham from ViPham a,QN_ViPham b,QuanNhan c where a.MaVP=b.MaVP and b.MaQN=c.MaQN");
        }
    }
}

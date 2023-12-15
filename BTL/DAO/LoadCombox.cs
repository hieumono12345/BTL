using BTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class LoadCombox
    {
        private static LoadCombox instance;

        public static LoadCombox Instance
        {
            get { if (instance == null) instance = new LoadCombox(); return instance; }
            private set { instance = value; }
        }

        private LoadCombox() { }

        public List<QN> getListQNGac()
        {
            List<QN> list = new List<QN>();

            string query = "select MaQN,TenQN from QuanNhan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QN a = new QN(item);
                list.Add(a);
            }

            return list ;
        }

        public List<ThoiGian> getListThoiGianGac()
        {
            List<ThoiGian> list = new List<ThoiGian>();

            string query = "SELECT * from ThoiGianGac";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThoiGian a = new ThoiGian(item);
                list.Add(a);
            }

            return list;
        }
    }
}

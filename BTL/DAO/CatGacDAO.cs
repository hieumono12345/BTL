using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class CatGacDAO
    {
        private static CatGacDAO instance;

        public static CatGacDAO Instance
        {
            get { if (instance == null) instance = new CatGacDAO(); return instance; }
            private set { instance = value; }
        }

        private CatGacDAO() { }

        public DataTable getDSGacByMaGac(int MaGac)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("" + MaGac);
            return data;
        }
    }
}

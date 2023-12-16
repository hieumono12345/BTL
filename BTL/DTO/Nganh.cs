using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class Nganh
    {
        public Nganh(int MaNganh, string TenNganh)
        {
            this.MaNganh = MaNganh;
            this.TenNganh = TenNganh;
        }
        public Nganh(DataRow row)
        {
            this.MaNganh = (int)row["MaNganh"];
            this.TenNganh = row["TenNganh"].ToString();
        }
        private int _MaNganh;

        public int MaNganh
        {
            get { return _MaNganh; }
            set { _MaNganh = value; }
        }

        private string _TenNganh;
        public string TenNganh
        {
            get { return _TenNganh; }
            set { _TenNganh = value; }
        }
    }
}

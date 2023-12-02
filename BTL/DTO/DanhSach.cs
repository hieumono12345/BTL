using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class DanhSach
    {
        public DanhSach(int ID, string TenDS)
        {
            this.ID = ID;
            this.TenDS = TenDS;
        }
        public DanhSach(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenDS = row["TenDS"].ToString();
        }
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _TenDS;
        public string TenDS
        {
            get { return _TenDS; }
            set { _TenDS = value; }
        }
    }
}

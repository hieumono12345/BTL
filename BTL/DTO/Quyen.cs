using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class Quyen
    {
        public Quyen(int MaQuyen, string TenQuyen)
        {
            this.MaQuyen = MaQuyen;
            this.TenQuyen = TenQuyen;
        }
        public Quyen(DataRow row)
        {
            this.MaQuyen = (int)row["MaQuyen"];
            this.TenQuyen = row["TenQuyen"].ToString();
        }
        private int _MaQuyen;

        public int MaQuyen
        {
            get { return _MaQuyen; }
            set { _MaQuyen = value; }
        }

        private string _TenQuyen;
        public string TenQuyen
        {
            get { return _TenQuyen; }
            set { _TenQuyen = value; }
        }
    }
}

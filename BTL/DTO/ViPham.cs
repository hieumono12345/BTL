using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ViPham
    {
        public ViPham(int MaVP, string TenViPham)
        {
            this.MaVP = MaVP;
            this.TenViPham = TenViPham;
        }
        public ViPham(DataRow row)
        {
            this.MaVP = (int)row["MaVP"];
            this.TenViPham = row["TenViPham"].ToString();
        }
        private int _MaVP;

        public int MaVP
        {
            get { return _MaVP; }
            set { _MaVP = value; }
        }

        private string _TenViPham;
        public string TenViPham
        {
            get { return _TenViPham; }
            set { _TenViPham = value; }
        }
    }
}

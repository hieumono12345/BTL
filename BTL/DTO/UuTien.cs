using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class UuTien
    {
        public UuTien(int MaUT, string TenUuTien)
        {
            this.MaUT = MaUT;
            this.TenUuTien = TenUuTien;
        }
        public UuTien(DataRow row)
        {
            this.MaUT = (int)row["MaUT"];
            this.TenUuTien = row["TenUuTien"].ToString();
        }
        private int _MaUT;

        public int MaUT
        {
            get { return _MaUT; }
            set { _MaUT = value; }
        }

        private string _TenUuTien;
        public string TenUuTien
        {
            get { return _TenUuTien; }
            set { _TenUuTien = value; }
        }
    }
}

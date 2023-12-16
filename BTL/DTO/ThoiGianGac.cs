using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ThoiGianGac
    {
        public ThoiGianGac(int MaTG, string ThoiGian)
        {
            this.MaTG = MaTG;
            this.ThoiGian = ThoiGian;
        }
        public ThoiGianGac(DataRow row)
        {
            this.MaTG = (int)row["MaTG"];
            this.ThoiGian = row["ThoiGian"].ToString();
        }

        private int _MaTG;
        public int MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }

        private string _ThoiGian;
        public string ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
    }
}

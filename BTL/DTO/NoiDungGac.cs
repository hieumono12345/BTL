using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class NoiDungGac
    {
        public NoiDungGac(int MaGac, DateTime NgayGac, string MKGac)
        {
            this.MaGac = MaGac;
            this.NgayGac = NgayGac;
            this.MKGac = MKGac;
        }
        public NoiDungGac(DataRow row)
        {
            this.MaGac = (int)row["MaGac"];
            this.NgayGac = (DateTime)row["NgayGac"];
            this.MKGac = row["MKGac"].ToString();
        }

        private int _MaGac;
        public int MaGac
        {
            get { return _MaGac; }
            set { _MaGac = value; }
        }

        private DateTime _NgayGac;
        public DateTime NgayGac
        {
            get { return _NgayGac; }
            set { _NgayGac = value; }
        }

        private string _MKGac;
        public string MKGac
        {
            get { return _MKGac; }
            set { _MKGac = value; }
        }
    }
}

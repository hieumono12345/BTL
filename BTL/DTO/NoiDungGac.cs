using DevExpress.XtraEditors.Filtering.Templates;
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
        public NoiDungGac(int MaGac, string Ngay, string Hoi,string Dap,string NhacNho, int MaDV)
        {
            this.MaGac = MaGac;
            this.Ngay = Ngay;
            this.Hoi = Hoi;
            this.Dap = Dap;
            this.NhacNho= NhacNho;
            this.MaDV = MaDV;
        }
        public NoiDungGac(DataRow row)
        {
            this.MaGac = (int)row["MaGac"];
            this.Ngay = row["Ngay"].ToString();
            this.Hoi = row["Hoi"].ToString();
            this.Dap= row["Dap"].ToString();
            this.NhacNho = row["NhacNho"].ToString();
            this.MaDV = (int)row["MaDV"];
        }

        private int _MaGac;
        public int MaGac
        {
            get { return _MaGac; }
            set { _MaGac = value; }
        }

        private string _Ngay;
        public string Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }

        private string _Hoi;
        public string Hoi
        {
            get { return _Hoi; }
            set { _Hoi = value; }
        }
        private string _Dap;
        public string Dap
        {
            get { return _Dap; }
            set { _Dap = value; }
        }
        private string _NhacNho;
        public string NhacNho
        {
            get { return _NhacNho; }
            set { _NhacNho = value; }
        }

        private int _MaDV;
        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
    }
}

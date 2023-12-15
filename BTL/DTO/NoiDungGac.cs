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
        public NoiDungGac(int MaGac, string Ngay, string Hoi,string Dap, string NhacNho, bool STTGac, string TenDV)
        {
            this.MaGac = MaGac;
            this.Ngay = Ngay;
            this.Hoi = Hoi;
            this.TenDV = TenDV;
            this.Dap = Dap;
            this.NhacNho= NhacNho;
            this.STTGac= STTGac;
        }
        public NoiDungGac(DataRow row)
        {
            this.MaGac = (int)row["MaGac"];
            //this.Ngay = (string)row["Ngay"];
            this.Ngay = row["Ngay"].ToString();
            this.Hoi = row["Hoi"].ToString();
            this.TenDV= row["TenDV"].ToString();
            this.Dap= row["Dap"].ToString();
            this.NhacNho = row["NhacNho"].ToString();
            //this.STTGac = (bool)row["STTGac"];
        }

        private int _MaGac;
        public int MaGac
        {
            get { return _MaGac; }
            set { _MaGac = value; }
        }
        private string _TenDV;
        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }
        private bool _STTGac;
        public bool STTGac
        {
            get { return _STTGac; }
            set { _STTGac = value; }
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
    }
}

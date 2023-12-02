using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL.DTO
{
    public class DonVi
    {
        public DonVi(int MaDV, string TenDV)
        {
            this.MaDV = MaDV;
            this.TenDV = TenDV;
        }
        public DonVi(DataRow row)
        {
            this.MaDV = (int)row["MaDV"];
            this.TenDV = row["TenDV"].ToString();
        }
        private int _maDV; 

        public int MaDV
        {
            get { return _maDV; }
            set { _maDV = value; }
        }

        private string _TenDV;
        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }
    }
}

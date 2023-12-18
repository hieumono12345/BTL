using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class CV
    {
        public CV(  string TenDonVi,  string TGBD, string TGKT )
        {
            
            this.TenDonVi = TenDonVi;
            this.TGBD = TGBD;
            this.TGKT = TGKT;
        }
        public CV(DataRow row)
        {
            this.TenDonVi = row["TenDV"].ToString();
            this.TGBD = row["TGBD"].ToString();
            this.TGKT = row["TGKT"].ToString();
        }
        private string _TenDonVi;
        public string TenDonVi
        {
            get { return _TenDonVi; }
            set { _TenDonVi = value; }
        }        

        private string _TGBD;
        public string TGBD
        {
            get { return _TGBD; }
            set { _TGBD = value; }
        }

        private string _TGKT;
        public string TGKT
        {
            get { return _TGKT; }
            set { _TGKT = value; }
        }

    }
}

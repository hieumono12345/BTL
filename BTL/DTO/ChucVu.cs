using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ChucVu
    {
        public ChucVu(int MaCV, string TenCV)
        {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }   
        public ChucVu(DataRow row)
        {
            this.MaCV = (int)row["MaCV"];
            this.TenCV = row["TenCV"].ToString();
        }
        private int _MaCV;

        public int MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }

        private string _TenCV;
        public string TenCV
        {
            get { return _TenCV; }
            set { _TenCV = value; }
        }
    }
}

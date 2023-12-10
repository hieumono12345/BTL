using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ChiTietQuanNhan
    {
        public ChiTietQuanNhan(int MaQN, string TenQN, string TenDV, string TenCV, int GioiTinh)
        {
            this.MaQN = MaQN;
            this.TenQN = TenQN;
            this.TenDV = TenDV;
            this.TenCV = TenCV;
            this.GioiTinh = GioiTinh;
        }
        public ChiTietQuanNhan(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.TenQN = row["TenQN"].ToString();
            this.TenDV = row["TenDV"].ToString();
            this.TenCV = row["TenCV"].ToString();
            this.GioiTinh = Convert.ToInt32(row["GioiTinh"]);
        }

        private int _MaQN;
        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }

        private string _TenQN;
        public string TenQN
        {
            get { return _TenQN; }
            set { _TenQN = value; }
        }

        private string _TenDV;
        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }

        private string _TenCV;
        public string TenCV
        {
            get { return _TenCV; }
            set { _TenCV = value; }
        }

        private int _GioiTinh;
        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
    }
}

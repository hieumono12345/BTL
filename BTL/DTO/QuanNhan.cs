using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class QuanNhan
    {
        public QuanNhan(int MaQN, string TenQN, int MaDV, int MaCV,string SDT,bool GioiTinh)
        {
            this.MaQN = MaQN;
            this.TenQN = TenQN;
            this.MaDV = MaDV;
            this.MaCV = MaCV;
            this.SDT = SDT;
            this.GioiTinh= GioiTinh;
        }
        public QuanNhan(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.TenQN = row["TenQN"].ToString();
            this.MaDV = (int)row["MaDV"];
            this.MaCV = (int)row["MaCV"];
            this.SDT = row["SDT"].ToString();
            this.GioiTinh =(bool)row["GioiTinh"];
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

        private int _MaDV;
        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        private int _MaCV;
        public int MaCV
        {
            get { return _MaCV; }
            set { _MaCV = value; }
        }

        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private bool _GioiTinh;
        public bool GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
    }
}

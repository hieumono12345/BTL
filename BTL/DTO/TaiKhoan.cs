using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int MaTk, string TenTk, string MatKhau, int MaQN)
        {
            this.MaTk = MaTk;
            this.TenTk = TenTk;
            this.MatKhau = MatKhau;
            this.MaQN = MaQN;
        }
        public TaiKhoan(DataRow row)
        {
            this.MaTk = (int)row["MaTk"];
            this.TenTk = row["TenTk"].ToString();
            this.MatKhau = row["MK"].ToString();
            this.MaQN = (int)row["MaQN"];
        }

        private int _MaTk;
        public int MaTk
        {
            get { return _MaTk; }
            set { _MaTk = value; }
        }

        private string _TenTk;
        public string TenTk
        {
            get { return _TenTk; }
            set { _TenTk = value; }
        }

        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        private int _MaQN;
        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class TTNguoiDung
    {
        public TTNguoiDung(int MaQN, int MaDV, int MaQuyen)
        {
            this.MaQN = MaQN;
            this.MaDV = MaDV;
            this.MaQuyen = MaQuyen;
        }
        public TTNguoiDung(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.MaDV = (int)row["MaDV"];
            this.MaQuyen = (int)row["MaQuyen"];
        }
        private int _MaQN;

        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }

        private int _MaDV;
        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }

        private int _MaQuyen;
        public int MaQuyen
        {
            get { return _MaQuyen; }
            set { _MaQuyen = value; }
        }
    }
}

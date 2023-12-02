using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class QN_ViPham
    {
        public QN_ViPham(int MaQN, int MaVP)
        {
            this.MaQN = MaQN;
            this.MaVP = MaVP;
        }
        public QN_ViPham(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.MaVP = (int)row["MaVP"];
        }
        private int _MaQN;

        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }

        private int _MaVP;
        public int MaVP
        {
            get { return _MaVP; }
            set { _MaVP = value; }
        }
    }
}

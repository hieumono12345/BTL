using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class QN_UuTien
    {
        public QN_UuTien(int MaQN, int MaUT)
        {
            this.MaQN = MaQN;
            this.MaUT = MaUT;
        }
        public QN_UuTien(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.MaUT = (int)row["MaUT"];
        }
        private int _MaQN;

        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }

        private int _MaUT;
        public int MaUT
        {
            get { return _MaUT; }
            set { _MaUT = value; }
        }
    }
}

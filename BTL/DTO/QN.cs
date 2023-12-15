using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class QN
    {
        public QN(int MaQN, string TenQN)
        {
            this.MaQN = MaQN;
            this.TenQN = TenQN;
        }
        public QN(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.TenQN = row["TenQN"].ToString();
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
    }
}

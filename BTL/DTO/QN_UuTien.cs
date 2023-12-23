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
        public QN_UuTien(int MaQN, int MaUT,string NoiDungUuTien)
        {
            this.MaQN = MaQN;
            this.MaUT = MaUT;
            this.NoiDungUuTien = NoiDungUuTien;
        }
        public QN_UuTien(DataRow row)
        {
            this.MaQN = (int)row["MaQN"];
            this.MaUT = (int)row["MaUuTien"];
            this.NoiDungUuTien = row["NoiDungUuTien"].ToString();
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
        private string _NoiDungUuTien;
        public string NoiDungUuTien
        {
            get { return _NoiDungUuTien; }
            set { _NoiDungUuTien = value; }
        }
    }
}

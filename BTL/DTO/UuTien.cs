using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class UuTien
    {
        public UuTien(int MaUT, int MaQN,string NoiDungUuTien)
        {
            this.MaUT = MaUT;
            this.MaQN = MaQN;
            this.NoiDungUuTien = NoiDungUuTien;
        }
        public UuTien(DataRow row)
        {
            this.MaUT = (int)row["MaUT"];
            this.MaQN = (int)row["MaQN"];
        }
        private int _MaUT;

        public int MaUT
        {
            get { return _MaUT; }
            set { _MaUT = value; }
        }

        private int _MaQN;
        public int MaQN
        {
            get { return _MaQN; }
            set { _MaQN = value; }
        }

        private string _NoiDungUuTien;
        public string NoiDungUuTien
        {
            get { return _NoiDungUuTien; }
            set { _NoiDungUuTien = value; }
        }
    }
}

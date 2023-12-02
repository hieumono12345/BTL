using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ChiTietDanhSachGac
    {
        public ChiTietDanhSachGac(int MaCTDSG, int MaDS, int MaTG, int MaQN, int MaGac )
        {
            this.MaCTDSG = MaCTDSG;
            this.MaDS = MaDS;
            this.MaTG = MaTG;
            this.MaQN = MaQN;
            this.MaGac = MaGac;
        }

        public ChiTietDanhSachGac(DataRow row)
        {
            this.MaCTDSG = (int)row["MaCTDSCV"];
            this.MaDS = (int)row["MaDS"];
            this.MaTG = (int)row["MaTG"];
            this.MaQN = (int)row["MaQN"];
            this.MaGac = (int)row["MaGac"];
        }

        private int _MaCTDSG;
        public int MaCTDSG
        {
            get { return this._MaCTDSG; }
            set { this._MaCTDSG = value; }
        }
        private int _MaTG;
        public int MaTG
        {
            get { return this._MaTG; }
            set { this._MaTG = value; }
        }

        private int _MaQN;
        public int MaQN
        {
            get { return this._MaQN; }
            set { this._MaQN = value; }
        }

        private int _MaDS;
        public int MaDS
        {
            get { return this._MaDS; }
            set { this._MaDS = value; }
        }

        private int _MaGac;
        public int MaGac
        {
            get { return this._MaGac; }
            set { this._MaGac = value; }
        }
    }
}

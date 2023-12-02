using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ChiTietDanhSachCongViec
    {
        public ChiTietDanhSachCongViec(int MaCTDSCV, int MaDS, int MaQN, int MaCongviec)
        {
            this.MaCTDSCV = MaCTDSCV;
            this.MaDS = MaDS;
            this.MaQN = MaQN;
            this.MaCongviec= MaCongviec;
        }
        public ChiTietDanhSachCongViec(DataRow row)
        {
            this.MaCTDSCV = (int)row["MaCTDSCV"];
            this.MaDS = (int)row["MaDS"];
            this.MaQN = (int)row["MaQN"];
            this.MaCongviec = (int)row["MaCongviec"];
        }
        private int _MaCTDSCV;
        public int MaCTDSCV
        {
            get { return this._MaCTDSCV; }
            set { this._MaCTDSCV = value;}
        }

        private int _MaDS;
        public int MaDS
        {
            get { return this._MaDS; }
            set { this._MaDS = value; }
        }
        private int _MaQN;
        public int MaQN
        {
            get { return this._MaQN; }
            set { this._MaQN = value; }
        }
        private int _MaCongviec;
        public int MaCongviec
        {
            get { return this._MaCongviec; }
            set { this._MaCongviec = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class TrangThaiCongViec
    {
        public TrangThaiCongViec(int MaTT, string TrangThai)
        {
            this.MaTT = MaTT;
            this.TrangThai = TrangThai;
        }
        public TrangThaiCongViec(DataRow row)
        {
            this.MaTT = (int)row["MaTT"];
            this.TrangThai = row["TrangThai"].ToString();
        }
        private int _MaTT;

        public int MaTT
        {
            get { return _MaTT; }
            set { _MaTT = value; }
        }

        private string _TrangThai;
        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}

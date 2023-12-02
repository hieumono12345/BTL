using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class ThoiGian
    {
        public ThoiGian(int MaTG, DateTime ThoiGianBatDau, DateTime ThoiGianKetThuc)
        {
            this.MaTG = MaTG;
            this.ThoiGianBatDau = ThoiGianBatDau;
            this.ThoiGianKetThuc = ThoiGianKetThuc;
        }
        public ThoiGian(DataRow row)
        {
            this.MaTG = (int)row["MaTG"];
            this.ThoiGianBatDau = (DateTime)row["ThoiGianBatDau"];
            this.ThoiGianKetThuc = (DateTime)row["ThoiGianKetThuc"];
        }

        private int _MaTG;
        public int MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }

        private DateTime _ThoiGianBatDau;
        public DateTime ThoiGianBatDau
        {
            get { return _ThoiGianBatDau; }
            set { _ThoiGianBatDau = value; }
        }

        private DateTime _ThoiGianKetThuc;
        public DateTime ThoiGianKetThuc
        {
            get { return _ThoiGianKetThuc; }
            set { _ThoiGianKetThuc = value; }
        }
    }
}

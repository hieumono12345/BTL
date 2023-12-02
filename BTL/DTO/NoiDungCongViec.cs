using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class NoiDungCongViec
    {
        public NoiDungCongViec(int MaCongViec, string NoiDung, string Diadiem, DateTime ThoiGian)
        {
            this.MaCongViec = MaCongViec;
            this.NoiDung = NoiDung;
            this.Diadiem = Diadiem;
            this.ThoiGian = ThoiGian;
        }
        public NoiDungCongViec(DataRow row)
        {
            this.MaCongViec = (int)row["MaCongViec"];
            this.NoiDung = row["NoiDung"].ToString();
            this.Diadiem = row["Diadiem"].ToString();
            this.ThoiGian = (DateTime)row["ThoiGian"];
        }

        private int _MaCongViec;
        public int MaCongViec
        {
            get { return _MaCongViec; }
            set { _MaCongViec = value; }
        }

        private string _NoiDung;
        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        private string _Diadiem;
        public string Diadiem
        {
            get { return _Diadiem; }
            set { _Diadiem = value; }
        }

        private DateTime _ThoiGian;
        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
    }
}

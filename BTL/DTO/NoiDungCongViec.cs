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
        public NoiDungCongViec(string Ngay,int MaCongViec,string NoiDung, string Diadiem, string TGDuKien,int SoLuong, int STTDS, int STTCV, string GhiChu,string TGBD,string TGKT,string DacDiem,int MaDV)
        {
            this.MaCongViec = MaCongViec;
            this.NoiDung = NoiDung;
            this.Diadiem = Diadiem;
            this.TGDuKien = TGDuKien;
            this.SoLuong = SoLuong;
            this.STTDS = STTDS;
            this.STTCV = STTCV;
            this.GhiChu = GhiChu;
            this.TGBD = TGBD;
            this.TGKT = TGKT;
            this.DacDiem = DacDiem;
            this.MaDV = MaDV;
            this.Ngay = Ngay;
        }
        public NoiDungCongViec(DataRow row)
        {
            this.MaCongViec = (int)row["MaCongViec"];
            this.NoiDung = row["NoiDung"].ToString();
            this.Diadiem = row["Diadiem"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            //this.STTDS = (int)row["STTDS"];
            this.STTCV = (int)row["MaTT"];
            this.GhiChu = row["GhiChu"].ToString();
            this.TGBD = row["TGBD"].ToString();
            this.TGKT = row["TGKT"].ToString();
            //this.DacDiem = row["DacTaTC"].ToString();
            this.MaDV = (int)row["MaDV"];
            this.Ngay = row["Ngay"].ToString();
        }

        private int _MaCongViec;
        public int MaCongViec
        {
            get { return _MaCongViec; }
            set { _MaCongViec = value; }
        }
        private string _Ngay;
        public string Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
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

        private string _TGDuKien;
        public string TGDuKien
        {
            get { return _TGDuKien; }
            set { _TGDuKien = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private int _STTDS;
        public int STTDS
        {
            get { return _STTDS; }
            set { _STTDS = value; }
        }

        private int _STTCV;
        public int STTCV
        {
            get { return _STTCV; }
            set { _STTCV = value; }
        }

        private string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        private string _TGBD;
        public string TGBD
        {
            get { return _TGBD; }
            set { _TGBD = value; }
        }

        private string _TGKT;
        public string TGKT
        {
            get { return _TGKT; }
            set { _TGKT = value; }
        }

        private string _DacDiem;
        public string DacDiem
        {
            get { return _DacDiem; }
            set { _DacDiem = value; }
        }

        private int _MaDV;
        public int MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
    }
}

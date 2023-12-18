using BTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class LoadCombox
    {
        private static LoadCombox instance;

        public static LoadCombox Instance
        {
            get { if (instance == null) instance = new LoadCombox(); return instance; }
            private set { instance = value; }
        }

        private LoadCombox() { }

        //thay bằng store đầu vào là MaTg và MaGac
        public List<QN> getListQNGac()
        {
            List<QN> list = new List<QN>();

            string query = "select MaQN,TenQN from QuanNhan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QN a = new QN(item);
                list.Add(a);
            }

            return list ;
        }

        public List<Quyen> getListQuyen()
        {
            List<Quyen> list = new List<Quyen>();

            string query = "select * from Quyen";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Quyen a = new Quyen(item);
                list.Add(a);
            }

            return list;
        }
        public List<QN> getDSQNByDV_CV(int MaCV, int MaDV)
        {
            if (MaCV == null) MaCV = 0;
            if (MaDV == null) MaDV = 0;
            List<QN> list = new List<QN>();

            string query = "select MaQN,TenQN from QuanNhan where MaDV=" + MaDV + "and MaChucVu=" + MaCV;


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QN a = new QN(item);
                list.Add(a);
            }

            return list;
        }
        public List<QN> getDSQNByDV( int MaDV,int id)
        {
            
            if (MaDV == null) MaDV = 0;
            List<QN> list = new List<QN>();

            string query = "SELECT MaQN,TenQN FROM dbo.QuanNhan WHERE MaDV="+MaDV+" AND MaChucVu= 3 AND MaNganh="+id;


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QN a = new QN(item);
                list.Add(a);
            }

            return list;
        }

        public List<DonVi> getListDonVi()
        {
            List<DonVi> list = new List<DonVi>();

            string query = "select * from DonVi";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DonVi DV = new DonVi(item);
                list.Add(DV);
            }

            return list;
        }

        public List<Nganh> getListNganh()
        {
            List<Nganh> list = new List<Nganh>();

            string query = "select * from Nganh";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Nganh DV = new Nganh(item);
                list.Add(DV);
            }

            return list;
        }

        public List<ChucVu> getListChucVu()
        {
            List<ChucVu> list = new List<ChucVu>();

            string query = "select * from ChucVu";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChucVu ChucVu = new ChucVu(item);
                list.Add(ChucVu);
            }

            return list;
        }

        public List<ThoiGianGac> getListThoiGianGac()
        {
            List<ThoiGianGac> list = new List<ThoiGianGac>();

            string query = "SELECT * from ThoiGianGac";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThoiGianGac a = new ThoiGianGac(item);
                list.Add(a);
            }

            return list;
        }
        public List<TinhChatCongViec> getListTCCV()
        {
            List<TinhChatCongViec> list = new List<TinhChatCongViec>();

            string query = "SELECT * from TinhChatCongViec";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TinhChatCongViec a = new TinhChatCongViec(item);
                list.Add(a);
            }

            return list;
        }
         
    }
}

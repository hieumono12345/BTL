using BTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.DAO
{
    public class QuanLyPhanCongCV
    {
        private static QuanLyPhanCongCV instance;

        public static QuanLyPhanCongCV Instance
        {
            get { if (instance == null) instance = new QuanLyPhanCongCV(); return instance; }
            private set { instance = value; }
        }      

        public DataTable LayToanBoCVChuaHoanThanh()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER (ORDER BY MaCongViec) AS 'STT',a.MaCongViec,b.TenDV,a.TGDuKien,a.Ngay,a.STTDS, a.NoiDung from NoiDungCongViec a, DonVi b where a.MaDV=b.MaDV");
            return data;
        }

        public DataTable LayToanBoCVChuaThucHienTieuDoan()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec usp_danhsachcongviectieudoan");
            return data;
        }
        public bool themCongViec(string Ngay, string noidung, string TGBD, string TGKT, int maDV,int soLuong,string DiaDiem, string nhacNho)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.usp_ThemDanhSachCongViec @noidung , @diadiem , @ngay , @soluong , @GhiChu , @TGBD , @TGKT , @MaDV ", new object[] { noidung , DiaDiem , Ngay , soLuong , nhacNho , TGBD , TGKT , maDV });
            
            return result > 0;
        }

        public bool suaCongViec(int maCV,string Ngay, string noidung, string TGBD, string TGKT, int maDV, int soLuong, string DiaDiem, string nhacNho)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("[usp_SuaDanhSachCongViec] @macv , @noidung  , @diadiem  , @ngay  , @soluong  , @GhiChu  , @TGBD  , @TGKT  , @MaDV   ", new object[] { maCV, noidung , DiaDiem , Ngay , soLuong , nhacNho , TGBD , TGKT , maDV });

            return result > 0;
        }
        public bool xoaCongViec(int id)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("usp_XoaDanhSachCongViec @macv ", new object[] { id });

            return result > 0;
        }

        public DTO.CV GetCV(int id)
        {
            List<CV> list = new List<CV>();

            string query = "select TGBD,TGKT,TenDV from NoiDungCongViec a , DonVi b where a.MaDV=b.MaDV and MaCongViec=" + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CV a = new CV(item);
                list.Add(a);
            }

            return list[0];
        }
    }
}

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
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT ROW_NUMBER() OVER (ORDER BY MaCongViec) AS 'STT',a.MaCongViec,b.TenDV,a.TGDuKien,a.Ngay,a.STTDS from NoiDungCongViec a, DonVi b where a.MaDV=b.MaDV");

            return data;
        }
        public bool themCongViec(string Ngay, string NoidungCV, string TGThucHien, int maDV,int soLuong,string DiaDiem, string nhacNho)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.usp_ThemPhanCongCV @NoidungCV , @ngaythuchien , @TGThucHien , @DiaDiem , @soluong , @nhacnho , @MaDV ", new object[] { NoidungCV, Ngay, TGThucHien, DiaDiem, soLuong, nhacNho , maDV });
            
            return result > 0;
        }
    }
}

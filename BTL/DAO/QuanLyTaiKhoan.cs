using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class QuanLyTaiKhoan
    {
        private static QuanLyTaiKhoan instance;

        public static QuanLyTaiKhoan Instance
        {
            get { if (instance == null) instance = new QuanLyTaiKhoan(); return instance; }
            private set { instance = value; }
        }

        private QuanLyTaiKhoan() { }

        public bool themTaiKhoan(string TenTK, string MK, int MaQN, int MaQuyen)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("exec usp_themtaikhoan @TenTK , @Matkhau , @MaQN , @Maquyen ", new object[] { TenTK, MK, MaQN, MaQuyen });
            //int result = DataProvider.Instance.ExecuteNonQuery("exec USP_ThemLichGac @ngay='" + Ngay + "', @hoi='" + hoi"', @dap='" + dap + "', @MaDV='" + maDV + "', @NhacNho='" + nhacNho + "'");

            return result > 0;
        }
    }
}

using BTL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DAO
{
    public class Login
    {
        private static Login instance;

        public static Login Instance
        {
            get { if (instance == null) instance = new Login(); return instance; }
            private set { instance = value; }
        }

        private Login() { }

        public TTNguoiDung getTTNgoiDung(string TenTK, string MK)
        {
            List<TTNguoiDung> list = new List<TTNguoiDung>();

            string query = "exec usp_Dangnhap @TenTk , @Matkhau ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTK, MK });

            foreach (DataRow item in data.Rows)
            {
                TTNguoiDung a = new TTNguoiDung(item);
                list.Add(a);
            }

            return list[0];
        }

        public bool XacThuc(string TenTK, string MK )
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec usp_Dangnhap @TenTk = '"+TenTK+"' , @Matkhau = '" +MK +"'");            
            return result > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class soLuongConLai
    {
        public soLuongConLai(int sl )
        {
            this.soLuong  = sl; 
        }
        public soLuongConLai(DataRow row)
        {
            this._soLuong = (int)row["soluong"];
        }

        private int _soLuong;
        public int soLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class TK_Quyen
    {
        public TK_Quyen(int MaTK, int MaQuyen)
        {
            this.MaTK = MaTK;
            this.MaQuyen = MaQuyen;
        }
        public TK_Quyen(DataRow row)
        {
            this.MaTK = (int)row["MaTK"];
            this.MaQuyen = (int)row["MaQuyen"];
        }
        private int _MaTK;

        public int MaTK
        {
            get { return _MaTK; }
            set { _MaTK = value; }
        }

        private int _MaQuyen;
        public int MaQuyen
        {
            get { return _MaQuyen; }
            set { _MaQuyen = value; }
        }
    }
}

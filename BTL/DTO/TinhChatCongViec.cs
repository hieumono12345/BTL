using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class TinhChatCongViec
    {
        public TinhChatCongViec(int MaTC, string DacTaTC)
        {
            this.MaTC = MaTC;
            this.DacTaTC = DacTaTC;
        }
        public TinhChatCongViec(DataRow row)
        {
            this.MaTC = (int)row["MaTC"];
            this.DacTaTC = row["DacTaTC"].ToString();
        }
        private int _MaTC;

        public int MaTC
        {
            get { return _MaTC; }
            set { _MaTC = value; }
        }

        private string _DacTaTC;
        public string DacTaTC
        {
            get { return _DacTaTC; }
            set { _DacTaTC = value; }
        }
    }
}

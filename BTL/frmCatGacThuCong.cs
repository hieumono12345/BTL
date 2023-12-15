using BTL.DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmCatGacThuCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCatGacThuCong()
        {
            InitializeComponent();
            LoadCBBTGGac();
        }

        void LoadCBBTGGac()
        {
            cbTgGac.DataSource= LoadCombox.Instance.getListQNGac();
            cbTgGac.DisplayMember = "TenQN";
            cbTgGac.ValueMember = "MaQN";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbTgGac.SelectedValue.ToString(), "sss");
        }
    }
}
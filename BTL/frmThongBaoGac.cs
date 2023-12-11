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
    public partial class frmThongBaoGac : DevExpress.XtraEditors.XtraForm
    {
        public frmThongBaoGac()
        {
            InitializeComponent();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frmCatGac frmCatGac = new frmCatGac();
            frmCatGac.ShowDialog();
        }
    }
}
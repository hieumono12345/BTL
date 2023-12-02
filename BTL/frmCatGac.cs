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
    public partial class frmCatGac : DevExpress.XtraEditors.XtraForm
    {
        public frmCatGac()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            panelControl1.Visible = true;
        }

        private void frmCatGac_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panelControl7.Visible = !panelControl7.Visible;
        }
    }
}
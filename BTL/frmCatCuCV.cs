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
    public partial class frmCatCuCV : DevExpress.XtraEditors.XtraForm
    {
        public frmCatCuCV()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //panelControl4.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            //panelControl4.Visible = true;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //panelControl4.Visible = false;
        }
    }
}
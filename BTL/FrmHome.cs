using DevExpress.XtraEditors;
using GUI;
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
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm
    {
        public FrmHome()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
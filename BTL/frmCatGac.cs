using BTL.DAO;
using BTL.DTO;
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
        private int maGac;

        public int MaGac
        {
            get { return maGac; }
            set { maGac = value; }
        }
        public frmCatGac(int MaGac)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            panelControl1.Visible = true;
            this.maGac = MaGac;
        }

        private void frmCatGac_Load(object sender, EventArgs e)
        {
            //cắt gác tự động vào đâyy
            //DataTable dt = CatGacDAO.Instance.getDSGacByMaGac(maGac);
            //gcDanhSachGac.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panelControl7.Visible = !panelControl7.Visible;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmCatGacThuCong f = new frmCatGacThuCong();
            f.ShowDialog();
            this.Hide();
        }
    }
}
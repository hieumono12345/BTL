using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //btnQLHocVien.Enabled = false;
            OpenformDacQuyen(typeof(frmThongBaoGac));
        }
        void OpenForm(Type typeForm)
        {
            foreach( Form frm in MdiChildren )
            {
                if(frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form) Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        void OpenformDacQuyen(Type typeForm)
        {
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

        }

        private void btnInFoUser_ItemClick(object sender, ItemClickEventArgs e)
        {            
            OpenForm(typeof(frmInFoUser));
        }

        private void btnQLHocVien_ItemClick(object sender, ItemClickEventArgs e)
        {           
            OpenForm(typeof(frmDanhSachHocVien));
        }

        private void btnListLoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmListLoi));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
             //OpenForm(typeof(Login));
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(FrmHome));
        }

        private void btnCatGac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmCatGac));
        }

        private void btnPhanCongCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPhanCongCV));
        }

        private void btnPhanCongGac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmPhanCongGac));
        }

        private void btnThongBaoGac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongBaoGac));
        }

        private void btnThongBaoCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmThongBaoCV));
        }

        private void btnCatCuCV_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmCatCuCV));
        }
    }
}
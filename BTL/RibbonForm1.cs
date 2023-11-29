using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
    }
}
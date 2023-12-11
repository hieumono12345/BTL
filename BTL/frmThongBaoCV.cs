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
    public partial class frmThongBaoCV : DevExpress.XtraEditors.XtraForm
    {
        public frmThongBaoCV()
        {
            InitializeComponent();
        }
        void Load()
        {
            gcDanhSachCV.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnDetail.Click += btnDetail_Click;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            ChiTietQuanNhan dt = QuanLyQnDAO.Instance.getChiTietQN((int)gvDanhSachCV.GetFocusedRowCellValue("MaQN"));

            /*txtMaHV.Text = dt.MaQN.ToString();
            txtTenHV.Text = dt.TenQN;
            txtChucVu.Text = dt.TenCV;
            cbGioiTinh.Text = dt.GioiTinh == 1 ? "Nam" : "Nữ";*/

            //MessageBox.Show(dt.GioiTinh.ToString() + "ngày gác", "sss");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmCatCuCV frmCatCuCV = new frmCatCuCV();
            frmCatCuCV.ShowDialog();
        }
    }
}
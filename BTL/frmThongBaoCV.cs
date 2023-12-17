using BTL.DAO;
using BTL.DTO;
using DevExpress.Utils.About;
using DevExpress.Utils.Extensions;
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
        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }

        }
        public frmThongBaoCV(TTNguoiDung inFor)
        {
            this.inForUser = inFor;
            InitializeComponent();
            Load();
        }
        void Load()
        {
           // gcDanhSachCV.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnDetail.Click += btnDetail_Click;
            
            //string t = time.Text;
            //string h= date.EditValue.ToString();
            //MessageBox.Show();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            QuanNhan dt = QuanLyQnDAO.Instance.getChiTietQN((int)gvDanhSachCV.GetFocusedRowCellValue("MaQN"));

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
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
using BTL.DAO;
using BTL.DTO;

namespace BTL
{
    public partial class frmDanhSachHocVien : DevExpress.XtraEditors.XtraForm
    {
        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }
        }
        public frmDanhSachHocVien(TTNguoiDung inFor)
        {
            InitializeComponent();
            this.inForUser = inFor;
            Load();
        }
        void Load()
        {
            //pncBtnXuLy.Visible = false;
            //txtMaHV.Enabled = false;
            //txtTenHV.Enabled = false;
            //txtChucVu.Enabled = false;
            //txtQuanHam.Enabled = false;
            gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnDetail.Click += btnDetail_Click;
            loadCBX();
        }
        
        private void frmDanhSachQN_Load(object sender, EventArgs e)
        {
            //gcDanhSachQN là cái to ở trêb
            gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
        }
        void loadCBX()//xem load giá trị combox ở đây
        {

            /*cbNganh.DataSource = LoadCombox.Instance.getListNganh();
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";*/
        }
        private void cbNganh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cbQN.DataSource = LoadCombox.Instance.getDSQNByDV(inForUser.MaDV, (int)cbNganh.SelectedValue);

            cbQN.DisplayMember = "TenQN";
            cbQN.ValueMember = "MaQN";
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {            
            QuanNhan dt = QuanLyQnDAO.Instance.getChiTietQN((int)gvDanhSachQN.GetFocusedRowCellValue("MaQN"));
             
           /* txtMaHV.Text = dt.MaQN.ToString();
            txtTenHV.Text = dt.TenQN;
            txtChucVu.Text = dt.TenCV;
            cbGioiTinh.Text = dt.GioiTinh == 1 ? "Nam" : "Nữ";*/
            
            //MessageBox.Show(dt.GioiTinh.ToString() + "ngày gác", "sss");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //pncBtnXuLy.Visible = true;
            //txtMaHV.Enabled = true;
            //txtTenHV.Enabled = true;
            //txtChucVu.Enabled = true;
            //txtQuanHam.Enabled = true;
            //txtQuanHam.Text = "";
            //txtMaHV.Text = "";
            //txtTenHV.Text = "";
            //txtChucVu.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa Học viên","");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)//xem lấy giá trị combobox ở đây
        {
            
            Load();
        }
    }
}
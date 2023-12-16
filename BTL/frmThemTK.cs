using BTL.DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class frmThemTK : DevExpress.XtraEditors.XtraForm
    {
        public frmThemTK()
        {
            InitializeComponent();
            LoadCBB();
            loadData();
            cbThem.Checked = false;
            cbSua.Checked = false;
        }

        void enableTatCa()
        {
            cbDV.Enabled = true;
            cbChucVu.Enabled = true;
            cbQN.Enabled = true;
            txtTenTK.Enabled = true;
            txtMK.Enabled = true;
            ceDaiDoi.Enabled = true;
            ceTieuDoan.Enabled = true;
            ceAdmin.Enabled = true;
            cbQuyen.Enabled = true; 
        }

        void disbleTatCa()
        {
            cbDV.Enabled = false;
            cbChucVu.Enabled = false;
            cbQN.Enabled = false;
            txtTenTK.Enabled = false;
            txtMK.Enabled = false;
            ceDaiDoi.Enabled = false;
            ceTieuDoan.Enabled = false;
            ceAdmin.Enabled = false;
            cbQuyen.Enabled = false;
        }

        void xoaTatCa()
        {
            cbDV.Text = "";
            cbChucVu.Text = "";
            cbQN.Text = "";
            txtTenTK.Text = "";
            txtMK.Text = "";
            ceDaiDoi.Text = "";
            cbQuyen.Text = "";
            
        }

        void LoadCBB()
        {
            cbDV.DataSource = LoadCombox.Instance.getListDonVi();
            cbDV.ValueMember = "MaDV";
            cbDV.DisplayMember = "TenDV";
            cbDV.SelectedIndex = 2;

            cbChucVu.DataSource = LoadCombox.Instance.getListChucVu();
            cbChucVu.ValueMember = "MaCV";
            cbChucVu.DisplayMember = "TenCV";
            cbChucVu.SelectedIndex = 3;

            cbQN.DataSource = LoadCombox.Instance.getDSQNByDV_CV((int)cbChucVu.SelectedValue, (int)cbDV.SelectedValue);
            cbQN.ValueMember = "MaQN";
            cbQN.DisplayMember = "TenQN";

            cbQuyen.DataSource=LoadCombox.Instance.getListQuyen();
            cbQuyen.ValueMember = "MaQuyen";
            cbQuyen.DisplayMember = "TenQuyen";

        }

        private void c(object sender, EventArgs e)
        {
            cbQN.DataSource = LoadCombox.Instance.getDSQNByDV_CV((int)cbChucVu.SelectedValue, (int)cbDV.SelectedValue);
            cbQN.ValueMember = "MaQN";
            cbQN.DisplayMember = "TenQN";
        }

        private void d(object sender, EventArgs e)
        {
            cbQN.DataSource = LoadCombox.Instance.getDSQNByDV_CV((int)cbChucVu.SelectedValue, (int)cbDV.SelectedValue);
            cbQN.ValueMember = "MaQN";
            cbQN.DisplayMember = "TenQN";
        }

        void loadData()
        {
            btnDetail.Click += BtnDetail_Click;
            //viết store lấy tài khoản
            //gcDanhSachTK.DataSource = QuanLyPhanCongCV.Instance.LayToanBoCVChuaHoanThanh();
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            cbSua.Checked = false;
            cbThem.Checked = false;
            disbleTatCa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThem.Checked = true;
            cbSua.Checked = false;
            enableTatCa();
            xoaTatCa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTatCa();
            cbSua.Checked = true;
            cbThem.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            //xóa tại đây
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbQN.SelectedValue.)
            //viết store thêm tk ở đây
        }
    }
}
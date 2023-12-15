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
    /*
     * thêm dữ liệu vào dgv 
     * store Thêm
     * store sửa
     * store xóa
     * store lấy lên 1 cv
     */
{
    public partial class frmPhanCongCV : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanCongCV()
        {
            InitializeComponent();
            btnDetail.Click += BtnDetail_Click;
            loadCbDV();
            disenableTatCa();

        }
        private void frmDanhSachQN_Load(object sender, EventArgs e)
        {
            //gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnDetail.Click += BtnDetail_Click;
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            cbSua.Checked = false;
            cbThem.Checked = false;
            disenableTatCa();
        }

        void enableTatCa()
        {
            Ngay.Enabled = true;
            txtGhiChu.Enabled = true;
            txtMaCV.Enabled = true;
            nbSoL.Enabled = true;
            cbDV.Enabled = true;
            ThoiGian.Enabled = true;
            txtDiaDiem.Enabled = true;
        }
        void disenableTatCa()
        {
            Ngay.Enabled = false;
            txtGhiChu.Enabled = false;
            nbSoL.Enabled = false;
            cbDV.Enabled = false;
            ThoiGian.Enabled = false;
            txtDiaDiem.Enabled = false;

        }
        void XoaTatCa()
        {
            Ngay.Text = "";
            nbSoL.Text = "";
            txtGhiChu.Text = "";
            ThoiGian.Text = "";
            txtDiaDiem.Text = "";
            cbDV.Text = "";
            txtMaCV.Text = "";
        }
        void loadCbDV()
        {
            cbDV.DataSource = DAO.QuanLyDonVi.Instance.getListDonVi();
            cbDV.DisplayMember = "TenDV";
            cbDV.ValueMember = "MaDV";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbSua.Checked == true)
            {
                MessageBox.Show(Ngay.Text+nbSoL.Value.ToString()+txtGhiChu.Text+txtDiaDiem.Text+"-"+ThoiGian.Text+cbDV.SelectedValue.ToString(), "sửa");
            }
            if (cbThem.Checked == true)
            {
                MessageBox.Show(Ngay.Text + nbSoL.ToString() + txtGhiChu.Text + txtDiaDiem.Text + ThoiGian.Text + cbDV.SelectedValue.ToString(), "Thêm");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTatCa();
            cbSua.Checked = true;
            cbThem.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xóa"+txtMaCV.ToString(), "sửa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThem.Checked = true;
            cbSua.Checked=false;
            enableTatCa();
            XoaTatCa();
        }
    }
}
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
    public partial class frmLichSuGac3 : DevExpress.XtraEditors.XtraForm
    {
        private int maDonVi;

        public int MaDonVi
        {
            get { return maDonVi; }
            set { maDonVi = value; }
        }
        public frmLichSuGac3(int maDonVi)
        {
            this.maDonVi = maDonVi;
            InitializeComponent();
            btnDetail.Click += BtnDetail_Click;
            Load();
        }
        #region Các hàm dùng chung
        void Load()
        {
            cbSua.Checked = false;
            cbThem.Checked = false;
            loadDataLichGacTrongThang();
            loadCbDV();
            disenableTatCa();
        }
        void loadDataLichGacTrongThang()
        {
            if (maDonVi == 0)
            {
                gcDanhSachGac.DataSource = PhanCongGac.Instance.getDSDaPhanCongTrongThang();
            }
            else
            {
                gcDanhSachGac.DataSource = ThongBaoGac.Instance.LayLichGac(maDonVi);
            }
        }
        private void frmDanhSachQN_Load(object sender, EventArgs e)
        {
            //gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnDetail.Click += BtnDetail_Click;
        }

        void enableTatCa()
        {
            dateTimePicker1.Enabled = true;
            txtNhacNho.Enabled = true;
            txtHoi.Enabled = true;
            txtMaGac.Enabled = true;
            txtDap.Enabled = true;
            cbDV.Enabled = true;
        }
        void disenableTatCa()
        {
            dateTimePicker1.Enabled = false;
            txtNhacNho.Enabled = false;
            txtHoi.Enabled = false;
            txtDap.Enabled = false;
            txtMaGac.Enabled = false;
            cbDV.Enabled = false;

        }
        void XoaTatCa()
        {
            dateTimePicker1.Text = "";
            txtMaGac.Text = "";
            txtNhacNho.Text = "";
            txtHoi.Text = "";
            txtDap.Text = "";
            cbDV.Text = "";
        }

        //Gán giá trị vào CB ở đâyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy
        void loadCbDV()
        {
            cbDV.DataSource = DAO.QuanLyDonVi.Instance.getListDonVi();
            cbDV.DisplayMember = "TenDV";
            cbDV.ValueMember = "MaDV";
        }
        #endregion

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gvDanhSachGac.GetFocusedRowCellValue("MaGac").ToString(), "sss");
            NoiDungGac ndg = PhanCongGac.Instance.getNoiDungGac((int)gvDanhSachGac.GetFocusedRowCellValue("MaGac"));

            txtHoi.Text = ndg.Hoi;
            txtDap.Text = ndg.Dap;
            txtMaGac.Text = ndg.MaGac.ToString();
            txtNhacNho.Text = ndg.NhacNho;
            dateTimePicker1.Text = ndg.Ngay.ToString();
            //cbDV.Text = ndg.TenDV.ToString();
            disenableTatCa();
            cbThem.Checked = false;
            cbSua.Checked = false;
        }
        bool CheckInput()
        {
            if (txtHoi.Text == "" || txtDap.Text == "" || cbDV.Text == "")
            {
                return false;
            }
            else { return true; }
        }


        //btnSua
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbThem.Checked = false;
            cbSua.Checked = true;
            enableTatCa();
            dateTimePicker1.Enabled = false;


        }
        //btnThem
        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThem.Checked = true;
            cbSua.Checked = false;
            enableTatCa();
            XoaTatCa();

        }

        private void btnThemLichGac_Click(object sender, EventArgs e)
        {

            if (cbThem.Checked == true)
            {
                if (CheckInput() == false)
                {
                    MessageBox.Show("Đề nghị thêm đầy đủ vào các mục có đánh dấu *");
                }
                else
                {
                    bool a = PhanCongGac.Instance.themLichGac(dateTimePicker1.Text.ToString(), txtHoi.Text, txtDap.Text, (int)cbDV.SelectedValue, txtNhacNho.Text);
                    if (a)
                    {
                        loadDataLichGacTrongThang();
                    }
                    else
                    {
                        MessageBox.Show("Ngày gác được phân công!!", "Thông báo");
                    }
                }

            }
            if (cbSua.Checked == true)
            {
                //viết store sửa tại đây
                MessageBox.Show("Sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
            if (r == DialogResult.OK)
            {
                int id;
                if (int.TryParse(txtMaGac.Text, out id))
                {
                    int a = DataProvider.Instance.ExecuteNonQuery("usp_xoalichgac @magac=" + id);
                    if (a > 0)
                    {
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                //viết store xóa ở đây

            }
        }

        private void btnThemLichGac_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txtMaGac.Text);
            int id;
            if (int.TryParse(txtMaGac.Text, out id))
            {
                frmChiTiet2 a = new frmChiTiet2(id,true);
                a.ShowDialog();
                this.Hide();

                this.Show();
            }
        }
    }
}
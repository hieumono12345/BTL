using BTL.DAO;
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
using DevExpress.Printing.DataAwareExport.Export.Utils;

namespace BTL
{
    public partial class frmPhanCongGac : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanCongGac()
        {
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
            gcDanhSachGac.DataSource = PhanCongGac.Instance.getDSDaPhanCongTrongThang();
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
            txtMaGac.Text= ndg.MaGac.ToString();
            txtNhacNho.Text = ndg.NhacNho;
            dateTimePicker1.Text = ndg.Ngay.ToString();
            cbDV.Text = ndg.TenDV.ToString();
            disenableTatCa();  
            cbThem.Checked = false;
            cbSua.Checked = false;
        }
        

        //btnSua
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbThem.Checked = false;
            cbSua.Checked = true;
            enableTatCa();
            
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
            //MessageBox.Show(  dateTimePicker1.Value.ToString("yyyy-MM-yy") +"--------"+dateTimePicker1.Text+ "----", "sss");
             bool a = PhanCongGac.Instance.themLichGac(dateTimePicker1.Text.ToString(), txtHoi.Text, txtDap.Text, (int)cbDV.SelectedValue, txtNhacNho.Text);
             if (a)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                loadDataLichGacTrongThang();
            }
            else
            {
                MessageBox.Show("Xem ngày gác đã được phân công!!", "Thông báo");
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xóa mã gác = "+ txtMaGac.Text, "Thông báo");
        }
    }
}
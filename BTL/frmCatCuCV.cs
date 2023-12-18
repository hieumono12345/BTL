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
    public partial class frmCatCuCV : DevExpress.XtraEditors.XtraForm
    {
        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }

        }
        void LoandDS()
        {
            gcDanhSachCV.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.usp_HienThiDanhSachLamViec @MaCongViec="+CatCongViec.macv+"");
        }
        public frmCatCuCV(TTNguoiDung inFor)
        {
            this.inForUser = inFor;
            InitializeComponent();
            LoandDS();
        }
        public frmCatCuCV()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //panelControl4.Visible = false;
        }

        void LoadComBoBox()
        {
            cbx_tinhchat.DataSource = DAO.LoadCombox.Instance.getListTCCV();
            cbx_tinhchat.DisplayMember = "DacTaTC";
            cbx_tinhchat.ValueMember = "MaTC";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            //panelControl4.Visible = true;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //panelControl4.Visible = false;
        }

        private void frmCatCuCV_Load(object sender, EventArgs e)
        {
            LoadComBoBox();
            txt_noidung.Text = CatCongViec.noidung.ToString();
            txt_ghichu.Text = CatCongViec.ghichu.ToString();
        }

        private void btn_cattudong_Click(object sender, EventArgs e)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC dbo.usp_CatCongViecTuDong @MaCV = " + CatCongViec.macv + ",@Noidung = N'" + CatCongViec.noidung + "',@DiaDiem = N'" + CatCongViec.diadiem + "',@Ngay = '" + CatCongViec.ngay + "',@soluong = " + CatCongViec.soluong + ",@ThoiGianBatDauCongViec2 = '" + CatCongViec.thoigianbatdau + "',@MaTC = " + cbx_tinhchat.SelectedValue + ",@MaDV = " + inForUser.MaDV + "");
            gcDanhSachCV.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xac cat quan so");
            this.Close();
        }
    }
}
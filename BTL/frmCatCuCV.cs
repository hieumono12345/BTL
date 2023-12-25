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
        private bool sTTDS;

        public bool STTDS
        {
            get { return sTTDS; }
            set { sTTDS = value; }
        }

        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }

        }

        void LoandDS()
        {
            MessageBox.Show(CatCongViec.macv.ToString());
            gcDanhSachCV.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.usp_HienThiDanhSachLamViec @MaCongViec= " + CatCongViec.macv+"");
        }
        public frmCatCuCV(TTNguoiDung inFor,bool a)
        {
            this.inForUser = inFor;
            this.sTTDS = a;
           
            InitializeComponent();
            LoandDS();
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
            ctrlThayThe.Visible = sTTDS;
        }

        private void btn_cattudong_Click(object sender, EventArgs e)
        {
            string gchu;
            if (txt_ghichu.Text == "")
            {
                 gchu = "null";
            }
            else
            {
                gchu=txt_ghichu.Text;
            }
            string Sql = "[usp_CatCongViecTuDong] @MaCV = "+ CatCongViec.macv+",@Ghichu = "+gchu +", @MaTC= "+ cbx_tinhchat.SelectedValue+ ", @madv = "+ inForUser.MaDV;
            MessageBox.Show(Sql);
            DataTable dt = DataProvider.Instance.ExecuteQuery(Sql);
            gcDanhSachCV.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xac cat quan so");
            this.Close();
        }
    }
}
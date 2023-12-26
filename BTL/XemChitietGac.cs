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
    public partial class XemChitietGac : DevExpress.XtraEditors.XtraForm
    {
        private int maGac;

        public int MaGac
        {

            get { return maGac; }
            set { maGac = value; }
        }

        private bool sTTDS;

        public bool STTDS
        {
            get { return sTTDS; }
            set { sTTDS = value; }
        }
        public XemChitietGac(int MaGac)
        {
            this.maGac = MaGac;
            this.sTTDS = true;
            InitializeComponent();
            load();
            WindowState = FormWindowState.Maximized;
        }
        void reSet()
        {
            maMoi1.Text = "null";
            maMoi2.Text = "null";
            maMoi3.Text = "null";
            maMoi4.Text = "null";
            maMoi5.Text = "null";
        }
        void loadCBB1(int tg)
        {
            List<QN> dt = LoadCombox.Instance.getQNThayThe(maGac, tg);
            cbHV1.DataSource = dt;
            cbHV1.DisplayMember = "TenQN";
            cbHV1.ValueMember = "MaQN";

        }
        void loadCBB2(int tg)
        {
            List<QN> dt = LoadCombox.Instance.getQNThayThe(maGac, tg);
            cbHV2.DataSource = dt;
            cbHV2.DisplayMember = "TenQN";
            cbHV2.ValueMember = "MaQN";

        }
        void loadCBB3(int tg)
        {
            List<QN> dt = LoadCombox.Instance.getQNThayThe(maGac, tg);
            cbHV3.DataSource = dt;
            cbHV3.DisplayMember = "TenQN";
            cbHV3.ValueMember = "MaQN";

        }
        void loadCBB4(int tg)
        {
            List<QN> dt = LoadCombox.Instance.getQNThayThe(maGac, tg);
            cbHV4.DataSource = dt;
            cbHV4.DisplayMember = "TenQN";
            cbHV4.ValueMember = "MaQN";
        }
        void loadCBB5(int tg)
        {
            List<QN> dt = LoadCombox.Instance.getQNThayThe(maGac, tg);
            cbHV5.DataSource = dt;
            cbHV5.DisplayMember = "TenQN";
            cbHV5.ValueMember = "MaQN";
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            reSet();
            txtMaTG.Text = gvDSGac.GetFocusedRowCellValue("MaTG").ToString();
            int tg = (int)gvDSGac.GetFocusedRowCellValue("MaTG");
            loadCBB1(tg);
            loadCBB2(tg);
            loadCBB3(tg);
            loadCBB4(tg);
            loadCBB1(tg);
            loadCBB5(tg);
            if (tg <= 3)
            {
                reSet();
                controlDocGac.Visible = false;
                cbHV1.Text = gvDSGac.GetFocusedRowCellValue("HV1").ToString();
                cbHV2.Text = gvDSGac.GetFocusedRowCellValue("HV2").ToString();
                cbHV3.Text = gvDSGac.GetFocusedRowCellValue("HV3").ToString();
                cbHV4.Text = gvDSGac.GetFocusedRowCellValue("HV4").ToString();
                MaHV1.Text = gvDSGac.GetFocusedRowCellValue("Ma1").ToString();
                MaHV2.Text = gvDSGac.GetFocusedRowCellValue("Ma2").ToString();
                MaHV3.Text = gvDSGac.GetFocusedRowCellValue("Ma3").ToString();
                MaHV4.Text = gvDSGac.GetFocusedRowCellValue("Ma4").ToString();

            }
            else
            {
                reSet();
                controlDocGac.Visible = true;
                cbHV1.Text = gvDSGac.GetFocusedRowCellValue("HV1").ToString();
                cbHV2.Text = gvDSGac.GetFocusedRowCellValue("HV2").ToString();
                cbHV3.Text = gvDSGac.GetFocusedRowCellValue("HV3").ToString();
                cbHV4.Text = gvDSGac.GetFocusedRowCellValue("HV4").ToString();
                cbHV5.Text = gvDSGac.GetFocusedRowCellValue("DocGac").ToString();
                MaHV1.Text = gvDSGac.GetFocusedRowCellValue("Ma1").ToString();
                MaHV2.Text = gvDSGac.GetFocusedRowCellValue("Ma2").ToString();
                MaHV3.Text = gvDSGac.GetFocusedRowCellValue("Ma3").ToString();
                MaHV4.Text = gvDSGac.GetFocusedRowCellValue("Ma4").ToString();
                MaHV5.Text = gvDSGac.GetFocusedRowCellValue("Ma5").ToString();
            }
        }

        void load()
        {
            if (sTTDS == true)
            {
                gcDSGac.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.usp_HienTHiGac @magac=" + maGac);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmCatGacThuCong f = new frmCatGacThuCong();
            f.ShowDialog();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt = CatGacDAO.Instance.getDSGacByMaGac(maGac);
            gcDSGac.DataSource = dt;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
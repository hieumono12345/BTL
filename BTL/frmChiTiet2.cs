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
    public partial class frmChiTiet2 : DevExpress.XtraEditors.XtraForm
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
        public frmChiTiet2(int MaGac, bool sttds)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; 
            this.maGac = MaGac;
            this.sTTDS = sttds;
            btnDetail.Click += BtnDetail_Click;
            load();
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



        private void cbHV1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            maMoi1.Text = cbHV1.SelectedValue.ToString();
        }

        private void cbHV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMoi2.Text = cbHV2.SelectedValue.ToString();
        }

        private void cbHV3_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMoi3.Text = cbHV3.SelectedValue.ToString();
        }

        private void cbHV4_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMoi4.Text = cbHV4.SelectedValue.ToString();
        }

        private void cbHV5_SelectedIndexChanged(object sender, EventArgs e)
        {
            maMoi5.Text = cbHV5.SelectedValue.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maHV1Cu, maHV2Cu, maHV3Cu, maHV4Cu, maHV5Cu, maTG;
            //int maMoi11 = (int)cbHV1.SelectedValue, maMoi12 = (int)cbHV2.SelectedValue, maMoi13 = (int)cbHV3.SelectedValue, maMoi14 = (int)cbHV4.SelectedValue, maMoi15 = (int)cbHV5.SelectedValue;
            int maMoi11, maMoi12, maMoi13, maMoi14, maMoi15;
            MessageBox.Show("usp_capnhatqngac @maqncu1 =" + MaHV1.Text + ",@maqncu2=" + MaHV2.Text + ",@maqncu3=" + MaHV3.Text + ",@maqncu4=" + MaHV4.Text + ",@maqncu5=" + MaHV5.Text + ",@maqnmoi1=" + maMoi1.Text + ",@maqnmoi2=" + maMoi2.Text + ",@maqnmoi3=" + maMoi3.Text + ",@maqnmoi4=" + maMoi4.Text + ",@maqnmoi5=" + maMoi5.Text + ",@magac=" + maGac + ",@matg=  " + txtMaTG.Text);
            int a = DataProvider.Instance.ExecuteNonQuery("usp_capnhatqngac @maqncu1 =" + MaHV1.Text + ",@maqncu2=" + MaHV2.Text + ",@maqncu3=" + MaHV3.Text + ",@maqncu4=" + MaHV4.Text + ",@maqncu5=" + MaHV5.Text + ",@maqnmoi1=" + maMoi1.Text + ",@maqnmoi2=" + maMoi2.Text + ",@maqnmoi3=" + maMoi3.Text + ",@maqnmoi4=" + maMoi4.Text + ",@maqnmoi5=" + maMoi5.Text + ",@magac=" + maGac + ",@matg=  " + txtMaTG.Text);
            if (a > 0)
            {
                load();
            }
            else
            {
                MessageBox.Show("sưaar thất bại");
            }
            /*if (int.TryParse(txtMaTG.Text, out maTG) && int.TryParse(MaHV1.Text, out maHV1Cu) && int.TryParse(MaHV2.Text, out maHV2Cu) && int.TryParse(MaHV3.Text, out maHV3Cu) && int.TryParse(MaHV4.Text, out maHV4Cu) && int.TryParse(MaHV5.Text, out maHV5Cu)
                && int.TryParse(maMoi1.Text, out maMoi11) && int.TryParse(maMoi2.Text, out maMoi12) && int.TryParse(maMoi3.Text, out maMoi13) && int.TryParse(maMoi4.Text, out maMoi14) && int.TryParse(maMoi5.Text, out maMoi15))
            {
                *//*int a = DataProvider.Instance.ExecuteNonQuery("usp_capnhatqngac @maqncu1 , @maqncu2 , @maqncu3 , @maqncu4 , @maqncu5 , @maqnmoi1 , @maqnmoi2  , @maqnmoi3  , @maqnmoi4  , @maqnmoi5  , @magac  , @matg  ", new object[] { maHV1Cu, maHV2Cu, maHV3Cu, maHV4Cu, maHV5Cu, maMoi1, maMoi2, maMoi3, maMoi4, maMoi5, maTG });
                if (a > 0) { load(); }*//*
                MessageBox.Show("m1"+maMoi11+" m2"+maMoi12+" m3"+maMoi13+" m4"+maMoi14+" m5"+maMoi15+" c1"+maHV1Cu+" c2"+maHV2Cu+ " c3"+maHV3Cu+ " c4"+maHV4Cu+" c5"+maHV5Cu,maTG.ToString());
            }
            else
            {
            }*/
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
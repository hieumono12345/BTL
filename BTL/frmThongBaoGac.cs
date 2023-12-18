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
    public partial class frmThongBaoGac : DevExpress.XtraEditors.XtraForm
    {
        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }
            
        }
        public frmThongBaoGac(TTNguoiDung inFor)
        {
            this.inForUser = inFor;
            InitializeComponent();
            LoadData();
            btnDetail.Click += BtnDetail_Click;
            ce.Checked = false;


        }
        void LoadData()
        {            
            gcLichGac.DataSource = ThongBaoGac.Instance.LayLichGac(InForUser.MaDV);
        }
        
        void disenableTatCa()
        {
            cbNgayGac.Enabled = false; 
            txtNhacNho.Enabled = false;
            txtDap.Enabled = false;
            txtHoi.Enabled = false;
            
        }
        private void BtnDetail_Click(object sender, EventArgs e)
        {

            txtNhacNho.Text = gvLichGac.GetFocusedRowCellValue("NhacNho").ToString();
            txtDap.Text = gvLichGac.GetFocusedRowCellValue("Dap").ToString();
            txtHoi.Text = gvLichGac.GetFocusedRowCellValue("Hoi").ToString();
            cbNgayGac.Text = gvLichGac.GetFocusedRowCellValue("Ngay").ToString();
            txtMaGac.Text = gvLichGac.GetFocusedRowCellValue("MaGac").ToString();
            cSTTDS.EditValue = gvLichGac.GetFocusedRowCellValue("STTDS");
            ce.Checked = true;
            disenableTatCa();            
        }
        //btn Cắt gác
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtMaGac.Text+ cSTTDS.EditValue.ToString());

            string a = txtMaGac.Text;
            if (ce.Checked == true)
            {

                int b = int.Parse(a);
                frmCatGac frmCatGac = new frmCatGac(b);
                frmCatGac.ShowDialog();
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtMaGac.Text, out int b))
            {
                if (ce.Checked == true)
                {
                    frmCatGac frmCatGac = new frmCatGac(b);
                    frmCatGac.ShowDialog();
                }
            }


        }
    }
}
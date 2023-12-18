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
    public partial class frmDanhSachUuTien : DevExpress.XtraEditors.XtraForm
    {
        private TTNguoiDung inForUser;

        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }
        }
        public frmDanhSachUuTien(TTNguoiDung inFor)
        {
            this.inForUser = inFor;
            InitializeComponent();
            Load();
            cbThem.Checked = false;
            cbSua.Checked = false;
            disbleTatCa();
        }
        void enableTatCa()
        {
            txtNoiDungUuTien.Enabled = true;
            cbNganh.Enabled = true;
            cbQN.Enabled= true;

        }
        void disbleTatCa()
        {
            txtNoiDungUuTien.Enabled = false;
            cbNganh.Enabled = false;
            cbQN.Enabled = false;
        }
        void xoaTatCa()
        {
            txtNoiDungUuTien.Text = "";
            cbNganh.Text = "";
            cbQN.Text = "";
        }

        void Load()
        {
            gcDanhSachTK.DataSource = DataProvider.Instance.ExecuteQuery("usp_HienThiDanhSachUuTien");
            btnDetail.Click += btnDetail_Click;
            loadCBX();
        }
        void loadCBX()//xem load giá trị combox ở đây
        {
            
            cbNganh.DataSource= LoadCombox.Instance.getListNganh( );
            cbNganh.DisplayMember = "TenNganh";
            cbNganh.ValueMember = "MaNganh";
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            cbSua.Checked = false;
            cbThem.Checked = false;
           txtMaUT.Text= gvDanhSachTK.GetFocusedRowCellValue("MaUT").ToString();
            disbleTatCa();
        }

        private void cbNganh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbQN.DataSource = LoadCombox.Instance.getDSQNByDV(inForUser.MaDV,(int)cbNganh.SelectedValue);

            cbQN.DisplayMember = "TenQN";
            cbQN.ValueMember = "MaQN";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTatCa();
            cbSua.Checked = true;
            cbThem.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThem.Checked = true;
            cbSua.Checked = false;
            enableTatCa();
            xoaTatCa();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vào");
            if (cbSua.Checked == true && cbThem.Checked == false)
            {
                cbSua.Checked = false;
                cbThem.Checked = false;
                MessageBox.Show("vào sửa");
                //sửa
                /*int a = DataProvider.Instance.ExecuteNonQuery("usp_Themuutien @MaQN="+ cbQN.SelectedValue + ",@noidunguutien= '"+txtNoiDungUuTien.Text+"'");
                if (a >0)
                {
                    MessageBox.Show("Sửa thành công", "ssss");
                Load();
                

                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "ssss");
                }*/
            }
            if (cbSua.Checked == false && cbThem.Checked == true)
            {
                cbSua.Checked = false;
                cbThem.Checked = false;
                //thêm
                if (int.TryParse(txtMaUT.Text, out int mauutien))
                {
                    MessageBox.Show("vào theem");
                    /*int a = DataProvider.Instance.ExecuteNonQuery("CREATE PROC usp_SuaUutien @MaUuTien=" + mauutien + ",@MaQN=" + cbQN.SelectedValue + ", @noidunguutien= '" + txtNoiDungUuTien.Text + "'");
                    if (a > 0)
                    {
                        MessageBox.Show("Thêm thành công", "ssss");
                        Load();
                    
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "ssss");
                    }*/
                }


            }
        }
    }
}
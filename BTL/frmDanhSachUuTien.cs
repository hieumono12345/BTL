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
            cbSua.Checked = false;
            cbThem.Checked = false;
            gcDSUuTien.DataSource = DataProvider.Instance.ExecuteQuery("usp_HienThiDanhSachUuTien @madv = "+(int)inForUser.MaDV);
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
            
            QN_UuTien a = QuanLyPhanCongCV.Instance.GetQNUuTien((int)gvDSUuTien.GetFocusedRowCellValue("MaUuTien"));
            txtMaUT.Text = a.MaUT.ToString();
            cbQN.Text = gvDSUuTien.GetFocusedRowCellValue("TenQN").ToString();
            txtMaQN.Text = a.MaQN.ToString();
            txtNoiDungUuTien.Text = a.NoiDungUuTien.ToString();            

            disbleTatCa();
            cbNganh.Text = "";
            cbThem.Checked = false;
            cbSua.Checked = false;
        }

        bool CheckInput()
        {
            if (txtNoiDungUuTien.Text == "")
            {
                return false;
            }
            else { return true; }
        }

        private void cbNganh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbQN.DataSource = LoadCombox.Instance.getDSQNByDV(inForUser.MaDV,(int)cbNganh.SelectedValue);

            cbQN.DisplayMember = "TenQN";
            cbQN.ValueMember = "MaQN";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cbThem.Checked = false;
            cbSua.Checked = true;
            enableTatCa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
            if (r == DialogResult.OK)
            {
                int id;
                if (int.TryParse(txtMaUT.Text, out id))
                {
                    //viết store xóa ở đây
                    //MessageBox.Show("Xóa thất bại"+id.ToString());

                    int a = DataProvider.Instance.ExecuteNonQuery("usp_XoaUuTien @maut=" + id);
                    if (a > 0)
                    {
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }


            }
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

            if (cbThem.Checked == true)
            {
                
                if (CheckInput() == false)
                {
                    MessageBox.Show("Đề nghị thêm đầy đủ vào các mục có đánh dấu *");
                }
                else
                {
                    //viết store thêm ở đây
                    int a = DataProvider.Instance.ExecuteNonQuery("usp_Themuutien @MaQN=" + cbQN.SelectedValue + ",@noidunguutien= '" + txtNoiDungUuTien.Text + "'");
                    if (a > 0)
                    {
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "ssss");
                    }
                }

            }
            if (cbSua.Checked == true)
            {
                //viết store sửa tại đây
                int id,id2;
                if (int.TryParse(txtMaUT.Text, out id))
                {
                    if (int.TryParse(txtMaQN.Text, out id2))
                    {
                        int a = DataProvider.Instance.ExecuteNonQuery("usp_SuaUutien @MaUuTien=" + id + ",@MaQN=" + id2 + ", @noidunguutien= '" + txtNoiDungUuTien.Text + "'");
                        if (a > 0)
                        {
                            Load();

                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "ssss");
                        }
                    }
                    
                }
                
            }
            
        }
    }
}
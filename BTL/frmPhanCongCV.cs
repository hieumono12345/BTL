using BTL.DAO;
using BTL.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
        //cbDV.DataSource = DAO.QuanLyDonVi.Instance.getListDonVi();
        public frmPhanCongCV()
        {
            InitializeComponent();
            btnDetail.Click += BtnDetail_Click;
            loadDS();
            loadCbDV();
            disenableTatCa();
            ctAn.Visible = true;

        }
        private void frmDanhSachQN_Load(object sender, EventArgs e)
        {
            
            loadDS();
            btnDetail.Click += BtnDetail_Click;
        }
        void loadDS()
        {
            gcDanhSachCV.DataSource = QuanLyPhanCongCV.Instance.LayToanBoCVChuaThucHienTieuDoan();
        }
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            DTO.CV a = QuanLyPhanCongCV.Instance.GetCV((int)gvDanhSachCV.GetFocusedRowCellValue("MaCongViec"));
            cbSua.Checked = false;
            cbThem.Checked = false;
            disenableTatCa();
            Ngay.Text = gvDanhSachCV.GetFocusedRowCellValue("Ngay").ToString();
            nbSoL.Text = gvDanhSachCV.GetFocusedRowCellValue("SoLuong").ToString();
            txtGhiChu.Text = gvDanhSachCV.GetFocusedRowCellValue("GhiChu").ToString();
            string str1 = a.TGBD.ToString();
            txtTGBD.Text = str1.Substring(0, 5);
            string str = a.TGKT.ToString();
            txtTGKT.Text = str.Substring(0, 5);
            txtDiaDiem.Text = gvDanhSachCV.GetFocusedRowCellValue("DiaDiem").ToString();
            txtNoiDung.Text= gvDanhSachCV.GetFocusedRowCellValue("NoiDung").ToString();
            cbDV.Text = a.TenDonVi;
            txtMaCV.Text = gvDanhSachCV.GetFocusedRowCellValue("MaCongViec").ToString();
            ctAn.Visible = true;
        }

        void enableTatCa()
        {
            txtNoiDung.Enabled = true;
            Ngay.Enabled = true;
            txtGhiChu.Enabled = true;
            txtMaCV.Enabled = true;
            nbSoL.Enabled = true;
            cbDV.Enabled = true;
            TGBD.Enabled = true;
            TGKT.Enabled = true;
            txtDiaDiem.Enabled = true;
        }
        void disenableTatCa()
        {
            txtNoiDung.Enabled = false;
            Ngay.Enabled = false;
            txtGhiChu.Enabled = false;
            nbSoL.Enabled = false;
            cbDV.Enabled = false;
            TGBD.Enabled = false;
            TGKT.Enabled = false;
            txtDiaDiem.Enabled = false;

        }
        void XoaTatCa()
        {
            Ngay.Text = "";
            nbSoL.Text = "";
            txtGhiChu.Text = "";
            TGBD.Text = "";
            TGKT.Text = "";
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
            TimeSpan time1 = TGBD.Time.TimeOfDay;
            TimeSpan time2 = TGKT.Time.TimeOfDay;



            // So sánh hai giá trị thời gian
            if (time1 > time2)
            {
                MessageBox.Show("Thời gian bắt đầu phải lớn hơn thời gian kết thúc", "sửa");
            }
            else if (time1 < time2)
            {
                if (cbSua.Checked == true)
                {
                    bool a = QuanLyPhanCongCV.Instance.suaCongViec((int)gvDanhSachCV.GetFocusedRowCellValue("MaCongViec"), Ngay.Text, txtNoiDung.Text, TGBD.Text, TGKT.Text, (Int32)cbDV.SelectedValue, (int)nbSoL.Value, txtDiaDiem.Text, txtGhiChu.Text);
                    if (a == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        loadDS();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                if (cbThem.Checked == true)
                {
                    bool a = QuanLyPhanCongCV.Instance.themCongViec(Ngay.Text, txtNoiDung.Text, TGBD.Text, TGKT.Text, (Int32)cbDV.SelectedValue, (int)nbSoL.Value, txtDiaDiem.Text, txtGhiChu.Text);
                    if (a == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadDS();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }

                    //(string Ngay, string noidung, string TGBD, string TGKT, int maDV,int soLuong,string DiaDiem, string nhacNho)
                    //MessageBox.Show(Ngay.Text + nbSoL.ToString() + txtGhiChu.Text + txtDiaDiem.Text + ThoiGian.Text + cbDV.SelectedValue.ToString(), "Thêm");
                }
            }
            else
            {
                MessageBox.Show("Thời gian bắt đầu phải lớn hơn thời gian kết thúc", "sửa");
            }
            /*DTO.CV a = QuanLyPhanCongCV.Instance.GetCV((int)gvDanhSachCV.GetFocusedRowCellValue("MaCongViec"));
            string str1 = a.TGBD.ToString();
            TGBD.Text = str1.Substring(0, 5);
            MessageBox.Show(str1.Substring(0, 5), "Thất bại");*/

            //MessageBox.Show(TGBD.EditValue.ToString()  + TGKT.EditValue.ToString(), "sửa");


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableTatCa();
            cbSua.Checked = true;
            cbThem.Checked = false;
            ctAn.Visible = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool a = QuanLyPhanCongCV.Instance.xoaCongViec((int)gvDanhSachCV.GetFocusedRowCellValue("MaCongViec"));
            if (a == true)
            {
                MessageBox.Show("Xóa thành công");
                loadDS();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThem.Checked = true;
            cbSua.Checked=false;
            ctAn.Visible = false;
            enableTatCa();
            XoaTatCa();

        }
    }
}
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
            NoiDungCongViec NDCV = QuanLyPhanCongCV.Instance.GetNoiDungCV((int)gvDanhSachCV.GetFocusedRowCellValue("MaCongViec"));
            //cbSua.Checked = false;
            //cbThem.Checked = false;
            disenableTatCa();
            
            Ngay.Text = NDCV.Ngay;
            nbSoL.Text = NDCV.SoLuong.ToString();
            txtGhiChu.Text = NDCV.GhiChu.ToString();
            string str1 = NDCV.TGBD.ToString();
            txtTGBD.Text = str1.Substring(0, 5);
            string str = NDCV.TGKT.ToString();
            if (str != "")
            {
                txtTGKT.Text = str.Substring(0, 5);            
            }
            txtDiaDiem.Text = NDCV.Diadiem.ToString();
            txtNoiDung.Text = NDCV.NoiDung.ToString();            
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
            txtMaCV.Text = "";
            txtNoiDung.Text = "";
        }

        bool checkInPut()
        {
            if (nbSoL.Text != ""|| TGBD.Text != ""|| txtDiaDiem.Text != ""|| txtNoiDung.Text != "")
            {
                return false;
            }
            else
            {
                return true;
            }
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

            if (checkInPut())
            {
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
                            loadDS();
                        }
                        else
                        {
                            MessageBox.Show("Thất bại");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc", "sửa");
                }
            }
            else
            {
                MessageBox.Show("Đề nghị thêm vào tất cả các mục có đánh dấu *", "sửa");
            }

            // So sánh hai giá trị thời gian
            
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

        

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(ceTGKT.Checked == true) 
            {
                TGKT.Enabled = false;

            }
            else
            {
                TGKT.Enabled = true;
               
            }
        }
    }
}
using BTL.DAO;
using BTL.DTO;
using BTL.Report;
using DevExpress.Utils.About;
using DevExpress.Utils.Extensions;
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
    public partial class frmThongBaoCV : DevExpress.XtraEditors.XtraForm
    {
        private TTNguoiDung inForUser;
        
        public TTNguoiDung InForUser
        {
            get { return inForUser; }
            set { inForUser = value; }

        }
        public frmThongBaoCV(TTNguoiDung inFor)
        {
            this.inForUser = inFor;
            InitializeComponent();
            btnDetail.Click += btnDetail_Click;
            // bdsdbsbdjsd
            Load();
        }
        void Load()
        {
           // gcDanhSachCV.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();            
            DataTable dt = DataProvider.Instance.ExecuteQuery("EXEC dbo.usp_hienthidanhsachcongviecdaidoi @madv="+inForUser.MaDV+"");
            gcDanhSachCV.DataSource = dt;
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            
            //QuanNhan dt = QuanLyQnDAO.Instance.getChiTietQN((int)gvDanhSachCV.GetFocusedRowCellValue("MaQN"));
            DateTime cellValue = (DateTime)gvDanhSachCV.GetFocusedRowCellValue("Ngay");
            txt_Ngay.Text = cellValue.Date.ToString("yyyy/MM/dd");
            txt_TGBD.Text= gvDanhSachCV.GetFocusedRowCellValue("TGBD").ToString();
            txt_DiaDiem.Text= gvDanhSachCV.GetFocusedRowCellValue("DiaDiem").ToString();
            txt_soluong.Text = gvDanhSachCV.GetFocusedRowCellValue("SoLuong").ToString();
            txt_GhiChu.Text= gvDanhSachCV.GetFocusedRowCellValue("GhiChu").ToString();
            txtMaCV.Text= gvDanhSachCV.GetFocusedRowCellValue("MaCongViec").ToString();
            cSTTDS.EditValue = gvDanhSachCV.GetFocusedRowCellValue("STTDS");
            controlBDTH.Visible = cSTTDS.Checked;
            //MessageBox.Show("detail" + cSTTDS.Checked);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int maCongViec;

            object cellValue = gvDanhSachCV.GetFocusedRowCellValue("MaCongViec");
            if (cellValue != null && cellValue != DBNull.Value && int.TryParse(cellValue.ToString(), out maCongViec))
            {
                CatCongViec.macv = maCongViec;
            }
            CatCongViec.ghichu= gvDanhSachCV.GetFocusedRowCellValue("GhiChu").ToString();
            CatCongViec.noidung = gvDanhSachCV.GetFocusedRowCellValue("NoiDung").ToString();
            CatCongViec.diadiem = gvDanhSachCV.GetFocusedRowCellValue("DiaDiem").ToString();
            CatCongViec.thoigianbatdau= gvDanhSachCV.GetFocusedRowCellValue("TGBD").ToString();
            CatCongViec.ngay=txt_Ngay.Text;
            if (int.TryParse(txt_soluong.Text, out int soLuong))
            {
                CatCongViec.soluong = soLuong;
            }


            frmCatCuCV frmCatCuCV = new frmCatCuCV(InForUser,cSTTDS.Checked);
            this.Hide();
            frmCatCuCV.ShowDialog();
            Load();
            this.Show();
        }

        private void btn_tienhanhcongviec_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("tien hành"+txtMaCV.Text);
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.usp_tienhanhcongviec @macv = "+txtMaCV.Text+ "");
            if (result >= 0)
            {
               // MessageBox.Show("Bắt Đầu Thực Hiện Công Viêc!");
                Load();
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.usp_hoanthanhcongviec @macv = " +txtMaCV.Text+ "");
            if (result >= 0)
            {
                //MessageBox.Show("Đã Hoàn Thành Công Việc!!!");
                Load();
            }
        }
    }
}
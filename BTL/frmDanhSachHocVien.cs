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
using BTL.DAO;

namespace BTL
{
    public partial class frmDanhSachHocVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachHocVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnXoa.Click += BtnXoa_Click;
        }
        private void frmDanhSachQN_Load(object sender, EventArgs e)
        {
            //gcDanhSachQN là cái to ở trêb
            gcDanhSachQN.DataSource = QuanLyQnDAO.Instance.getDanhSachQN();
            btnXoa.Click += BtnXoa_Click;
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string a= ngayGac.DateTime.ToString();
            //lấy dữ liệu ở cái gvDanhSachQN là cái gvnhowr ở dưới
            MessageBox.Show(gvDanhSachQN.GetFocusedRowCellValue("MaQN").ToString()+"ngày gác"+a,"sss");
        }
    }
}
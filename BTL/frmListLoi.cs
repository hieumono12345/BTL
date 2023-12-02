using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmListLoi : DevExpress.XtraEditors.XtraForm
    {

        public frmListLoi()
        {
            InitializeComponent();
            LoadDSLoi();
        }
        void LoadDSLoi()
        {
            gcDanhSach.DataSource = QuanLyViPham.Instance.GetListViPham();
            
        }
    }
}
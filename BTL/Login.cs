using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BTL;
using BTL.DAO;
using BTL.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        //BUS_Login bus = new BUS_Login();
        bool isUserCorrect = true;
        bool isPassCorrect = true;

        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text.Trim();
            string pass = SHA1_HASH.Instance.Hash(tbPassword.Text.Trim());
            TTNguoiDung inFor = BTL.DAO.Login.Instance.getTTNgoiDung(user, pass);
            if (inFor!=null)
            {
                //TTNguoiDung inFor = BTL.DAO.Login.Instance.getTTNgoiDung(user, pass);
                frmMain frmMain = new frmMain(inFor);

                this.Hide();
                frmMain.ShowDialog();
                this.Show();

            }
            else
            {
                
                
                    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu sai"+pass+ BTL.DAO.Login.Instance.XacThuc(user, pass).ToString());
                
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                tbPassword.Properties.PasswordChar = '\0';
            }
            else
                tbPassword.Properties.PasswordChar = '*';
        }

        private void tbUser_Paint(object sender, PaintEventArgs e)
        {
            if (!isUserCorrect)
            {
                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.Red,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
        }

        private void tbPassword_Paint(object sender, PaintEventArgs e)
        {
            if (!isPassCorrect)
            {
                RectangleF rec = e.Graphics.ClipBounds;
                rec.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.Red,
                    rec.Left,
                    rec.Top,
                    rec.Width,
                    rec.Height);
            }
        }

        private void tbUser_EditValueChanged(object sender, EventArgs e)
        {
            isUserCorrect = true;
            tbUser.Refresh();
        }

        private void tbPassword_EditValueChanged(object sender, EventArgs e)
        {
            isPassCorrect = true;
            tbPassword.Refresh();
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            //tbUser.Text = tbUser.Text.ToUpper();
        }

        private void checkKhachHang_Click(object sender, EventArgs e)
        {
            //new Form1("G00", "").Show();
            this.Hide();
        }
    }
}
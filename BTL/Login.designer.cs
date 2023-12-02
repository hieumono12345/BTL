namespace GUI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkKhachHang = new DevExpress.XtraEditors.CheckEdit();
            this.chbShowPass = new DevExpress.XtraEditors.CheckEdit();
            this.tbPassword = new DevExpress.XtraEditors.TextEdit();
            this.tbUser = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbShowPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseBackColor = true;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(292, 161);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(94, 29);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(202, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(202, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BTL.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::BTL.Properties.Resources.LOGO;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 167);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // checkKhachHang
            // 
            this.checkKhachHang.Location = new System.Drawing.Point(324, 135);
            this.checkKhachHang.Name = "checkKhachHang";
            this.checkKhachHang.Properties.Caption = "Khách hàng";
            this.checkKhachHang.Size = new System.Drawing.Size(116, 20);
            this.checkKhachHang.TabIndex = 2;
            this.checkKhachHang.Click += new System.EventHandler(this.checkKhachHang_Click);
            // 
            // chbShowPass
            // 
            this.chbShowPass.Location = new System.Drawing.Point(202, 135);
            this.chbShowPass.Name = "chbShowPass";
            this.chbShowPass.Properties.Caption = " Hiện mật khẩu";
            this.chbShowPass.Size = new System.Drawing.Size(116, 20);
            this.chbShowPass.TabIndex = 2;
            this.chbShowPass.CheckedChanged += new System.EventHandler(this.chbShowPass_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.EditValue = "";
            this.tbPassword.Location = new System.Drawing.Point(202, 100);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Properties.Appearance.Options.UseFont = true;
            this.tbPassword.Properties.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(283, 34);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.EditValueChanged += new System.EventHandler(this.tbPassword_EditValueChanged);
            this.tbPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.tbPassword_Paint);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUser
            // 
            this.tbUser.EditValue = "";
            this.tbUser.Location = new System.Drawing.Point(202, 47);
            this.tbUser.Name = "tbUser";
            this.tbUser.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Properties.Appearance.Options.UseFont = true;
            this.tbUser.Properties.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(283, 34);
            this.tbUser.TabIndex = 0;
            this.tbUser.EditValueChanged += new System.EventHandler(this.tbUser_EditValueChanged);
            this.tbUser.Paint += new System.Windows.Forms.PaintEventHandler(this.tbUser_Paint);
            this.tbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUser_KeyDown);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 221);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkKhachHang);
            this.Controls.Add(this.chbShowPass);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Login.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbShowPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit tbUser;
        private DevExpress.XtraEditors.TextEdit tbPassword;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.CheckEdit chbShowPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkKhachHang;
    }
}
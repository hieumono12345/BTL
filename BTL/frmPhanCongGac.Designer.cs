namespace BTL
{
    partial class frmPhanCongGac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCongGac));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachGac = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachGac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DaiDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayGac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Hoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.gcDanhSachGac);
            this.panelControl1.Location = new System.Drawing.Point(3, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1199, 796);
            this.panelControl1.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(328, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(504, 26);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "DANH SÁCH CÔNG VIỆC CHƯA HOÀN THÀNH";
            // 
            // gcDanhSachGac
            // 
            this.gcDanhSachGac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcDanhSachGac.Location = new System.Drawing.Point(5, 83);
            this.gcDanhSachGac.MainView = this.gvDanhSachGac;
            this.gcDanhSachGac.Name = "gcDanhSachGac";
            this.gcDanhSachGac.Size = new System.Drawing.Size(1194, 645);
            this.gcDanhSachGac.TabIndex = 4;
            this.gcDanhSachGac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachGac});
            // 
            // gvDanhSachGac
            // 
            this.gvDanhSachGac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stt,
            this.DaiDoi,
            this.DonViThucHien,
            this.NgayGac,
            this.Hoi,
            this.Dap});
            this.gvDanhSachGac.GridControl = this.gcDanhSachGac;
            this.gvDanhSachGac.Name = "gvDanhSachGac";
            this.gvDanhSachGac.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.True;
            // 
            // stt
            // 
            this.stt.Caption = "STT";
            this.stt.FieldName = "stt";
            this.stt.MinWidth = 25;
            this.stt.Name = "stt";
            this.stt.Visible = true;
            this.stt.VisibleIndex = 0;
            // 
            // DaiDoi
            // 
            this.DaiDoi.Caption = "Đại đội đảm nhiệm";
            this.DaiDoi.MinWidth = 25;
            this.DaiDoi.Name = "DaiDoi";
            this.DaiDoi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.DaiDoi.Visible = true;
            this.DaiDoi.VisibleIndex = 1;
            this.DaiDoi.Width = 94;
            // 
            // DonViThucHien
            // 
            this.DonViThucHien.Caption = "Đơn vị thực hiện";
            this.DonViThucHien.MinWidth = 25;
            this.DonViThucHien.Name = "DonViThucHien";
            this.DonViThucHien.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.DonViThucHien.Visible = true;
            this.DonViThucHien.VisibleIndex = 2;
            this.DonViThucHien.Width = 94;
            // 
            // NgayGac
            // 
            this.NgayGac.Caption = "Ngày gác";
            this.NgayGac.MinWidth = 25;
            this.NgayGac.Name = "NgayGac";
            this.NgayGac.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.NgayGac.Visible = true;
            this.NgayGac.VisibleIndex = 3;
            this.NgayGac.Width = 94;
            // 
            // Hoi
            // 
            this.Hoi.Caption = "Hỏi";
            this.Hoi.MinWidth = 25;
            this.Hoi.Name = "Hoi";
            this.Hoi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.Hoi.Visible = true;
            this.Hoi.VisibleIndex = 4;
            this.Hoi.Width = 94;
            // 
            // Dap
            // 
            this.Dap.Caption = "Đáp";
            this.Dap.MinWidth = 25;
            this.Dap.Name = "Dap";
            this.Dap.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.Dap.Visible = true;
            this.Dap.VisibleIndex = 5;
            this.Dap.Width = 94;
            // 
            // panelControl7
            // 
            this.panelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl7.Controls.Add(this.simpleButton3);
            this.panelControl7.Controls.Add(this.panelControl11);
            this.panelControl7.Controls.Add(this.panelControl8);
            this.panelControl7.Controls.Add(this.panelControl10);
            this.panelControl7.Controls.Add(this.panelControl9);
            this.panelControl7.Controls.Add(this.labelControl13);
            this.panelControl7.Location = new System.Drawing.Point(1208, 12);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(643, 796);
            this.panelControl7.TabIndex = 11;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(261, 743);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(186, 38);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "Xác nhận";
            // 
            // panelControl11
            // 
            this.panelControl11.Controls.Add(this.comboBox1);
            this.panelControl11.Controls.Add(this.labelControl9);
            this.panelControl11.Location = new System.Drawing.Point(91, 611);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(531, 83);
            this.panelControl11.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(45, 28);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(109, 26);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Đơn vị gác";
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.labelControl8);
            this.panelControl8.Controls.Add(this.richTextBox1);
            this.panelControl8.Location = new System.Drawing.Point(91, 425);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(531, 171);
            this.panelControl8.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(45, 44);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(111, 26);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Nhắc nhở: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(211, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.labelControl11);
            this.panelControl10.Controls.Add(this.comboBox9);
            this.panelControl10.Location = new System.Drawing.Point(91, 83);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(531, 115);
            this.panelControl10.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(45, 45);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(108, 26);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Ngày gác: ";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(211, 45);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(269, 24);
            this.comboBox9.TabIndex = 16;
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.textBox17);
            this.panelControl9.Controls.Add(this.labelControl12);
            this.panelControl9.Controls.Add(this.labelControl14);
            this.panelControl9.Controls.Add(this.textBox15);
            this.panelControl9.Controls.Add(this.labelControl15);
            this.panelControl9.Location = new System.Drawing.Point(91, 209);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(531, 200);
            this.panelControl9.TabIndex = 9;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(211, 81);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(269, 23);
            this.textBox17.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(45, 13);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(147, 26);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "Mật khẩu gác: ";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(133, 76);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(47, 26);
            this.labelControl14.TabIndex = 19;
            this.labelControl14.Text = "Hỏi: ";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(211, 146);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(269, 23);
            this.textBox15.TabIndex = 22;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(133, 141);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(54, 26);
            this.labelControl15.TabIndex = 20;
            this.labelControl15.Text = "Đáp: ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(245, 24);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(183, 26);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "THÔNG TIN GÁC";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(990, 743);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 38);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Lưu";
            // 
            // frmPhanCongGac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 820);
            this.Controls.Add(this.panelControl7);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPhanCongGac";
            this.Text = "Phân công gác";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.panelControl9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSachGac;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachGac;
        private DevExpress.XtraGrid.Columns.GridColumn stt;
        private DevExpress.XtraGrid.Columns.GridColumn DaiDoi;
        private DevExpress.XtraGrid.Columns.GridColumn DonViThucHien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayGac;
        private DevExpress.XtraGrid.Columns.GridColumn Hoi;
        private DevExpress.XtraGrid.Columns.GridColumn Dap;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.ComboBox comboBox9;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private System.Windows.Forms.TextBox textBox17;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.TextBox textBox15;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
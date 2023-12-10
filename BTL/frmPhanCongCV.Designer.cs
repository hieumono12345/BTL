namespace BTL
{
    partial class frmPhanCongCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCongCV));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachGac = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachGac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl12 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.timeEdit2 = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).BeginInit();
            this.panelControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            this.panelControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gcDanhSachGac.Size = new System.Drawing.Size(1178, 645);
            this.gcDanhSachGac.TabIndex = 4;
            this.gcDanhSachGac.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachGac});
            // 
            // gvDanhSachGac
            // 
            this.gvDanhSachGac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.stt,
            this.gridColumn1,
            this.DonViThucHien,
            this.ThoiGian,
            this.Ngay,
            this.TrangThai});
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên công việc";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
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
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời gian";
            this.ThoiGian.MinWidth = 25;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.ThoiGian.Visible = true;
            this.ThoiGian.VisibleIndex = 3;
            this.ThoiGian.Width = 94;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày thực hiện";
            this.Ngay.MinWidth = 25;
            this.Ngay.Name = "Ngay";
            this.Ngay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 4;
            this.Ngay.Width = 94;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.MinWidth = 25;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 5;
            this.TrangThai.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.panelControl12);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.gcDanhSachGac);
            this.panelControl1.Location = new System.Drawing.Point(3, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1199, 796);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl12
            // 
            this.panelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl12.Controls.Add(this.simpleButton4);
            this.panelControl12.Controls.Add(this.simpleButton2);
            this.panelControl12.Controls.Add(this.simpleButton1);
            this.panelControl12.Location = new System.Drawing.Point(5, 741);
            this.panelControl12.Name = "panelControl12";
            this.panelControl12.Size = new System.Drawing.Size(1178, 50);
            this.panelControl12.TabIndex = 20;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(541, 5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(186, 38);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Text = "Thêm ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(754, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(186, 38);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Xóa";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(964, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 38);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Sửa";
            // 
            // panelControl7
            // 
            this.panelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl7.Controls.Add(this.panelControl3);
            this.panelControl7.Controls.Add(this.panelControl2);
            this.panelControl7.Controls.Add(this.panelControl11);
            this.panelControl7.Controls.Add(this.panelControl8);
            this.panelControl7.Controls.Add(this.panelControl10);
            this.panelControl7.Controls.Add(this.labelControl13);
            this.panelControl7.Location = new System.Drawing.Point(1208, 12);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(643, 796);
            this.panelControl7.TabIndex = 11;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl3.Controls.Add(this.simpleButton5);
            this.panelControl3.Controls.Add(this.simpleButton3);
            this.panelControl3.Location = new System.Drawing.Point(91, 741);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(531, 50);
            this.panelControl3.TabIndex = 22;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(55, 5);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(186, 38);
            this.simpleButton5.TabIndex = 21;
            this.simpleButton5.Text = "Thoát";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(317, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(186, 43);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "Xác nhận";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.textBox17);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(91, 306);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(531, 83);
            this.panelControl2.TabIndex = 19;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(239, 33);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(269, 23);
            this.textBox17.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 26);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Địa điểm thực hiện:";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(25, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(149, 26);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Đơn thực hiện:";
            // 
            // panelControl8
            // 
            this.panelControl8.Controls.Add(this.labelControl8);
            this.panelControl8.Controls.Add(this.richTextBox1);
            this.panelControl8.Location = new System.Drawing.Point(91, 417);
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
            this.richTextBox1.Location = new System.Drawing.Point(239, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(264, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.timeEdit2);
            this.panelControl10.Controls.Add(this.dateEdit1);
            this.panelControl10.Controls.Add(this.labelControl3);
            this.panelControl10.Controls.Add(this.labelControl11);
            this.panelControl10.Location = new System.Drawing.Point(91, 83);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(531, 192);
            this.panelControl10.TabIndex = 10;
            // 
            // timeEdit2
            // 
            this.timeEdit2.EditValue = new System.DateTime(2023, 12, 5, 0, 0, 0, 0);
            this.timeEdit2.Location = new System.Drawing.Point(239, 125);
            this.timeEdit2.Name = "timeEdit2";
            this.timeEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit2.Size = new System.Drawing.Size(269, 24);
            this.timeEdit2.TabIndex = 25;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(239, 50);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(269, 23);
            this.dateEdit1.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(205, 26);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Thời gian thực hiện: ";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(25, 45);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(164, 26);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Ngày thực hiện: ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(196, 26);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(332, 26);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "NHẬP THÔNG TIN CÔNG VIỆC";
            // 
            // frmPhanCongCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 820);
            this.Controls.Add(this.panelControl7);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPhanCongCV";
            this.Text = "Phân công công vệc";
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).EndInit();
            this.panelControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            this.panelControl11.ResumeLayout(false);
            this.panelControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.panelControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSachGac;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachGac;
        private DevExpress.XtraGrid.Columns.GridColumn stt;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn DonViThucHien;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.PanelControl panelControl12;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox textBox17;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit timeEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}
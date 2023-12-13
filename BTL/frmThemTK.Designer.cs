namespace BTL
{
    partial class frmThemTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTK));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl12 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachGac = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachGac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViThucHien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).BeginInit();
            this.panelControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.panelControl12);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.gcDanhSachGac);
            this.panelControl1.Location = new System.Drawing.Point(4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1207, 813);
            this.panelControl1.TabIndex = 7;
            // 
            // panelControl12
            // 
            this.panelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl12.Controls.Add(this.simpleButton4);
            this.panelControl12.Controls.Add(this.simpleButton2);
            this.panelControl12.Controls.Add(this.simpleButton1);
            this.panelControl12.Location = new System.Drawing.Point(5, 758);
            this.panelControl12.Name = "panelControl12";
            this.panelControl12.Size = new System.Drawing.Size(1197, 50);
            this.panelControl12.TabIndex = 20;
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
            this.gcDanhSachGac.Size = new System.Drawing.Size(1197, 662);
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
            // frmThemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 820);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThemTK";
            this.Text = "frmThemTK";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl12)).EndInit();
            this.panelControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachGac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachGac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl12;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSachGac;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachGac;
        private DevExpress.XtraGrid.Columns.GridColumn stt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn DonViThucHien;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}
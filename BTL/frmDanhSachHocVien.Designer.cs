namespace BTL
{
    partial class frmDanhSachHocVien
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHocVien));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcDanhSachQN = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachQN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaQN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenQN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ngayGac = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachQN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachQN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayGac.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayGac.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhSachQN
            // 
            this.gcDanhSachQN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gcDanhSachQN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSachQN.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachQN.MainView = this.gvDanhSachQN;
            this.gcDanhSachQN.Name = "gcDanhSachQN";
            this.gcDanhSachQN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.gcDanhSachQN.Size = new System.Drawing.Size(979, 419);
            this.gcDanhSachQN.TabIndex = 0;
            this.gcDanhSachQN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachQN});
            // 
            // gvDanhSachQN
            // 
            this.gvDanhSachQN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaQN,
            this.TenQN,
            this.TenDV,
            this.TenCV,
            this.gridColumn5});
            this.gvDanhSachQN.GridControl = this.gcDanhSachQN;
            this.gvDanhSachQN.Name = "gvDanhSachQN";
            // 
            // MaQN
            // 
            this.MaQN.Caption = "Mã Quân nhân";
            this.MaQN.FieldName = "MaQN";
            this.MaQN.MaxWidth = 200;
            this.MaQN.MinWidth = 100;
            this.MaQN.Name = "MaQN";
            this.MaQN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.MaQN.Visible = true;
            this.MaQN.VisibleIndex = 0;
            this.MaQN.Width = 200;
            // 
            // TenQN
            // 
            this.TenQN.Caption = "Tên Quân nhân";
            this.TenQN.FieldName = "TenQN";
            this.TenQN.MaxWidth = 400;
            this.TenQN.MinWidth = 25;
            this.TenQN.Name = "TenQN";
            this.TenQN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TenQN.Visible = true;
            this.TenQN.VisibleIndex = 1;
            this.TenQN.Width = 151;
            // 
            // TenDV
            // 
            this.TenDV.Caption = "Tên đơn vị";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.MaxWidth = 200;
            this.TenDV.MinWidth = 25;
            this.TenDV.Name = "TenDV";
            this.TenDV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 2;
            this.TenDV.Width = 151;
            // 
            // TenCV
            // 
            this.TenCV.Caption = "Tên chức vụ";
            this.TenCV.FieldName = "TenCV";
            this.TenCV.MaxWidth = 200;
            this.TenCV.MinWidth = 25;
            this.TenCV.Name = "TenCV";
            this.TenCV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TenCV.Visible = true;
            this.TenCV.VisibleIndex = 3;
            this.TenCV.Width = 151;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Xóa";
            this.gridColumn5.ColumnEdit = this.btnXoa;
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 25;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ngayGac
            // 
            this.ngayGac.EditValue = null;
            this.ngayGac.Location = new System.Drawing.Point(59, 499);
            this.ngayGac.Name = "ngayGac";
            this.ngayGac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayGac.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayGac.Size = new System.Drawing.Size(322, 23);
            this.ngayGac.TabIndex = 3;
            // 
            // frmDanhSachHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 626);
            this.Controls.Add(this.ngayGac);
            this.Controls.Add(this.gcDanhSachQN);
            this.Name = "frmDanhSachHocVien";
            this.Text = "Danh sách học viên";
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachQN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachQN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayGac.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayGac.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSachQN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachQN;
        private DevExpress.XtraGrid.Columns.GridColumn MaQN;
        private DevExpress.XtraGrid.Columns.GridColumn TenQN;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn TenCV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.DateEdit ngayGac;
    }
}
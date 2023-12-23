namespace BTL
{
    partial class frmDanhSachUuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachUuTien));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcDSUuTien = new DevExpress.XtraGrid.GridControl();
            this.gvDSUuTien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaQN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenQN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.cbSua = new DevExpress.XtraEditors.CheckEdit();
            this.cbThem = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaUT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.txtNoiDungUuTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbQN = new System.Windows.Forms.ComboBox();
            this.pncBtnXuLy = new DevExpress.XtraEditors.PanelControl();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaQN = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSUuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUuTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaUT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungUuTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncBtnXuLy)).BeginInit();
            this.pncBtnXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(523, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(186, 38);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(736, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(186, 38);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(946, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(186, 38);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Location = new System.Drawing.Point(9, 739);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1185, 50);
            this.panelControl1.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(328, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(430, 26);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "DANH SÁCH HỌC VIÊN TRONG ĐƠN VỊ";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl2.Controls.Add(this.gcDSUuTien);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(2, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1199, 802);
            this.panelControl2.TabIndex = 22;
            // 
            // gcDSUuTien
            // 
            this.gcDSUuTien.Location = new System.Drawing.Point(2, 140);
            this.gcDSUuTien.MainView = this.gvDSUuTien;
            this.gcDSUuTien.Name = "gcDSUuTien";
            this.gcDSUuTien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDetail});
            this.gcDSUuTien.Size = new System.Drawing.Size(1197, 462);
            this.gcDSUuTien.TabIndex = 23;
            this.gcDSUuTien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSUuTien});
            // 
            // gvDSUuTien
            // 
            this.gvDSUuTien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaQN,
            this.TenQN,
            this.NoiDung,
            this.MaUuTien,
            this.gridColumn7});
            this.gvDSUuTien.GridControl = this.gcDSUuTien;
            this.gvDSUuTien.Name = "gvDSUuTien";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MinWidth = 25;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 94;
            // 
            // MaQN
            // 
            this.MaQN.Caption = "Mã quân nhân";
            this.MaQN.FieldName = "MaQN";
            this.MaQN.MinWidth = 25;
            this.MaQN.Name = "MaQN";
            this.MaQN.Visible = true;
            this.MaQN.VisibleIndex = 1;
            this.MaQN.Width = 94;
            // 
            // TenQN
            // 
            this.TenQN.Caption = "Tên quân nhân";
            this.TenQN.FieldName = "TenQN";
            this.TenQN.MinWidth = 25;
            this.TenQN.Name = "TenQN";
            this.TenQN.Visible = true;
            this.TenQN.VisibleIndex = 2;
            this.TenQN.Width = 94;
            // 
            // NoiDung
            // 
            this.NoiDung.Caption = "Nội dung ưu tiên";
            this.NoiDung.FieldName = "NoiDungUuTien";
            this.NoiDung.MinWidth = 25;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 3;
            this.NoiDung.Width = 94;
            // 
            // MaUuTien
            // 
            this.MaUuTien.Caption = "gridColumn1";
            this.MaUuTien.FieldName = "MaUuTien";
            this.MaUuTien.MinWidth = 25;
            this.MaUuTien.Name = "MaUuTien";
            this.MaUuTien.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.ColumnEdit = this.btnDetail;
            this.gridColumn7.MaxWidth = 70;
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 70;
            // 
            // btnDetail
            // 
            this.btnDetail.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl7
            // 
            this.panelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl7.Controls.Add(this.panelControl10);
            this.panelControl7.Controls.Add(this.pncBtnXuLy);
            this.panelControl7.Controls.Add(this.labelControl13);
            this.panelControl7.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelControl7.Location = new System.Drawing.Point(1207, 12);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(643, 802);
            this.panelControl7.TabIndex = 23;
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.txtMaQN);
            this.panelControl10.Controls.Add(this.cbSua);
            this.panelControl10.Controls.Add(this.cbThem);
            this.panelControl10.Controls.Add(this.txtMaUT);
            this.panelControl10.Controls.Add(this.labelControl4);
            this.panelControl10.Controls.Add(this.cbNganh);
            this.panelControl10.Controls.Add(this.txtNoiDungUuTien);
            this.panelControl10.Controls.Add(this.labelControl3);
            this.panelControl10.Controls.Add(this.labelControl2);
            this.panelControl10.Controls.Add(this.cbQN);
            this.panelControl10.Location = new System.Drawing.Point(91, 78);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(531, 628);
            this.panelControl10.TabIndex = 22;
            // 
            // cbSua
            // 
            this.cbSua.Location = new System.Drawing.Point(212, 389);
            this.cbSua.Name = "cbSua";
            this.cbSua.Properties.Caption = "cbSua";
            this.cbSua.Size = new System.Drawing.Size(87, 20);
            this.cbSua.TabIndex = 39;
            this.cbSua.Visible = false;
            // 
            // cbThem
            // 
            this.cbThem.Location = new System.Drawing.Point(305, 389);
            this.cbThem.Name = "cbThem";
            this.cbThem.Properties.Caption = "cbThem";
            this.cbThem.Size = new System.Drawing.Size(87, 20);
            this.cbThem.TabIndex = 38;
            this.cbThem.Visible = false;
            // 
            // txtMaUT
            // 
            this.txtMaUT.Location = new System.Drawing.Point(224, 302);
            this.txtMaUT.Name = "txtMaUT";
            this.txtMaUT.Size = new System.Drawing.Size(269, 23);
            this.txtMaUT.TabIndex = 37;
            this.txtMaUT.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 26);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Ngành*:";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(224, 79);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(269, 24);
            this.cbNganh.TabIndex = 34;
            this.cbNganh.SelectionChangeCommitted += new System.EventHandler(this.cbNganh_SelectionChangeCommitted);
            // 
            // txtNoiDungUuTien
            // 
            this.txtNoiDungUuTien.Location = new System.Drawing.Point(224, 223);
            this.txtNoiDungUuTien.Name = "txtNoiDungUuTien";
            this.txtNoiDungUuTien.Size = new System.Drawing.Size(269, 23);
            this.txtNoiDungUuTien.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 218);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(179, 26);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Nội dung ưu tiên*:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 26);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Quân nhân*:";
            // 
            // cbQN
            // 
            this.cbQN.FormattingEnabled = true;
            this.cbQN.Location = new System.Drawing.Point(224, 149);
            this.cbQN.Name = "cbQN";
            this.cbQN.Size = new System.Drawing.Size(269, 24);
            this.cbQN.TabIndex = 29;
            // 
            // pncBtnXuLy
            // 
            this.pncBtnXuLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pncBtnXuLy.Controls.Add(this.btnXacNhan);
            this.pncBtnXuLy.Location = new System.Drawing.Point(91, 739);
            this.pncBtnXuLy.Name = "pncBtnXuLy";
            this.pncBtnXuLy.Size = new System.Drawing.Size(531, 50);
            this.pncBtnXuLy.TabIndex = 23;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(163, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(186, 43);
            this.btnXacNhan.TabIndex = 20;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(196, 26);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(244, 26);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // txtMaQN
            // 
            this.txtMaQN.Location = new System.Drawing.Point(224, 340);
            this.txtMaQN.Name = "txtMaQN";
            this.txtMaQN.Size = new System.Drawing.Size(269, 23);
            this.txtMaQN.TabIndex = 40;
            this.txtMaQN.Visible = false;
            // 
            // frmDanhSachUuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 820);
            this.Controls.Add(this.panelControl7);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmDanhSachUuTien";
            this.Text = "frmDanhSachUuTien";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSUuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSUuTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.panelControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaUT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungUuTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncBtnXuLy)).EndInit();
            this.pncBtnXuLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.TextEdit txtNoiDungUuTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cbQN;
        private DevExpress.XtraEditors.PanelControl pncBtnXuLy;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbNganh;
        private DevExpress.XtraEditors.TextEdit txtMaUT;
        private DevExpress.XtraEditors.CheckEdit cbSua;
        private DevExpress.XtraEditors.CheckEdit cbThem;
        private DevExpress.XtraGrid.GridControl gcDSUuTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MaQN;
        private DevExpress.XtraGrid.Columns.GridColumn TenQN;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn MaUuTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetail;
        private DevExpress.XtraEditors.TextEdit txtMaQN;
    }
}
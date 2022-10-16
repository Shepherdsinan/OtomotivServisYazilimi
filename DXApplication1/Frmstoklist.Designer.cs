namespace OtomotivServisYazilimi
{
    partial class Frmstoklist
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmstoklist));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Parça_Kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Parça_Adı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlısFyt_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SatFyt_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KDVli_Satfyt_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Döviz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kayıt_Tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_show = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1025, 531);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Parça_Kod,
            this.Parça_Adı,
            this.Marka,
            this.AlısFyt_TL,
            this.SatFyt_TL,
            this.KDV,
            this.KDVli_Satfyt_TL,
            this.Döviz,
            this.Kayıt_Tarihi,
            this.button_delete,
            this.button_edit,
            this.button_show});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak metni girin...";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            // 
            // Parça_Kod
            // 
            this.Parça_Kod.Caption = "Stok Kodu";
            this.Parça_Kod.FieldName = "Parça_Kod";
            this.Parça_Kod.Name = "Parça_Kod";
            this.Parça_Kod.Visible = true;
            this.Parça_Kod.VisibleIndex = 3;
            this.Parça_Kod.Width = 110;
            // 
            // Parça_Adı
            // 
            this.Parça_Adı.Caption = "Stok Adı";
            this.Parça_Adı.FieldName = "Parça_Adı";
            this.Parça_Adı.Name = "Parça_Adı";
            this.Parça_Adı.Visible = true;
            this.Parça_Adı.VisibleIndex = 4;
            this.Parça_Adı.Width = 326;
            // 
            // Marka
            // 
            this.Marka.Caption = "Marka";
            this.Marka.FieldName = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.Visible = true;
            this.Marka.VisibleIndex = 5;
            // 
            // AlısFyt_TL
            // 
            this.AlısFyt_TL.Caption = "Alış Fiyatı";
            this.AlısFyt_TL.FieldName = "AlısFyt_TL";
            this.AlısFyt_TL.Name = "AlısFyt_TL";
            this.AlısFyt_TL.Visible = true;
            this.AlısFyt_TL.VisibleIndex = 6;
            this.AlısFyt_TL.Width = 71;
            // 
            // SatFyt_TL
            // 
            this.SatFyt_TL.Caption = "Satış Fiyatı";
            this.SatFyt_TL.FieldName = "SatFyt_TL";
            this.SatFyt_TL.Name = "SatFyt_TL";
            this.SatFyt_TL.Visible = true;
            this.SatFyt_TL.VisibleIndex = 7;
            this.SatFyt_TL.Width = 76;
            // 
            // KDV
            // 
            this.KDV.Caption = "Kdv";
            this.KDV.FieldName = "KDV";
            this.KDV.Name = "KDV";
            this.KDV.Visible = true;
            this.KDV.VisibleIndex = 8;
            this.KDV.Width = 56;
            // 
            // KDVli_Satfyt_TL
            // 
            this.KDVli_Satfyt_TL.Caption = "Kdv li Satış Fiyatı";
            this.KDVli_Satfyt_TL.FieldName = "KDVli_Satfyt_TL";
            this.KDVli_Satfyt_TL.Name = "KDVli_Satfyt_TL";
            this.KDVli_Satfyt_TL.Visible = true;
            this.KDVli_Satfyt_TL.VisibleIndex = 9;
            this.KDVli_Satfyt_TL.Width = 93;
            // 
            // Döviz
            // 
            this.Döviz.Caption = "Döviz";
            this.Döviz.FieldName = "Döviz";
            this.Döviz.Name = "Döviz";
            this.Döviz.Visible = true;
            this.Döviz.VisibleIndex = 10;
            this.Döviz.Width = 39;
            // 
            // Kayıt_Tarihi
            // 
            this.Kayıt_Tarihi.Caption = "Kayıt Tarihi";
            this.Kayıt_Tarihi.FieldName = "Kayıt_Tarihi";
            this.Kayıt_Tarihi.Name = "Kayıt_Tarihi";
            this.Kayıt_Tarihi.Visible = true;
            this.Kayıt_Tarihi.VisibleIndex = 11;
            this.Kayıt_Tarihi.Width = 101;
            // 
            // button_delete
            // 
            this.button_delete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.button_delete.Name = "button_delete";
            this.button_delete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.button_delete.Visible = true;
            this.button_delete.VisibleIndex = 1;
            this.button_delete.Width = 20;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // button_edit
            // 
            this.button_edit.ColumnEdit = this.repositoryItemButtonEdit2;
            this.button_edit.Name = "button_edit";
            this.button_edit.Visible = true;
            this.button_edit.VisibleIndex = 0;
            this.button_edit.Width = 20;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // button_show
            // 
            this.button_show.ColumnEdit = this.repositoryItemButtonEdit3;
            this.button_show.Name = "button_show";
            this.button_show.Visible = true;
            this.button_show.VisibleIndex = 2;
            this.button_show.Width = 20;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // Frmstoklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 529);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frmstoklist";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.Frmstoklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Parça_Kod;
        private DevExpress.XtraGrid.Columns.GridColumn Parça_Adı;
        private DevExpress.XtraGrid.Columns.GridColumn Marka;
        private DevExpress.XtraGrid.Columns.GridColumn AlısFyt_TL;
        private DevExpress.XtraGrid.Columns.GridColumn SatFyt_TL;
        private DevExpress.XtraGrid.Columns.GridColumn KDV;
        private DevExpress.XtraGrid.Columns.GridColumn KDVli_Satfyt_TL;
        private DevExpress.XtraGrid.Columns.GridColumn Döviz;
        private DevExpress.XtraGrid.Columns.GridColumn Kayıt_Tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn button_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn button_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn button_show;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
    }
}
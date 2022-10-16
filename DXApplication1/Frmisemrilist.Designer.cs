namespace OtomotivServisYazilimi
{
    partial class Frmisemrilist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmisemrilist));
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
            this.Yıl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İşEmriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İETip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Giriş_Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Müşteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Plaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Araç_Tip_Adı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Parça_Tpl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Toplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kayıt_Tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.button_show = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-2, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit2,
            this.repositoryItemButtonEdit3,
            this.repositoryItemButtonEdit4});
            this.gridControl1.Size = new System.Drawing.Size(1025, 530);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Yıl,
            this.İşEmriNo,
            this.İETip,
            this.Giriş_Tarih,
            this.Müşteri,
            this.Plaka,
            this.Araç_Tip_Adı,
            this.Model,
            this.KM,
            this.Parça_Tpl,
            this.Toplam,
            this.Kayıt_Tarihi,
            this.button_delete,
            this.button_edit,
            this.button_show});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak metni girin...";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Yıl
            // 
            this.Yıl.Caption = "YıL";
            this.Yıl.FieldName = "Yıl";
            this.Yıl.Name = "Yıl";
            this.Yıl.Visible = true;
            this.Yıl.VisibleIndex = 2;
            this.Yıl.Width = 46;
            // 
            // İşEmriNo
            // 
            this.İşEmriNo.Caption = "İş Emri No";
            this.İşEmriNo.FieldName = "İşEmriNo";
            this.İşEmriNo.Name = "İşEmriNo";
            this.İşEmriNo.Visible = true;
            this.İşEmriNo.VisibleIndex = 3;
            this.İşEmriNo.Width = 57;
            // 
            // İETip
            // 
            this.İETip.Caption = "İETip";
            this.İETip.FieldName = "İETip";
            this.İETip.Name = "İETip";
            this.İETip.Visible = true;
            this.İETip.VisibleIndex = 4;
            this.İETip.Width = 35;
            // 
            // Giriş_Tarih
            // 
            this.Giriş_Tarih.Caption = "Giriş Tarihi";
            this.Giriş_Tarih.FieldName = "Giriş_Tarih";
            this.Giriş_Tarih.Name = "Giriş_Tarih";
            this.Giriş_Tarih.Visible = true;
            this.Giriş_Tarih.VisibleIndex = 5;
            this.Giriş_Tarih.Width = 62;
            // 
            // Müşteri
            // 
            this.Müşteri.Caption = "Müşteri";
            this.Müşteri.FieldName = "Müşteri";
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Visible = true;
            this.Müşteri.VisibleIndex = 6;
            this.Müşteri.Width = 251;
            // 
            // Plaka
            // 
            this.Plaka.Caption = "Plaka";
            this.Plaka.FieldName = "Plaka";
            this.Plaka.Name = "Plaka";
            this.Plaka.Visible = true;
            this.Plaka.VisibleIndex = 7;
            this.Plaka.Width = 130;
            // 
            // Araç_Tip_Adı
            // 
            this.Araç_Tip_Adı.Caption = "Araç Tip Adı";
            this.Araç_Tip_Adı.FieldName = "Araç_Tip_Adı";
            this.Araç_Tip_Adı.Name = "Araç_Tip_Adı";
            this.Araç_Tip_Adı.Visible = true;
            this.Araç_Tip_Adı.VisibleIndex = 8;
            this.Araç_Tip_Adı.Width = 63;
            // 
            // Model
            // 
            this.Model.Caption = "Model";
            this.Model.FieldName = "Model";
            this.Model.Name = "Model";
            this.Model.Visible = true;
            this.Model.VisibleIndex = 9;
            this.Model.Width = 46;
            // 
            // KM
            // 
            this.KM.Caption = "KM";
            this.KM.FieldName = "KM";
            this.KM.Name = "KM";
            this.KM.Visible = true;
            this.KM.VisibleIndex = 10;
            this.KM.Width = 37;
            // 
            // Parça_Tpl
            // 
            this.Parça_Tpl.Caption = "Parça Toplamı";
            this.Parça_Tpl.FieldName = "Parça_Tpl";
            this.Parça_Tpl.Name = "Parça_Tpl";
            this.Parça_Tpl.Visible = true;
            this.Parça_Tpl.VisibleIndex = 11;
            this.Parça_Tpl.Width = 80;
            // 
            // Toplam
            // 
            this.Toplam.Caption = "Toplam";
            this.Toplam.FieldName = "Toplam";
            this.Toplam.Name = "Toplam";
            this.Toplam.Visible = true;
            this.Toplam.VisibleIndex = 12;
            this.Toplam.Width = 43;
            // 
            // Kayıt_Tarihi
            // 
            this.Kayıt_Tarihi.Caption = "Kayıt Tarihi";
            this.Kayıt_Tarihi.FieldName = "Kayıt_Tarihi";
            this.Kayıt_Tarihi.Name = "Kayıt_Tarihi";
            this.Kayıt_Tarihi.Visible = true;
            this.Kayıt_Tarihi.VisibleIndex = 13;
            this.Kayıt_Tarihi.Width = 97;
            // 
            // button_delete
            // 
            this.button_delete.ColumnEdit = this.repositoryItemButtonEdit2;
            this.button_delete.Name = "button_delete";
            this.button_delete.Visible = true;
            this.button_delete.VisibleIndex = 14;
            this.button_delete.Width = 20;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // button_edit
            // 
            this.button_edit.ColumnEdit = this.repositoryItemButtonEdit3;
            this.button_edit.Name = "button_edit";
            this.button_edit.Visible = true;
            this.button_edit.VisibleIndex = 0;
            this.button_edit.Width = 20;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit3_ButtonClick);
            // 
            // button_show
            // 
            this.button_show.ColumnEdit = this.repositoryItemButtonEdit4;
            this.button_show.Name = "button_show";
            this.button_show.Visible = true;
            this.button_show.VisibleIndex = 1;
            this.button_show.Width = 20;
            // 
            // repositoryItemButtonEdit4
            // 
            this.repositoryItemButtonEdit4.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemButtonEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit4.Name = "repositoryItemButtonEdit4";
            this.repositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit4.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit4_ButtonClick);
            // 
            // Frmisemrilist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 529);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frmisemrilist";
            this.Text = "İş Emirleri Listesi";
            this.Load += new System.EventHandler(this.Frmisemrilist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn İşEmriNo;
        private DevExpress.XtraGrid.Columns.GridColumn İETip;
        private DevExpress.XtraGrid.Columns.GridColumn Giriş_Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Müşteri;
        private DevExpress.XtraGrid.Columns.GridColumn Plaka;
        private DevExpress.XtraGrid.Columns.GridColumn Araç_Tip_Adı;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraGrid.Columns.GridColumn KM;
        private DevExpress.XtraGrid.Columns.GridColumn Parça_Tpl;
        private DevExpress.XtraGrid.Columns.GridColumn Toplam;
        private DevExpress.XtraGrid.Columns.GridColumn Kayıt_Tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Yıl;
        private DevExpress.XtraGrid.Columns.GridColumn button_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn button_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn button_show;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit4;
    }
}
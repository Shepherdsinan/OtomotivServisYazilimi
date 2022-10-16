namespace OtomotivServisYazilimi
{
    partial class Frmmodeladd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmodeladd));
            this.txtmdlkod = new DevExpress.XtraEditors.TextEdit();
            this.txtmdlad = new DevExpress.XtraEditors.TextEdit();
            this.btniecarisec = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtmdlkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmdlad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmdlkod
            // 
            this.txtmdlkod.Location = new System.Drawing.Point(12, 33);
            this.txtmdlkod.Name = "txtmdlkod";
            this.txtmdlkod.Size = new System.Drawing.Size(152, 20);
            this.txtmdlkod.TabIndex = 0;
            // 
            // txtmdlad
            // 
            this.txtmdlad.Location = new System.Drawing.Point(189, 33);
            this.txtmdlad.Name = "txtmdlad";
            this.txtmdlad.Size = new System.Drawing.Size(148, 20);
            this.txtmdlad.TabIndex = 1;
            // 
            // btniecarisec
            // 
            this.btniecarisec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btniecarisec.Appearance.Options.UseFont = true;
            this.btniecarisec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btniecarisec.ImageOptions.Image")));
            this.btniecarisec.Location = new System.Drawing.Point(374, 29);
            this.btniecarisec.Name = "btniecarisec";
            this.btniecarisec.Size = new System.Drawing.Size(94, 28);
            this.btniecarisec.TabIndex = 154;
            this.btniecarisec.Text = "Ekle";
            this.btniecarisec.Click += new System.EventHandler(this.btniecarisec_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-3, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(512, 389);
            this.gridControl1.TabIndex = 155;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak metni girin...";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 156;
            this.label1.Text = "Model Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 157;
            this.label2.Text = "Model Adı";
            // 
            // Frmmodeladd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btniecarisec);
            this.Controls.Add(this.txtmdlad);
            this.Controls.Add(this.txtmdlkod);
            this.Name = "Frmmodeladd";
            this.Text = "Frmmodeladd";
            this.Load += new System.EventHandler(this.Frmmodeladd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmdlkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmdlad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtmdlkod;
        private DevExpress.XtraEditors.TextEdit txtmdlad;
        private DevExpress.XtraEditors.SimpleButton btniecarisec;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
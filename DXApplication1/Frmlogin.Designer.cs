namespace OtomotivServisYazilimi
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkpw = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbkad = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnlgnyp = new DevExpress.XtraEditors.SimpleButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtkpw);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cmbkad);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtkpw
            // 
            this.txtkpw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkpw.Location = new System.Drawing.Point(29, 80);
            this.txtkpw.Name = "txtkpw";
            this.txtkpw.PasswordChar = '*';
            this.txtkpw.Size = new System.Drawing.Size(204, 25);
            this.txtkpw.TabIndex = 7;
            this.txtkpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkpw_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(31, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 15);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Kullanıcı Şifresi";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // cmbkad
            // 
            this.cmbkad.EditValue = "ADMIN";
            this.cmbkad.Location = new System.Drawing.Point(29, 32);
            this.cmbkad.Name = "cmbkad";
            this.cmbkad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbkad.Properties.Appearance.Options.UseFont = true;
            this.cmbkad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbkad.Properties.Items.AddRange(new object[] {
            "ADMIN"});
            this.cmbkad.Size = new System.Drawing.Size(204, 24);
            this.cmbkad.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 131);
            this.panel1.TabIndex = 7;
            // 
            // btncancel
            // 
            this.btncancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncancel.Appearance.Options.UseFont = true;
            this.btncancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.ImageOptions.Image")));
            this.btncancel.Location = new System.Drawing.Point(169, 265);
            this.btncancel.Name = "btncancel";
            this.btncancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "İptal";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlgnyp
            // 
            this.btnlgnyp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlgnyp.Appearance.Options.UseFont = true;
            this.btnlgnyp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlgnyp.ImageOptions.Image")));
            this.btnlgnyp.Location = new System.Drawing.Point(41, 265);
            this.btnlgnyp.Name = "btnlgnyp";
            this.btnlgnyp.Size = new System.Drawing.Size(75, 23);
            this.btnlgnyp.TabIndex = 5;
            this.btnlgnyp.Text = "Tamam";
            this.btnlgnyp.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlgnyp);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Frmlogin.IconOptions.Icon")));
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Onay";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbkad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbkad;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnlgnyp;
        private System.Windows.Forms.TextBox txtkpw;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}
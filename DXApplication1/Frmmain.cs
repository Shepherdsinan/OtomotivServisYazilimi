using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtomotivServisYazilimi
{

    public partial class Frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmmain()
        {
            InitializeComponent();
        }

        private void btnisemrilist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmisemrilist frmilist = new Frmisemrilist();
            frmilist.MdiParent = this;
            frmilist.Show();



        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmnewisemri frmnewis = new Frmnewisemri();
            frmnewis.MdiParent = this;
            frmnewis.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var isemridegerler = db.ISEMRI.SingleOrDefault(a => a.IS_EMRI_NO == Frmnewisemri.ienodata);

            if (Frmnewisemri.ienodata != null && isemridegerler != null)
            {

                Frmyedekparca frmyp = new Frmyedekparca();
                frmyp.MdiParent = this;
                frmyp.Show();
            }
            else
            {
                XtraMessageBox.Show("Sadece Yeni Bir Kayıt Oluştururduktan Sonra Yedekparça Ekleyebilirsin..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.owner = this;
            Frmisemrilist frmilist = new Frmisemrilist();
            frmilist.MdiParent = this;
            frmilist.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmstoklist frmstklist = new Frmstoklist();
            frmstklist.MdiParent = this;
            frmstklist.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmcarilist frmcrlist = new Frmcarilist();
            frmcrlist.MdiParent = this;
            frmcrlist.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Frmisemrilist.ienolist != null)
            {
                Frmhistory frmh = new Frmhistory();
                frmh.MdiParent = this;
                frmh.Show();
            }
            else
            {
                
                XtraMessageBox.Show("Bir Araçın Geçmişini Görüntüleyebilmek İçin İşemri Listesinden Seçim Yapmalısın..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Application.Exit();

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => this.WindowState = FormWindowState.Minimized;
        

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs a)
        {
            Frmnewstok frmnwstk = new Frmnewstok();

            frmnwstk.MdiParent = this;
            frmnwstk.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmnewcari frnrcari = new Frmnewcari();
            frnrcari.MdiParent = this;
            frnrcari.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmnewisemri frmnewis = new Frmnewisemri();
            frmnewis.MdiParent = this;
            frmnewis.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var isemridegerler = db.ISEMRI.SingleOrDefault(a => a.IS_EMRI_NO == Frmnewisemri.ienodata);

            if (Frmnewisemri.ienodata != null && isemridegerler != null)
            {

                Frmyedekparca frmyp = new Frmyedekparca();
                frmyp.MdiParent = this;
                frmyp.Show();
            }
            else
            {
                XtraMessageBox.Show("Sadece Yeni Bir Kayıt Oluştururduktan Sonra Yedekparça Ekleyebilirsin..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmisemrilist frmilist = new Frmisemrilist();
            frmilist.MdiParent = this;
            frmilist.Show();
        }
    }
}

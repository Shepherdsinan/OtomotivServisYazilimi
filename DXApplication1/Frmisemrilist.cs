using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;

namespace OtomotivServisYazilimi
{
    public partial class Frmisemrilist : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        
        public Frmisemrilist()
        {
            InitializeComponent();
        }
        public static string ienolist;
        
        

        private void Frmisemrilist_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
           ienolist  = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            

        }


        private void listele()
        {
            try
            {
                gridView1.OptionsView.ShowFooter = true; // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar

                var veri = (from x in db.ISEMRI
                    join u in db.CARI on x.CARI_KOD equals u.CARI_KOD
                    orderby (x.IS_EMRI_NO) ascending
                    select new
                    {

                        Yıl = x.YIL,
                        İşEmriNo = x.IS_EMRI_NO,
                        İETip = x.IE_TIP,
                        Giriş_Tarih = x.ARAC_GIRIS_TRH,
                        Müşteri = u.FIRMA_ADI,
                        Plaka = x.PLAKA_NO,
                        Araç_Tip_Adı = x.ARAC_TIP,
                        Model = x.ARAC_MODEL,
                        x.KM,
                        Parça_Tpl = x.PAR_TOP_TUTAR,
                        Toplam = x.TOP_TUTAR,
                        Kayıt_Tarihi = x.INS_DATE

                    }).ToList();




                gridControl1.DataSource = veri;


            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void gridControl1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            ienolist = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            if (ienolist != null)
            {
                Frmhistory frmh = new Frmhistory();
                frmh.MdiParent = Program.owner;
                frmh.Show();
            }
            else
            {
                XtraMessageBox.Show("Bir Araçın Geçmişini Görüntüleyebilmek İçin İşemri Listesinden Seçim Yapmalısın..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string i = gridView1.GetFocusedRowCellValue("İşEmriNo").ToString();

            if (XtraMessageBox.Show(i.ToString() + " 'nolu İşEmrini silmek istediğinize emin misiniz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ISEMRI ieno = db.ISEMRI.First(x => x.IS_EMRI_NO == i);
                db.ISEMRI.Remove(ieno);
                db.SaveChanges();
                var deger = db.ISEAYRIN.Where(x => x.ISEMRI_NO == i).Count();
                if (deger == 0)
                {

                }
                else
                {
                    var liste = from k in db.ISEAYRIN
                        where k.ISEMRI_NO == i
                        select k;
                    liste.ToList().ForEach(x => db.ISEAYRIN.Remove(x));
                    db.SaveChanges();
                }

                XtraMessageBox.Show(i.ToString() + " 'nolu İşEmri silindi", "Sistem Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                listele();
            }

            
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Frmisemrilist.ienolist != null)
            {
                Frmhistory frmh = new Frmhistory();
               // frmh.MdiParent = this;
                frmh.Show();
            }
            else
            {

                XtraMessageBox.Show("Bir Araçın Geçmişini Görüntüleyebilmek İçin İşemri Listesinden Seçim Yapmalısın..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void repositoryItemButtonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ienolist = gridView1.GetFocusedRowCellValue("Plaka").ToString();
            Frmhistory frmh = new Frmhistory();
            frmh.MdiParent = Program.owner;
            frmh.Show();
            //MessageBox.Show(i+"test2");
            
        }
    }
}


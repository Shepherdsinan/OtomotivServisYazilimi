using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomotivServisYazilimi
{
    public partial class Frmhistory : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmhistory()
        {
            InitializeComponent();
        }
        
        private void Frmhistory_Load(object sender, EventArgs e)
        {
            this.gridControl1.TabIndex = 0;            
           
            
            this.gridView1.OptionsView.ShowFooter = true; // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar
            this.gridView1.OptionsBehavior.Editable = false;// gridview hücre focuslanmasını iptal eder. //Gird üzerinden ekle güncelle işlemi yapacaksanız bunu açarsınız.
            
            
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsBehavior.Editable = false;

            string i = Frmisemrilist.ienolist;
            
            if (i !=null)
            {


                //var qery1 = db.ISEMRI.Where(x => x.IS_EMRI_NO == i.ToString()).ToList();

                var qery1 = (from x in db.ISEMRI
                             join u in db.CARI on x.CARI_KOD equals u.CARI_KOD
                             where x.PLAKA_NO == i
                             orderby (x.ARAC_GIRIS_TRH) ascending
                             select new
                             {                                 
                                 İşEmriNo = x.IS_EMRI_NO,                                 
                                 Giriş_Tarih = x.ARAC_GIRIS_TRH,
                                 Firma_Adı = u.FIRMA_ADI,
                                 Plaka = x.PLAKA_NO,                           
                                 x.KM,
                                 Araç_Tip_Adı = x.ARAC_TIP,
                                 Model = x.ARAC_MODEL,
                                 Parça_Tpl = x.PAR_TOP_TUTAR,
                                 Toplam = x.TOP_TUTAR,
                                 
                             }).ToList();


                this.gridControl1.DataSource = qery1;
            }
            string plakayp = Frmyedekparca.plakayp;
            if (plakayp != null)
            {


                //var qery1 = db.ISEMRI.Where(x => x.IS_EMRI_NO == i.ToString()).ToList();

                var qery1 = (from x in db.ISEMRI
                             join u in db.CARI on x.CARI_KOD equals u.CARI_KOD
                             where x.PLAKA_NO == plakayp
                             orderby (x.ARAC_GIRIS_TRH) ascending
                             select new
                             {
                                 İşEmriNo = x.IS_EMRI_NO,
                                 Giriş_Tarih = x.ARAC_GIRIS_TRH,
                                 Firma_Adı = u.FIRMA_ADI,
                                 Plaka = x.PLAKA_NO,
                                 x.KM,
                                 Araç_Tip_Adı = x.ARAC_TIP,
                                 Model = x.ARAC_MODEL,
                                 Parça_Tpl = x.PAR_TOP_TUTAR,
                                 Toplam = x.TOP_TUTAR,

                             }).ToList();


                this.gridControl1.DataSource = qery1;
            }
            gridView1.Columns["Parça_Tpl"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["Parça_Tpl"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Parça_Tpl"].SummaryItem.Tag = 1;
            // bu 3 satır gridin ve RECNO kolonun en altına kayıt adedini gösterir.

            gridView1.Columns["Toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Toplam"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Toplam"].SummaryItem.Tag = 1;



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            string a = gridView1.GetFocusedRowCellValue("İşEmriNo").ToString();
            if (a != null)
            {


                //var qery1 = db.ISEMRI.Where(x => x.IS_EMRI_NO == i.ToString()).ToList();

                var qery2 = (from x in db.ISEAYRIN                             
                             where x.ISEMRI_NO == a
                             orderby (x.ID) ascending
                             select new
                             {
                                 Parça_Kod = x.STOK_KOD_NO,
                                 Parça_Adı = x.YEDEK_P_ADI,
                                 Miktar = x.STOK_MIKTAR,                                 
                                 Fiyatı = x.STOK_FIYATI
                                 

                             }).ToList();


                this.gridControl2.DataSource = qery2;
            }
            gridView2.Columns["Fiyatı"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView2.Columns["Fiyatı"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView2.Columns["Fiyatı"].SummaryItem.Tag = 1;
            this.gridView2.Columns[0].Width = 50;
            this.gridView2.Columns[2].Width = 30;
            this.gridView2.Columns[3].Width = 30;
        }
    }
}

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
    public partial class Frmstoklist : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmstoklist()
        {
            InitializeComponent();
            
        }
        
        private void Frmstoklist_Load(object sender, EventArgs e)
        {




            this.gridView1.OptionsView.ShowGroupPanel = false; // kolon başlıklarının üzerinde bir gruplama alanı açar
            this.gridView1.OptionsView.ShowFooter = true; // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar
            //this.gridView1.OptionsBehavior.Editable = false;// gridview hücre focuslanmasını iptal eder. 
                                                            //Gird üzerinden ekle güncelle işlemi yapacaksanız bunu açarsınız.
            var veri = (from x in db.STOK
                        orderby (x.STOK_NO) ascending
                        select new
                        {
                            Parça_Kod = x.STOK_KOD_NO,
                            Parça_Adı = x.STOK_ADI_TR,
                            Marka = x.MARKAKOD,
                            AlısFyt_TL = x.ALIS_FYT_TL,
                            SatFyt_TL = x.SAT_FYT_TL,
                            x.KDV,
                            KDVli_Satfyt_TL = x.SAT_FYT_TL,
                            Döviz = x.FYT_KUR,
                            Kayıt_Tarihi = x.INS_DATE


                        }).ToList();



            this.gridControl1.DataSource = veri;
            //this.gridView1.Columns[4].Width = 180;
            //this.gridView1.Columns[5].Width = 82;
            //gridView1.Columns["Parça_Tpl"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            //gridView1.Columns["Parça_Tpl"].SummaryItem.DisplayFormat = "{0:N2}";
            //gridView1.Columns["Parça_Tpl"].SummaryItem.Tag = 1;
            //// bu 3 satır gridin ve RECNO kolonun en altına kayıt adedini gösterir.

            //gridView1.Columns["Toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //gridView1.Columns["Toplam"].SummaryItem.DisplayFormat = "{0:N2}";
            //gridView1.Columns["Toplam"].SummaryItem.Tag = 1;
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            XtraMessageBox.Show("silme");
        }
    }
}

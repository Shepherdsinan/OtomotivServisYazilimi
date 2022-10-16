using DevExpress.XtraEditors;
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
    public partial class Frmcarilist : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmcarilist()
        {
            InitializeComponent();
        }

        private void Frmcarilist_Load(object sender, EventArgs e)
        {


            try
            {
                if (Frmnewisemri.kontrol == "true")
                {
                    btniecarisec.Show();
                }
                else
                {
                    btniecarisec.Hide();
                }

                this.gridView1.OptionsView.ShowGroupPanel = false; // kolon başlıklarının üzerinde bir gruplama alanı açar
                this.gridView1.OptionsView.ShowFooter = true; // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar
                this.gridView1.OptionsBehavior.Editable = false;// gridview hücre focuslanmasını iptal eder. 
                //Gird üzerinden ekle güncelle işlemi yapacaksanız bunu açarsınız.
                var veri = (from x in db.CARI
                    orderby (x.CARI_KOD) ascending
                    select new
                    {
                        Müşteri_Kod = x.CARI_KOD,
                        Müşteri_Firma_Adı = x.FIRMA_ADI,
                        Yetkili_Adı = x.YETKILI_ADI,
                        Yetkili_Soyadı = x.YETKILI_SOYAD,
                        Semt = x.SEMT,
                        İl = x.ILI,
                        Tel1 = x.TEL1,
                        Tel2 = x.TEL2,
                        Gsm = x.TEL3,
                        Kayıt_Tarihi = x.INS_DATE


                    }).ToList();


                this.gridControl1.DataSource = veri;
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
            
        }

        private void btniecarisec_Click(object sender, EventArgs e)
        {
            Frmnewisemri.kontrol = "false";
            Frmnewisemri x = (Frmnewisemri)Application.OpenForms["Frmnewisemri"];
            x.txtcarikod.Text = gridView1.GetFocusedRowCellValue("Müşteri_Kod").ToString();
            //x.txtcariad.Text = gridView1.GetFocusedRowCellValue("Müşteri_Firma_Adı").ToString();
            //x.txtceptel.Text = gridView1.GetFocusedRowCellValue("Gsm").ToString();
            this.Close();
        }

        private void Frmcarilist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frmnewisemri.kontrol = "false";
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frmnewisemri.kontrol = "false";
            Frmnewisemri x = (Frmnewisemri)Application.OpenForms["Frmnewisemri"];
            x.txtcarikod.Text = gridView1.GetFocusedRowCellValue("Müşteri_Kod").ToString();
            //x.txtcariad.Text = gridView1.GetFocusedRowCellValue("Müşteri_Firma_Adı").ToString();
            //x.txtceptel.Text = gridView1.GetFocusedRowCellValue("Gsm").ToString();
            this.Close();
        }
    }
}

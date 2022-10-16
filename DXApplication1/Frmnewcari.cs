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
    public partial class Frmnewcari : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmnewcari()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CARI c = new CARI();
                c.CARI_KOD = txtcarikod.Text;
                c.FIRMA_ADI = txtcariad.Text;
                c.YETKILI_ADI = txtyetkiliadi.Text;
                c.YETKILI_SOYAD = txtyetkilisoyadi.Text;
                c.ADRES_1 = txtadres1.Text;
                c.ADRES_2 = txtadres2.Text;
                c.ILI = cmbil.Text;
                c.SEMT = cmbilce.Text;
                if (txttel1.Text != "")
                {
                    var tel1 = txttel1.Text.Substring(0, 5) + txttel1.Text.Substring(6, 3) + " " + txttel1.Text.Substring(10, 4);
                    c.TEL1 = tel1;
                }
                if (txttel2.Text != "")
                {
                    var tel2 = txttel2.Text.Substring(0, 5) + txttel2.Text.Substring(6, 3) + " " + txttel2.Text.Substring(10, 4);
                    c.TEL2 = tel2;
                }
                if (txtgsm1.Text != "")
                {
                    var gsm1 = txtgsm1.Text.Substring(0, 5) + txtgsm1.Text.Substring(6, 3) + " " + txtgsm1.Text.Substring(10, 4);
                    c.TEL3 = gsm1;
                }
                if (txtgsm2.Text != "")
                {
                    var gsm2 = txtgsm2.Text.Substring(0, 5) + txtgsm2.Text.Substring(6, 3) + " " + txtgsm2.Text.Substring(10, 4);
                    c.TEL4 = gsm2;
                }

                if (txtfirmatip.Text == "Firma")
                {
                    c.CINSIYET = "F";
                }
                if (txtfirmatip.Text == "Şahıs")
                {
                    c.CINSIYET = "E";
                }

                c.VN = txtvn.Text;
                c.VD = txtvd.Text;
                c.OZEL_KOD_1 = txtozelkod1.Text;
                c.OZEL_KOD_2 = txtozelkod2.Text;
                c.OZEL_KOD_3 = txtozelkod3.Text;
                c.WEB_AKTAR = 0;
                c.INS_DATE = DateTime.Now;
                c.KAYIT_TRH = DateTime.Now;
                c.ILETISIM_YOK = "-";
                c.CARI_GRP_KOD = "K";
           
                db.CARI.Add(c);
                db.SaveChanges();
                if ((XtraMessageBox.Show("Cari kaydı başarıyla tamamlandı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information))==DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
        }

        private void Frmnewcari_Load(object sender, EventArgs e)
        {
            Int64 carikod = Int64.Parse(db.CARI.Select(p => p.CARI_KOD).Max().Trim().Substring(1, 10));
            Int64 carikdeger = carikod + 1;
            txtcarikod.Text = "A0000000" + carikdeger;
        }
    }
}

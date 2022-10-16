using DevExpress.Data.Filtering.Helpers;
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
    public partial class Frmnewisemri : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmnewisemri()
        {
            InitializeComponent();
        }
        public static string ienodata;
        public static string kontrol;
        private void Frmnewisemri_Load(object sender, EventArgs e)
        {
            
            btnnewrec.Enabled = false;
            simpleButton13.Enabled = false;
            btnyedekparca.Enabled = false;
            btnisemrisakla.Enabled = true;
            btniptal.Enabled = true;
            Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
            txtisemrino.Text = (ieno + 1).ToString();
            ienodata = txtisemrino.Text;
            dateEdit1.Text = DateTime.Now.ToString();
            txtmodelyil.Text = "1900";
            txtkm.Text = "0";
            
        }

        string tip;
        string marka;
        private void txtmodel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmodel.Text))
                {
                    var modeldegerler = db.MODEL.SingleOrDefault(a => a.ARC_MODEL_KODU == txtmodel.Text);

                    if (modeldegerler != null)
                    {
                        marka = modeldegerler.MARKA;
                        tip = modeldegerler.MODEL1;
                        txtmodel.Text = modeldegerler.ARC_MODEL_KODU;
                        txtmodeladi.Text = modeldegerler.ARC_MODEL_ADI;
                    }

                    txtmodel.Text = txtmodel.Text.ToUpper();
                    txtmodel.SelectionStart = txtmodel.Text.Length;
                }
                
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.ToString());
            }
            
        }

        private void btnfrmkpt_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtplakano_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    var deger = db.ISEMRI.Where(x => x.PLAKA_NO == txtplakano.Text).Count();

                    if (deger != 0)
                    {
                        ISEMRI degerler = db.ISEMRI.OrderByDescending(x => x.IS_EMRI_NO).ThenByDescending(x => x.ID).FirstOrDefault(a => a.PLAKA_NO == txtplakano.Text);



                        txtcarikod.Text = degerler.CARI_KOD;
                        txtsaseno.Text = degerler.SASI_NO;
                        txtmotorno.Text = degerler.MOTOR_NO;
                        txtkm.Text = degerler.KM.ToString();

                        var caridegerler = db.CARI.SingleOrDefault(a => a.CARI_KOD == degerler.CARI_KOD);
                        txtcariad.Text = caridegerler.FIRMA_ADI;
                        txttel.Text = caridegerler.TEL1;
                        txtceptel.Text = caridegerler.TEL3;

                        var modeldegerler = db.MODEL.SingleOrDefault(a => a.ARC_MODEL_KODU == degerler.ARAC_TIP);
                        marka = modeldegerler.MARKA;
                        tip = modeldegerler.MODEL1;
                        txtmodel.Text = modeldegerler.ARC_MODEL_KODU;
                        txtmodeladi.Text = modeldegerler.ARC_MODEL_ADI;
                        txtmodelyil.Text = degerler.ARAC_MODEL;
                    }
                    else
                        if (XtraMessageBox.Show("Ruhsat Kaydını Girmek İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtcarikod.Enabled = true;
                        Int64 carikod = Int64.Parse(db.CARI.Select(p => p.CARI_KOD).Max().Trim().Substring(1, 10));
                        Int64 carikdeger = carikod + 1;
                        txtcarikod.Text = "A0000000" + carikdeger;
                        txtcariad.Enabled = true;
                        txtczkod1.Enabled = true;
                        txtczkod2.Enabled = true;
                        txtczkod3.Enabled = true;
                        txtmodel.Enabled = true;
                        txtmodelyil.Enabled = true;
                        txtceptel.Enabled = true;
                        //Int64 saseno = Int64.Parse(db.ARAC.Select(p => p.SASE_NO).Max().Trim());
                        //txtsaseno.Text = (saseno + 1).ToString();
                        //txtsaseno.Text = db.ARAC.Select(p => p.SASE_NO).Max().Trim();

                        Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
                        txtisemrino.Text = (ieno + 1).ToString();

                    }


                }
            }
            catch (Exception exp)
            {

                XtraMessageBox.Show(exp.ToString(),"Birşeyler Ters Gitti",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        

        private void btnisemrisakla_Click(object sender, EventArgs e)
        {
            if (txtcariad.Text == string.Empty || txtceptel.Text == string.Empty || txtkm.Text == string.Empty || txtmodel.Text == string.Empty || txtmodelyil.Text == string.Empty || txtplakano.Text == string.Empty || txtsaseno.Text == string.Empty)
            {
                XtraMessageBox.Show("Gerekli Alanları Doldurun!!!","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                btnnewrec.Enabled = true;
                simpleButton13.Enabled = true;

                btnyedekparca.Enabled = true;
                btnisemrisakla.Enabled = false;
                btniptal.Enabled = false;
                try
                {
                    var deger = db.ISEMRI.Where(x => x.PLAKA_NO == txtplakano.Text).Count();

                    if (deger != 0)
                    {
                        ISEMRI I = new ISEMRI();
                        I.IS_EMRI_NO = txtisemrino.Text;
                        I.IE_TIP = "E";
                        I.SERVIS_KOD = "";
                        I.IS_ENO = "0001";
                        I.CARI_KOD = txtcarikod.Text;
                        I.ARAC_TIP = txtmodel.Text;
                        I.ARAC_MODEL = txtmodelyil.Text;
                        I.SASI_NO = txtsaseno.Text;
                        I.MOTOR_NO = txtmotorno.Text;
                        I.KM = Double.Parse(txtkm.Text);
                        I.PLAKA_NO = txtplakano.Text;
                        I.GARANTI_NO = "";
                        I.ARAC_GIRIS_TRH = DateTime.Parse(dateEdit1.Text);
                        I.ARAC_GIRIS_SAAT = DateTime.Parse(dateEdit1.Text);
                        I.INS_DATE = DateTime.Now;
                        I.PER_KOD = "ADMIN";
                        I.FYILI = 2020;
                        I.AKTARILDI = "H";
                        I.IPTAL = "H";
                        I.KAMPANYA = 0;
                        I.YABANCI_ARAC = "H";
                        I.TEKRAR = "H";
                        I.S = "H";
                        I.YIL = 2020;
                        I.KAPANDI = "H";
                        I.DISPOZ_YAP = "H";
                        I.DEPO_YAP = "H";
                        db.ISEMRI.Add(I);
                        db.SaveChanges();
                        XtraMessageBox.Show("İşemri kaydı başarıyla tamamlandı.","İşlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Information);



                        //Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
                        //txtisemrino.Text = "000" + (ieno + 1).ToString();
                    }
                    else
                    {
                        var caridegerler = db.CARI.SingleOrDefault(a => a.CARI_KOD == txtcarikod.Text);

                        if (caridegerler != null)
                        {

                            

                        }
                        else
                        {
                            CARI c = new CARI();
                            c.CARI_KOD = txtcarikod.Text;
                            c.FIRMA_ADI = txtcariad.Text;
                            var gsm = txtceptel.Text.Substring(0, 5) + txtceptel.Text.Substring(6, 3) + " " + txtceptel.Text.Substring(10, 4);
                            c.TEL3 = gsm;
                            c.WEB_AKTAR = 0;
                            c.INS_DATE = DateTime.Now;
                            c.KAYIT_TRH = DateTime.Now;
                            c.ILETISIM_YOK = "-";
                            c.CARI_GRP_KOD = "K";
                            c.ILI = "İSTANBUL (ASYA)";
                            db.CARI.Add(c);
                            db.SaveChanges();
                            XtraMessageBox.Show("Cari kaydı başarıyla tamamlandı.","İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        

                        //
                        ARAC arc = new ARAC();
                        arc.INS_DATE = DateTime.Now;
                        arc.OTV_TUT = 0;
                        arc.ARAC_BEDEL = 0;
                        arc.OTV = 0;
                        arc.GARANTI_BAS = DateTime.Parse("1899-12-30 00:00:00.000");
                        arc.KDV_SIZ = 0;
                        arc.ATF = 0;
                        arc.PLAKA = txtplakano.Text;
                        arc.CARI_KOD = txtcarikod.Text;
                        if (txtmodelyil.Text != null || txtmodelyil.Text != "")
                        {
                            arc.ARC_MODEL_TRH = short.Parse(txtmodelyil.Text);
                        }
                        else
                        {
                            arc.ARC_MODEL_TRH = 1900;
                        }

                        arc.ARC_MODEL_KODU = txtmodel.Text;
                        arc.MOTOR_NO = txtmotorno.Text;
                        arc.SASE_NO = txtsaseno.Text;
                        db.ARAC.Add(arc);
                        db.SaveChanges();
                        //MessageBox.Show("Araç kaydı başarıyla tamamlandı.");
                        ISEMRI I = new ISEMRI();
                        I.IS_EMRI_NO = txtisemrino.Text;
                        I.IE_TIP = "E";
                        I.SERVIS_KOD = "";
                        I.IS_ENO = "0001";
                        I.CARI_KOD = txtcarikod.Text;
                        I.ARAC_TIP = txtmodel.Text;
                        I.ARAC_MODEL = txtmodelyil.Text;
                        I.SASI_NO = txtsaseno.Text;
                        I.MOTOR_NO = txtmotorno.Text;
                        I.KM = Double.Parse(txtkm.Text);
                        I.PLAKA_NO = txtplakano.Text;
                        I.GARANTI_NO = "";
                        I.ARAC_GIRIS_TRH = DateTime.Parse(dateEdit1.Text);
                        I.ARAC_GIRIS_SAAT = DateTime.Parse(dateEdit1.Text);
                        I.INS_DATE = DateTime.Now;
                        I.PER_KOD = "ADMIN";
                        I.FYILI = 2020;
                        I.AKTARILDI = "H";
                        I.IPTAL = "H";
                        I.KAMPANYA = 0;
                        I.YABANCI_ARAC = "H";
                        I.TEKRAR = "H";
                        I.S = "H";
                        I.YIL = 2020;
                        I.KAPANDI = "H";
                        I.DISPOZ_YAP = "H";
                        I.DEPO_YAP = "H";
                        db.ISEMRI.Add(I);
                        db.SaveChanges();
                        XtraMessageBox.Show("Araç ve İşemri kaydı başarıyla tamamlandı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
                        //txtisemrino.Text = "000" + (ieno + 1).ToString();
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnnewrec_Click(object sender, EventArgs e)
        {
            btnnewrec.Enabled = false;
            simpleButton13.Enabled = false;
            txtkm.Text = "0";
            btnyedekparca.Enabled = false;
            btnisemrisakla.Enabled = true;
            btniptal.Enabled = true;
            txtceptel.Text = "";
            txtmodelyil.Text = "1900";
            txtmodel.Text = "-";
            //------------------
            txtcarikod.Clear();
            txtcariad.Clear();

            txtplakano.Clear();
            txtsaseno.Clear();
            txtmotorno.Clear();
            txtkm.Clear();
            txtcarikod.Enabled = false;
            txtcariad.Enabled = false;
            txtczkod1.Enabled = false;
            txtczkod2.Enabled = false;
            txtczkod3.Enabled = false;
            Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
            txtisemrino.Text = (ieno + 1).ToString();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            btnnewrec.Enabled = true;
            simpleButton13.Enabled = true;

            btnyedekparca.Enabled = true;
            btnisemrisakla.Enabled = false;
            btniptal.Enabled = false;
        }

        private void txtplakano_TextChanged(object sender, EventArgs e)
        {
            txtplakano.Text = txtplakano.Text.ToUpper();
            txtplakano.SelectionStart = txtplakano.Text.Length;
        }

        private void txtcariad_TextChanged(object sender, EventArgs e)
        {
            txtcariad.Text = txtcariad.Text.ToUpper();
            txtcariad.SelectionStart = txtcariad.Text.Length;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            kontrol = "true";
            
            
            txtczkod1.Enabled = true;
            txtczkod2.Enabled = true;
            txtczkod3.Enabled = true;
           // txtmodel.Enabled = true;
            txtmodelyil.Enabled = true;

            Int64 saseno = Int64.Parse(db.ARAC.Select(p => p.SASE_NO).Max().Trim());
            txtsaseno.Text = (saseno + 1).ToString();           

            Int64 ieno = Int64.Parse(db.ISEMRI.Select(p => p.IS_EMRI_NO).Max().Trim());
            txtisemrino.Text = (ieno + 1).ToString();
            
            Frmcarilist frmcrlist = new Frmcarilist();
            frmcrlist.MdiParent = Program.owner;
            frmcrlist.Show();
            
        }

        private void txtcarikod_TextChanged(object sender, EventArgs e)
        {
            var caridegerler = db.CARI.SingleOrDefault(a => a.CARI_KOD == txtcarikod.Text);

            if (caridegerler != null)
            {
                txtcariad.Text = caridegerler.FIRMA_ADI;

                if (String.IsNullOrEmpty(caridegerler.TEL3))
                {
                    txtceptel.Text = "(111)111 1111";
                }
                else
                {
                    txtceptel.Text = caridegerler.TEL3;
                }
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            Frmmodeladd frmmdl = new Frmmodeladd();
            frmmdl.Show();
        }

        private void btnyedekparca_Click(object sender, EventArgs e)
        {
            var isemridegerler = db.ISEMRI.SingleOrDefault(a => a.IS_EMRI_NO == ienodata);

            if (ienodata != null && isemridegerler != null)
            {

                Frmyedekparca frmyp = new Frmyedekparca();
                frmyp.MdiParent = Program.owner;
                frmyp.Show();
            }
            else
            {
                XtraMessageBox.Show("Sadece Yeni Bir Kayıt Oluştururduktan Sonra Yedekparça Ekleyebilirsin..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}

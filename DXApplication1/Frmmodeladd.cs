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
    public partial class Frmmodeladd : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmmodeladd()
        {
            InitializeComponent();
        }

        private void Frmmodeladd_Load(object sender, EventArgs e)
        {
            this.gridView1.OptionsView.ShowGroupPanel = false; // kolon başlıklarının üzerinde bir gruplama alanı açar
            this.gridView1.OptionsView.ShowFooter = true; // alt toplam gibi bilgileri gösterilebilmesi için en alta bir alan açar
            this.gridView1.OptionsBehavior.Editable = false;// gridview hücre focuslanmasını iptal eder. 
                                                            //Gird üzerinden ekle güncelle işlemi yapacaksanız bunu açarsınız.
            var veri = (from x in db.MODEL
                        orderby (x.ARC_MODEL_KODU) ascending
                        select new
                        {
                            Model_Kod = x.ARC_MODEL_KODU,
                            Model_Adı = x.ARC_MODEL_ADI,
                            

                        }).ToList();



            this.gridControl1.DataSource = veri;
        }

        private void btniecarisec_Click(object sender, EventArgs e)
        {
            var mdldegerler = db.MODEL.SingleOrDefault(a => a.ARC_MODEL_KODU == txtmdlkod.Text);

            if (mdldegerler != null)
            {

                XtraMessageBox.Show("Kaydetmek istediğiniz"+" "+"" + txtmdlkod.Text + ""+" "+"kod sistemde tanımlı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MODEL m = new MODEL();
                m.ARC_MODEL_KODU = txtmdlkod.Text;
                m.ARC_MODEL_ADI = txtmdlad.Text;
                db.MODEL.Add(m);
                db.SaveChanges();
                if ((XtraMessageBox.Show("Model kaydı başarıyla tamamlandı.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)) == DialogResult.OK)
                {
                    this.Close();
                }
               
            }
                
        }
    }
}

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
    public partial class Frmnewstok : Form
    {
        EROTO2020Entities db = new EROTO2020Entities();
        public Frmnewstok()
        {
            InitializeComponent();
        }

        private void xtraTabPage8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void Frmnewstok_Load(object sender, EventArgs e)
        {
            txtstdate.Text = DateTime.Now.ToString();
            double stno = db.STOK.Select(p => p.STOK_NO).Max();
            txtstno.Text = (stno + 1).ToString();
            txtstpno.Text = "P000000" + (stno + 1).ToString();
        }

        private void btnnwskapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnwskaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtstad.Text))
            {

                XtraMessageBox.Show("Gerekli Alanları Doldurun..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                STOK st = new STOK();
                st.STOK_NO = double.Parse(txtstno.Text);
                st.STOK_KOD_NO = txtstpno.Text;
                st.STOK_ADI_TR = txtstad.Text;
                st.KDV = int.Parse(txtstkdv.Text);
                st.FYT_KUR = txtstdoviz.Text;
                st.SAT_FYT_TL = double.Parse(txtstfyt.Text);
                st.SAT_FYT_DOVIZ = double.Parse(txtstfyt.Text);
                st.INS_DATE = DateTime.Parse(txtstdate.Text);
                st.ACILIS_TRH = DateTime.Parse(txtstdate.Text);
                st.PAY = txtanagrup.Text;
                st.MERKEZ = 0;
                st.BARK_TIP = "E";
                st.BIRIMI = txtstbirim.Text;
                db.STOK.Add(st);
                db.SaveChanges();
                
                if (XtraMessageBox.Show("Stok kaydı başarıyla tamamlandı...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }



            }
            
        }
    }
}

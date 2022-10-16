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
    public partial class Frmlogin : DevExpress.XtraEditors.XtraForm
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtkpw.Text == "1")
            {
                this.Hide();
                Frmmain anaform = new Frmmain();
                anaform.Show();
            }
            else
            {
                XtraMessageBox.Show("Geçersiz Şifre veya Kullanıcı Adı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtkpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (txtkpw.Text == "1")
                {
                    this.Hide();
                    Frmmain anaform = new Frmmain();
                    anaform.Show();
                }
                else
                {
                    XtraMessageBox.Show("Geçersiz Şifre veya Kullanıcı Adı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
    }
}

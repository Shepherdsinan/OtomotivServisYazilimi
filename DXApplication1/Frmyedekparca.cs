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
    public partial class Frmyedekparca : Form
    {
        public Frmyedekparca()
        {
            InitializeComponent();
        }
        EROTO2020Entities db = new EROTO2020Entities();
        DataTable table;
        DataTable tablo = new DataTable();
        public static string plakayp;
        private void Frmyedekparca_Load(object sender, EventArgs e)
        {
            

            Frmnewisemri z = (Frmnewisemri)Application.OpenForms["Frmnewisemri"];

            int ienumber = int.Parse(z.txtisemrino.Text);
            txtypieno.Text = ienumber.ToString();

            
            try
            {

                //-------------datastoklist----------//
                datastokdoldur();
                //------------datagird1--------------//
                tablo.Columns.Add("S.No", typeof(string));
                tablo.Columns.Add("Parça Kod", typeof(string));
                tablo.Columns.Add("Parça Adı", typeof(string));
                tablo.Columns.Add("Fiyat", typeof(string));
                tablo.Columns.Add("İsk%", typeof(string));
                tablo.Columns.Add("Depo", typeof(string));
                tablo.Columns.Add("Miktar", typeof(string));
                tablo.Columns.Add("SonÇıkan", typeof(string));
                tablo.Columns.Add("T.Çıkan", typeof(string));
                tablo.Columns.Add("Kalan", typeof(string));
                tablo.Columns.Add("Top.Tut.", typeof(string));
                tablo.Columns.Add("İsk.luTut", typeof(string));
                tablo.Columns.Add("Kdv", typeof(string));
                tablo.Columns.Add("İsk.luKdv.liTutar", typeof(string));
                tablo.Columns.Add("Teslim Trh", typeof(string));
                tablo.Columns.Add("Açıklama", typeof(string));
                tablo.Columns.Add("Sno", typeof(string));
                gridControl1.DataSource = tablo;

                gridView1.Columns[0].Width = 35;
                gridView1.Columns[1].Width = 150;
                gridView1.Columns[2].Width = 250;
                gridView1.Columns[3].Width = 60;
                gridView1.Columns[4].Width = 40;
                gridView1.Columns[5].Width = 60;
                gridView1.Columns[6].Width = 60;
                gridView1.Columns[7].Width = 60;
                gridView1.Columns[8].Width = 60;
                gridView1.Columns[9].Width = 60;
                gridView1.Columns[10].Width = 150;
                gridView1.Columns[11].Width = 60;
                gridView1.Columns[12].Width = 40;
                gridView1.Columns[13].Width = 70;
                gridView1.Columns[16].Width = 5;

                gridView1.Columns["Top.Tut."].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Top.Tut.", "Toplam: {0:C2}");

                //gridView1.Columns[""].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                //gridView1.Columns["Top.Tut."].SummaryItem.DisplayFormat = "{0:N2}";
                //gridView1.Columns["Top.Tut."].SummaryItem.Tag = 1;

                
                //-----------------datagird1------------------//
                var deger = db.ISEMRI.Where(x => x.IS_EMRI_NO == txtypieno.Text).Count();

                if (deger != 0)
                {
                    ISEMRI degerler = db.ISEMRI.OrderByDescending(x => x.IS_EMRI_NO).ThenByDescending(x => x.ID)
                        .FirstOrDefault(a => a.IS_EMRI_NO == txtypieno.Text);

                    txtypgrstrh.Text = degerler.ARAC_GIRIS_TRH.ToString();

                    txtypietip.Text = degerler.IE_TIP;
                    txtypkm.Text = degerler.KM.ToString();
                    txtypsasi.Text = degerler.SASI_NO;
                    txtypmtrno.Text = degerler.MOTOR_NO;
                    txtypplaka.Text = degerler.PLAKA_NO;


                    var caridegerler = db.CARI.SingleOrDefault(a => a.CARI_KOD == degerler.CARI_KOD);
                    txtypfirmad.Text = caridegerler.FIRMA_ADI;


                    var modeldegerler = db.MODEL.SingleOrDefault(a => a.ARC_MODEL_KODU == degerler.ARAC_TIP);

                    txtyptip.Text = modeldegerler.ARC_MODEL_KODU;
                    txtypmodel.Text = modeldegerler.MODEL1;

                    txtypmodelyil.Text = degerler.ARAC_MODEL;




                }



            }
            catch (Exception exp)
            {

                XtraMessageBox.Show(exp.ToString());
            }
        }
        public void datastokdoldur()
        {
            //------------datastoklist---------------//

            table = new DataTable();

            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Parça Kodu", typeof(string));
            table.Columns.Add("ParçaAdı", typeof(string));
            table.Columns.Add("Parça Adı(ING)", typeof(string));
            table.Columns.Add("Birimi", typeof(string));
            table.Columns.Add("Sat.Fyt.TL", typeof(string));
            table.Columns.Add("Sat.Fyt.Dvz", typeof(string));
            table.Columns.Add("Döviz", typeof(string));
            table.Columns.Add("Kdv", typeof(string));
            table.Columns.Add("Sno", typeof(int));


            foreach (var entity in db.STOK)
            {
                var row = table.NewRow();
                row["Marka"] = entity.MARKAKOD;
                row["Parça Kodu"] = entity.STOK_KOD_NO;
                row["ParçaAdı"] = entity.STOK_ADI_TR;
                row["Parça Adı(ING)"] = entity.STOK_ADI_ING;
                row["Birimi"] = entity.BIRIMI;
                row["Sat.Fyt.TL"] = entity.SAT_FYT_TL;
                row["Sat.Fyt.Dvz"] = entity.SAT_FYT_DOVIZ;
                row["Döviz"] = entity.FYT_KUR;
                row["Kdv"] = entity.KDV;
                row["Sno"] = entity.STOK_NO;
                table.Rows.Add(row);
            }

            dtstoklist.DataSource = table;
            dtstoklist.Columns[0].Width = 50;
            dtstoklist.Columns[1].Width = 50;
            dtstoklist.Columns[2].Width = 170;
            dtstoklist.Columns[3].Width = 110;
            dtstoklist.Columns[4].Width = 40;
            dtstoklist.Columns[5].Width = 40;
            dtstoklist.Columns[6].Width = 30;
            dtstoklist.Columns[7].Width = 30;
            dtstoklist.Columns[8].Width = 40;
            dtstoklist.Columns[9].Width = 5;
        }

        private void txtypara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "ParçaAdı LIKE '" + txtypara.Text + "%'";

            datastokdoldur();
            dtstoklist.DataSource = dv;
            
        }

        private void btnypclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dtstoklist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtstoklist.SelectedCells.Count > 0)
            {
                int say = gridView1.RowCount;
                int selectedrowindex = dtstoklist.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtstoklist.Rows[selectedrowindex];
                Int64 a = Convert.ToInt64(selectedRow.Cells["Sno"].Value);
                var qery1 = db.STOK.FirstOrDefault(x => x.STOK_NO == a);
                tablo.Rows.Add(gridView1.RowCount + 1, qery1.STOK_KOD_NO, qery1.STOK_ADI_TR, qery1.SAT_FYT_TL, 0, 1, 1, 1, 1, 0, qery1.SAT_FYT_TL * 1, 0, qery1.KDV, 0, DateTime.Now, "", qery1.STOK_NO);
                gridControl1.DataSource = tablo;

                
            }
        }

        private void btnypsakla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                ISEAYRIN ypnerw = new ISEAYRIN();
                ypnerw.ISEMRI_NO = txtypieno.Text;
                ypnerw.SIRANO = short.Parse(gridView1.GetRowCellValue(i,"S.No").ToString());
                ypnerw.STOK_NO = Int64.Parse(gridView1.GetRowCellValue(i,"Sno").ToString());
                ypnerw.YEDEK_P_ADI = gridView1.GetRowCellValue(i,"Parça Adı").ToString();
                ypnerw.STOK_KOD_NO = gridView1.GetRowCellValue(i,"Parça Kod").ToString();
                ypnerw.STOK_MIKTAR = Int64.Parse(gridView1.GetRowCellValue(i,"Miktar").ToString());
                ypnerw.VERILEN_MIKTAR = Int64.Parse(gridView1.GetRowCellValue(i,"SonÇıkan").ToString());
                ypnerw.TESLIM_MIKTAR = Int64.Parse(gridView1.GetRowCellValue(i,"Kalan").ToString());
                ypnerw.STOK_FIYATI = Convert.ToDouble(gridView1.GetRowCellValue(i,"Top.Tut.").ToString());
                var kdv = gridView1.GetRowCellValue(i,"Kdv").ToString();
                if (kdv == null || kdv == string.Empty)
                {
                    ypnerw.KDV = 0;
                }
                else
                {
                    ypnerw.KDV = Int64.Parse(gridView1.GetRowCellValue(i,"Kdv").ToString());
                }

                ypnerw.FYT_USD = 0;
                ypnerw.GARANTI_TIPI = "M";
                ypnerw.TESLIM_TRH = DateTime.Now;
                ypnerw.FYILI = 2020;
                ypnerw.DEPO_KODU = "1";
                ypnerw.INS_DATE = DateTime.Now;
                db.ISEAYRIN.Add(ypnerw);
                db.SaveChanges();
                //----Parça Toplamı Update---//
                double toptutdata = Double.Parse(gridView1.Columns["Top.Tut."].SummaryItem.SummaryValue.ToString());
                var zx = db.ISEMRI.Where(x => x.IS_EMRI_NO == txtypieno.Text).FirstOrDefault();
                zx.PAR_TOP_TUTAR = toptutdata;
                zx.TOP_TUTAR = toptutdata;
                zx.ARA_TUT = toptutdata;
                zx.NET_TUT = toptutdata;

                db.SaveChanges();

                //----Parça Toplamı Update---//
                
                btnypsakla.Enabled = false;
                


            }
            if((XtraMessageBox.Show("İşemri Yedek Parça kaydı başarıyla tamamlandı.","İşlem Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Information)) == DialogResult.OK)
            {
                this.Close();
            }
        }

        

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //double toplam = 0;
            //for (int i = 0; i < gridView1.; ++i)
            //{
            //    dataGridView1.Rows[i].Cells[10].Value = dataGridView1.Rows[i].Cells[3].Value.ToString(); 
            //    var x = dataGridView1.Rows[i].Cells[10].Value.ToString();
            //    if (x == null || x == string.Empty)
            //    {
            //        toplam += 0;
            //    }
            //    else
            //    {
            //        toplam += Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
            //    }

            //}
            //label24.Text = toplam.ToString();

        }

        private void txtypara_MouseClick(object sender, MouseEventArgs e)
        {
            txtypara.Clear();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            plakayp = txtypplaka.Text;
            if (plakayp != null)
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
    }
}

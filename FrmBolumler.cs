using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi1
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);




            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu !!");
            }




        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1",bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata ! İşlem Gerçekleşmedi.");
            }
        }
        int secilen; // Tıklandığında hafızaya alınan hücre(satır) değeri
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumid.Text = id;
            txtBolumAd.Text = bolumad;

        }

        

        private void pcbBolumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set Bolumad=@p1 where Bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtkayitDataSet.Bolumler);


            }
            catch (Exception)
            {

                MessageBox.Show("Hata ! İşlem Gerçekleşmedi.");
            }
        }

        private void txtBolumAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

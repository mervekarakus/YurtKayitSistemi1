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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayitDataSet4.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtkayitDataSet4.Borclar);
            // TODO: Bu kod satırı 'yurtkayitDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtkayitDataSet3.Borclar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();


            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;
            txtOgrenciid.Text = id;


        }


        private void btnOdemeAl_Click_1(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan tutardan düşme işlemi

            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalanBorc.Text);
            yeniborc = kalan - odenen;
            txtKalanBorc.Text = yeniborc.ToString();

            //Yeni tutarı güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc= @p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrenciid.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtkayitDataSet3.Borclar);

            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values(@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}

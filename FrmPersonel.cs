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
using System.Security.Cryptography;

namespace YurtKayitSistemi1
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayitDataSet10.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtkayitDataSet10.Personel);

        }

        

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelAd.Text = ad;
            txtPersonelGorev.Text = gorev;
            txtPersonelid.Text = id;
        }

      

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti()); ;
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi.");
            this.personelTableAdapter.Fill(this.yurtkayitDataSet10.Personel);
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");
            this.personelTableAdapter.Fill(this.yurtkayitDataSet10.Personel);
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelid.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı.");
            this.personelTableAdapter.Fill(this.yurtkayitDataSet10.Personel);
        }
    }
}

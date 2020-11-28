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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();


        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        { 
            // Kasadaki parayı ekrana getirme

            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblPara.Text = oku[0].ToString() + "  TL" ;

            }
            bgl.baglanti().Close();

            //Tekrarsız olarak ayları listeleme
            //Sql'de komutların tekrarsız gelmesi içim kullanılan komut Distinct

            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa",bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while(oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();


            //Aylık kazançları manuel olarak ekleme
            //this.chart1.Series["Aylık"].Points.AddY(15);//addxy("Nisan",15);
            //this.chart1.Series["Aylık"].Points.AddY(22);
            //this.chart1.Series["Aylık"].Points.AddY(13);

            //Grafiklere veritabanından veri çekme


            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0],oku3[1]);
            }
            bgl.baglanti().Close();

        }
       
       

        private void cmbAy_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            //Seçilen aya göre kazancı listeleme
            SqlCommand komut = new SqlCommand("Select sum(OdemeMiktar) from Kasa where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAyKazanc.Text = oku[0].ToString();



            }
            bgl.baglanti().Close();

        }
    }
}

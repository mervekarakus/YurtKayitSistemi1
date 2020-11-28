﻿using System;
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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTc.Text);
                komut.Parameters.AddWithValue("@p5", msktelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogum.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdano.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı.");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata !");
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {

            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");



            //Odanın aktif öğrenci sayısı azaltma


            SqlCommand komutoda = new SqlCommand("update Odalar1 set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbOdano.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        //Öğrenci Silme İşlemi
        

        public string mail, odano, veliad, velitel, adres;

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

      
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTc.Text = TC;
            msktelefon.Text = telefon;
            mskDogum.Text = dogum;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdano.Text = odano;
            txtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            rchAdres.Text = adres;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

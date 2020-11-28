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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string id,elektrik, su, dogalgaz, gida, diger, internet, personel;

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gida=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());


            try
            {
                komut.Parameters.AddWithValue("@p8", txtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı.");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata !");
            }


        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderid.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtGida.Text = gida;
            txtDogalgaz.Text = dogalgaz;
            txtDiger.Text = diger;
            txtInternet.Text = internet;
            txtPersonel.Text = personel;

        }
    }

       
          
    }


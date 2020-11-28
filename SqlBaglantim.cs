using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi1
{
    public class SqlBaglantim //Sql bağlantı sınıfı
    {
        public SqlConnection baglanti() // Sql bağlantı metodu
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-TJ7PS5Q;Initial Catalog=Yurtkayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        
        }

    }
}

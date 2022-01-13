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

namespace veriTabaniBaglantisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SQL bağlantısı oluşturma. 
        /* 
         Data Source= Server Adı ;Initial Catalog=Veri tabanı adı;User ID=Kullanıcı Adı;Password=Şifre
         
         */
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=_hasankaya;User ID=hasankaya;Password=123");


        private void Form1_Load(object sender, EventArgs e)
        {

            int sayac = 0;
            // her işlemden önce bağlantıyı aç ve kapat.
            conn.Open(); // veri tabanı bağlantısını açar
            SqlCommand kmt = new SqlCommand("SELECT * FROM test",conn); //sol tarafa sorgu virgülden sonra bağlantı adı
            SqlDataReader okunanVeriler = kmt.ExecuteReader(); //SqlDataReader'a SqlCommandın verilerini bağladık.

            while(okunanVeriler.Read()) // verileri okuduk.
            {
                MessageBox.Show("ID:"+okunanVeriler["id"].ToString()+" Adı:"+" "+okunanVeriler["ad"].ToString()); //gelen verileri ekrana bastık.
                sayac++;
            }
            MessageBox.Show("Sayaç:"+sayac.ToString());

         

            conn.Close(); // veri tabanı bağlantısını kapatır.
        }
    }
}

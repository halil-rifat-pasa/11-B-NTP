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

namespace kullanici_islemle
{
    public partial class kullanici : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_test;Persist Security Info=True;User ID=testUser;Password=123");
        public kullanici()
        {
            InitializeComponent();
        }


        string kullaniciadi = "";
        string sifre = "";
        string adi = "";
        string soyadi = "";
        int id = 0;

        private void kullanici_Load(object sender, EventArgs e)
        {


            kullaniciadi = girisFormu.kullaniciAdi;
            sifre = girisFormu.sifre;


            textBox4.Text = kullaniciadi;
            textBox5.Text = sifre;
            
            
            conn.Open();

            SqlCommand getir = new SqlCommand("SELECT * FROM kullanicilar WHERE kullanici_adi = '" + kullaniciadi + "' ", conn);
            SqlDataReader oku = getir.ExecuteReader();

            while (oku.Read())
            {
                adi = oku["adi"].ToString();
                soyadi = oku["soyadi"].ToString();
                id = Convert.ToInt32(oku["kullanici_id_PK"]);
            }

            textBox1.Text = id.ToString();
            textBox2.Text = adi;
            textBox3.Text = soyadi;

            conn.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE kullanicilar SET adi = '"+textBox2.Text+"', soyadi = '"+textBox3.Text+"' , kullanici_adi = '"+textBox4.Text+"', kullanici_sifre = '"+textBox5.Text+"' WHERE kullanici_id_PK = '"+textBox1.Text+"' ", conn);
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncelledim");
        }
    }
}

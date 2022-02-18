using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_proje
{
    public partial class girisFormu : Form
    {
        public girisFormu()
        {
            InitializeComponent();
        }

        public static SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_test;User ID=testUser;Password=123");


        private void girisFormu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool girisKontrol = false;
            bool kullaniciYetki = false;

            conn.Open();

            SqlCommand kmt = new SqlCommand("SELECT * FROM kullanicilar",conn);
            SqlDataReader oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                if (oku["kullanici_adi"].ToString() == textBox1.Text && oku["kullanici_sifre"].ToString() == textBox2.Text)
                {
                    girisKontrol = true;
                    kullaniciYetki = Convert.ToBoolean(oku["kullanici_yetki"]);
                }
            }


            if (girisKontrol == true)
            {
                if (kullaniciYetki == true)
                {
                    adminEkrani adm = new adminEkrani();
                    this.Hide();
                    adm.ShowDialog();
                }
                else 
                {
                    kullaniciEkrani kln = new kullaniciEkrani();
                    this.Hide();
                    kln.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Kullanıcı Bulunamadı..");
            
            }


            conn.Close();
        }
    }
}

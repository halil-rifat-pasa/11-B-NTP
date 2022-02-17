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
    public partial class girisFormu : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_test;Persist Security Info=True;User ID=testUser;Password=123");



        public girisFormu()
        {
            InitializeComponent();
        }


        public static string kullaniciAdi = "";
        public static string sifre = "";

        private void button1_Click(object sender, EventArgs e)
        {

            bool loginKontrol = false;
            conn.Open();

            SqlCommand komut = new SqlCommand("SELECT kullanici_adi,kullanici_sifre FROM kullanicilar",conn);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (textBox1.Text == oku["kullanici_adi"].ToString() && textBox2.Text == oku["kullanici_sifre"].ToString())
                {
                    loginKontrol = true;
                }
            }


            if (loginKontrol == true)
            {

                kullaniciAdi = textBox1.Text;
                sifre = textBox2.Text;

                //giriş var. form aç
                kullanici kln = new kullanici();
                this.Hide();
                kln.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }

            conn.Close();
        }
    }
}

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
    public partial class yeniKayitForm : Form
    {
        public yeniKayitForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_test;Persist Security Info=True;User ID=testUser;Password=123");

        private void yeniKayitForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kullaniciKontrolu = true;


            conn.Open();
            SqlCommand kullaniciBul = new SqlCommand("SELECT kullanici_adi FROM kullanicilar",conn);
            SqlDataReader oku = kullaniciBul.ExecuteReader();

            while (oku.Read())
            {
                if (oku["kullanici_adi"].ToString() == kullaniciAdiTextBox.Text) 
                {
                    kullaniciKontrolu = false;
                }
            }

            conn.Close();



            if (kullaniciKontrolu == true)
            {
                //kullanıcıyı kaydettim..
                conn.Open();
                SqlCommand kullaniciKaydet = new SqlCommand("INSERT INTO kullanicilar(adi,soyadi,kullanici_adi,kullanici_sifre) VALUES('" + adiTextBox.Text + "','" + soyadiTextBox.Text + "','" + kullaniciAdiTextBox.Text + "','" + KullaniciSifreTextBox.Text + "')", conn);
                kullaniciKaydet.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kullanıcı Sisteme Eklendi ..");

            }
            else {
                MessageBox.Show("Böyle bir kullanıcı var ..");
            }



          
        }
    }
}

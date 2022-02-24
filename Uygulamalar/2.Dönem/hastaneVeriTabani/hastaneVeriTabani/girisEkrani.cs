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

namespace hastaneVeriTabani
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }


        public static SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=__hastaneVT;User ID=testUser;Password=123");



        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool loginKontrolu = false; //false ise giriş yok. True giriş var.

            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_personeller", conn);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text == oku["personel_sistem_kullanici_adi"].ToString() && textBox2.Text == oku["personel_sistem_kullanici_sifre"].ToString())
                {
                    loginKontrolu = true;
                }
            }


            if (loginKontrolu == false)
            {
                label4.Text = "Hata: Kullanıcı Bulunamadı ...";
                label4.Visible = true;
            }
            else {
                MessageBox.Show("Giriş Yapıldı");
            
            }


            conn.Close();
        }

        private void _kullaniciBilgisiGirme(object sender, KeyPressEventArgs e)
        {
           
        }

        private void butonAcKapat(object sender, KeyEventArgs e)
        {
            label4.Visible = false;
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}

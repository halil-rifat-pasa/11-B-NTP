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

namespace veritabani_islemleri_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_hasankaya;User ID=hasankaya;Password=123");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM tbl_kullanicilar",conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string kullaniciBilgileri = "Adı Soyadı:" + oku["adi"].ToString() + " " + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullaniciBilgileri);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            //çalışır
            SqlCommand ekleSorgusu = new SqlCommand("INSERT INTO tbl_kullanicilar(adi,soyadi,kullanici_adi,kullanici_sifre) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')",conn);


            //çalışmaz
            //SqlCommand ekleSorgusu2 = new SqlCommand("INSERT INTO tbl_kullanicilar VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
            ekleSorgusu.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Kullanıcı Eklendi !!!!");

            conn.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM tbl_kullanicilar", conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string kullaniciBilgileri = "Adı Soyadı:" + oku["adi"].ToString() + " " + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullaniciBilgileri);
            }
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE tbl_kullanicilar SET adi = '"+textBox8.Text+"', soyadi='"+textBox7.Text+"', kullanici_sifre = '"+textBox5.Text+"' WHERE kullanici_adi = '"+textBox6.Text+"'",conn);
            guncelle.ExecuteNonQuery();
            conn.Close();



            listBox1.Items.Clear();
            conn.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM tbl_kullanicilar", conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string kullaniciBilgileri = "Adı Soyadı:" + oku["adi"].ToString() + " " + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullaniciBilgileri);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM tbl_kullanicilar WHERE kullanici_adi = '"+textBox9.Text+"'",conn);
            sil.ExecuteNonQuery();
            conn.Close();


            listBox1.Items.Clear();
            conn.Open();
            SqlCommand listele = new SqlCommand("SELECT * FROM tbl_kullanicilar", conn);
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                string kullaniciBilgileri = "Adı Soyadı:" + oku["adi"].ToString() + " " + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullaniciBilgileri);
            }
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            conn.Open();
            SqlCommand ozelListele = new SqlCommand("SELECT * FROM tbl_kullanicilar WHERE kullanici_adi = '"+textBox10.Text+"'",conn);
            SqlDataReader oku = ozelListele.ExecuteReader();

            while (oku.Read())
            {
                 string kullaniciBilgileri = "Adı Soyadı:" + oku["adi"].ToString() + " " + oku["soyadi"].ToString() + " Kullanıcı Adı:" + oku["kullanici_adi"].ToString();
                listBox1.Items.Add(kullaniciBilgileri);
            }

            conn.Close();
        }
    }
}

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

namespace _otelProje
{
    public partial class odaKayit : Form
    {
        public odaKayit()
        {
            InitializeComponent();
        }

        public static bool odaDurum = false;
        public bool kayitVarMi = false;

        private void odaKayit_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.seciliOda;

            Form1.conn.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_musteriler",Form1.conn);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (oku["oda_no"].ToString() == textBox1.Text) 
                {
                    textBox2.Text = oku["musteri_adi"].ToString();
                    textBox3.Text = oku["musteri_soyadi"].ToString();
                    textBox4.Text = oku["musteri_telefon"].ToString();
                    textBox5.Text = oku["musteri_tc"].ToString();
                    kayitVarMi = true;
                    button2.Visible = true;
                
                
                }
            }


            Form1.conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bosVeriVarMi = false;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox) 
                {
                    if (x.Text.Length == 0) 
                    {
                        bosVeriVarMi = true;
                    }
                }
            }

            if (bosVeriVarMi == true)
            {
                MessageBox.Show("Boş Alan Olamaz.");
            }
            else 
            {
                Form1.conn.Open();
                if (kayitVarMi == true)
                {
                    SqlCommand komut = new SqlCommand("UPDATE tbl_musteriler SET musteri_adi = '"+textBox2.Text+"', musteri_soyadi = '"+textBox3.Text+"', musteri_telefon = '"+textBox4.Text+"', musteri_tc = '"+textBox5.Text+"' WHERE oda_no = '"+textBox1.Text+"'", Form1.conn);
                    komut.ExecuteNonQuery();
                }
                else 
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO tbl_musteriler(oda_no,musteri_adi,musteri_soyadi,musteri_telefon,musteri_tc) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", Form1.conn);
                    komut.ExecuteNonQuery();
                
                }



                Form1.conn.Close();
                odaDurum = true;

                MessageBox.Show("Tebrikler ! Odanız Oldu :D ");
                this.Close();
            }




           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //silme yapılacak.
            Form1.conn.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM tbl_musteriler WHERE oda_no = '"+textBox1.Text+"'",Form1.conn);
            komut.ExecuteNonQuery();
            Form1.conn.Close();
            MessageBox.Show("Silme İşlemi Başarılı ! ");
        }
    }
}

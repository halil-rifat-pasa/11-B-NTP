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

        private void odaKayit_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.seciliOda;
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
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_musteriler(oda_no,musteri_adi,musteri_soyadi,musteri_telefon,musteri_tc) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')", Form1.conn);
                komut.ExecuteNonQuery();
                Form1.conn.Close();
                odaDurum = true;

                MessageBox.Show("Tebrikler ! Odanız Oldu :D ");
                this.Close();
            }




           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classVeFonksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        class ogrenciler
        {
            public string isim;
            public string soyad;

            public double sinav1;
            public double sinav2;
            public double ortalama;


            public int[] sayilar = new int[50];

            public void notHesapla() {
                this.ortalama = (this.sinav1 + this.sinav2) / 2;
            }


            public string adSoyadYazdir() {
                this.notHesapla();
                return "Hoşgeldiniz "+this.isim + " " + this.soyad+" Ortalamanız: "+ortalama.ToString();
            }


            public void msgBoxMesajYazdir(string mesaj) {
                MessageBox.Show(mesaj);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();

            ogr.isim = textBox1.Text;
            ogr.soyad = textBox2.Text;
            ogr.sinav1 = Convert.ToDouble(textBox3.Text);
            ogr.sinav2 = Convert.ToDouble(textBox4.Text);


            string mesaj = ogr.adSoyadYazdir();
            listBox1.Items.Add(mesaj);

            ogr.msgBoxMesajYazdir(mesaj);
            //MessageBox.Show(mesaj);

        }
    }
}

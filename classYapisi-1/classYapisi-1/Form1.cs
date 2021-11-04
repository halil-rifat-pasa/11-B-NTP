using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classYapisi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MesajYazdir(string mesaj) {
            MessageBox.Show("İşlem Sonucu: "+mesaj);
        }

        string hataMesajlari(string hataKodu) {

            if (hataKodu == "500") {
                return "İlk Sayı en az 1 olmalıdır.";
            }
            else if (hataKodu == "501")
            {
                return "İkinci Sayı en az 1 olmalıdır.";
            }
            else {
                return "Hata Kodu Bulunamadı";
            }
        
        }

        bool sayiKontrol(double x, double y) {
            if (x <= 0)
            {
                MessageBox.Show(hataMesajlari("500"));
                return false;
            }
            else if (y <= 0)
            {
                MessageBox.Show(hataMesajlari("501"));
                return false;
            }
            else {
                return true;
            }
        }

        double islemYap(int x, int y, string islem ) {
            if (islem == "+") { return x + y; }
            else if (islem == "-") { return x - y; }
            else if (islem == "*") { return x * y; }
            else if (islem == "/") { return x / y; }
            else { return 0; }
        }


        void sayilariTopla(int s1,int s2) {
            if (sayiKontrol(s1, s2) == true)
            {
                double toplam = islemYap(s1, s2, "+");
                MesajYazdir(toplam.ToString());
            }
            
        }

        void sayilariCikart(int sayi1, int sayi2) {
            if (sayiKontrol(sayi1, sayi2) == true) {

                double cikart = islemYap(sayi1, sayi2, "-"); ;
                MesajYazdir(cikart.ToString());

            }
          
        }

        void sayilariCarp(int sayi1,int sayi2) {
           if (sayiKontrol(sayi1, sayi2) == true) {
                double carp = islemYap(sayi1, sayi2, "*");
                MesajYazdir(carp.ToString());
           }
        }

        void sayilariBol(int x, int y) {
           if (sayiKontrol(x, y) == true) {
                 double bol = islemYap(x, y, "/");
                 MesajYazdir(bol.ToString());
           }
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            sayilariTopla(sayi1,sayi2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayilariCikart(Convert.ToInt16(textBox3.Text),Convert.ToInt16(textBox4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayilariCarp(Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayilariBol(Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text)); ;
        }
    }
}

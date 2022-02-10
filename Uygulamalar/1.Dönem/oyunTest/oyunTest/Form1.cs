using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyunTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 10 sayısını oluşturduk (rasgele). 5 -> sayı 5- 100 arasındadır. tekrar dene. 7 - 100 arasındadır. 6 sayı 7-100 arasında. 3 hakkı olucak. 


        // random nesnesinden üretilen ilk sayı..
        int bulunacakSayi = 0;

        //kullanıcının girdiği sayıdır.
        int girilenSayi = 0;

        //kullanıcının hakkı
        int kullaniciHak = 3;

        int minDeger = 0;
        int maxDeger = 100;



        //hakları yazdırmak için bir fonksiyon..
        void hakYazdir(int hak) {
            label3.Text = "Hakkınız: " + hak;
        }

        void oyunuBaslat() {
            kullaniciHak = 3;
            bulunacakSayi = sayiUret();
            hakYazdir(kullaniciHak);
            label2.Text = bulunacakSayi.ToString();
        }

        int sayiUret() {
            Random x = new Random();
            maxDeger = x.Next(0, 100);
            return maxDeger;
        }

        void hakEksilt(int girilenSayi)
        {
            kullaniciHak = kullaniciHak - 1;
            hakYazdir(kullaniciHak);
            aralikBelirle(girilenSayi);

            if (kullaniciHak == 0)
            {
                DialogResult x = MessageBox.Show("Oyunu Kaybettiniz. \n Yeni Oyuna başlamak ister misin ?", "Yeni Oyuna Başla", MessageBoxButtons.OKCancel);

                if (x == DialogResult.OK) {
                    oyunuBaslat();
                }
                else {
                    button1.Enabled = false;
                }
                
            }
            else {
                MessageBox.Show("Sayıyı Bilemediniz. Sayı Şu aralıklarda "+minDeger+" - "+maxDeger);
            }
        
        }

        void aralikBelirle(int yazilanSayi) {

            if (girilenSayi > maxDeger) {
                maxDeger = girilenSayi;
            }else if(girilenSayi > minDeger){
                minDeger = girilenSayi;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girilenSayi = Convert.ToInt32(textBox1.Text);

            if (girilenSayi == bulunacakSayi)
            {
                MessageBox.Show("Tebrikler Kazandınız");
            }
            else {

                hakEksilt(girilenSayi);
            }
        }


    }
}

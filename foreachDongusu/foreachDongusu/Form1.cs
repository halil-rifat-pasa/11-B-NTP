using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreachDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void testFonksiyon() {
            int[] sayilar = new int[5] { 1, 2, 3, 4, 5 };
            string[] isimler = new string[2] { "Hasan", "Kaya" };

            foreach (string isim in isimler)
            {
                MessageBox.Show(isim);
            }



            //foreach(değişken in dizi adı){}
            foreach (int sayi in sayilar)
            {
                MessageBox.Show("Foreach Döngüsü Sayılar:" + sayi.ToString());
            }

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("For Döngüsü Sayılar: " + sayilar[i].ToString());
            }
        
        }


        int[] sayilar = new int[100];
        private void Form1_Load(object sender, EventArgs e)
        {
           
            int sayac = 0;

            //random sayıları diziye atma.
            Random x = new Random();
            while (sayac < 100)
            {
                int randomSayi = x.Next(0, 1000);
                if (sayilar.Contains(randomSayi) == false) {
                    sayilar[sayac] = randomSayi;
                    listBox1.Items.Add(sayilar[sayac]);
                    sayac++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sıralama işlemleri
            int[] siraliDizi = new int[100];


            for (int i = 0; i < 100; i++ )
            {
                int mevcutSayi = sayilar[i];
               
                for (int j = i; j < 100; j++)
                {
                 
                    if (sayilar[i] > sayilar[j])
                    {
                        int gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }
            }


            for (int i = 0; i < 100; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }
        }
    }
}

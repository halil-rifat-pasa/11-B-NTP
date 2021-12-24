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


                    if (randomSayi % 2 == 0)
                    {
                        listBox3.Items.Add(sayilar[sayac]);
                    }
                    else {
                        listBox4.Items.Add(sayilar[sayac]);
                    }


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

        private void button4_Click(object sender, EventArgs e)
        {
            string aranan = textBox2.Text;

            int sayac = 0;

            string tekCift = "Sayı Çiftir";

            foreach(int sayi in sayilar){
                sayac++;
                if(sayi.ToString() == aranan){
                    if (sayi % 3 == 0) {
                        tekCift = "Sayı Tektir";
                    }
                    MessageBox.Show(aranan+" Sayı "+sayac+". değerde bulundu. "+tekCift);
                    break;
                }

               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int enKucukSayi = 10000;
            foreach (int sayi in sayilar)
            {
                if (sayi < enKucukSayi) {
                    enKucukSayi = sayi;
                }
            }

            MessageBox.Show("En Küçük Sayı: "+enKucukSayi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int enBuyukSayi = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi > enBuyukSayi)
                {
                    enBuyukSayi = sayi;
                }
            }

            MessageBox.Show("En Küçük Sayı: " + enBuyukSayi);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked) {
                this.BackColor = Color.White;
            }
            else if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.ForeColor = Color.Black;
            }
            else if (radioButton5.Checked)
            {
                this.BackColor = Color.White;
            }
            else if (radioButton6.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (Convert.ToInt16(textBox1.Text) >= 10 && Convert.ToInt16(textBox1.Text) < 50)
                {
                    this.Font = new Font("Arial", Convert.ToInt16(textBox1.Text), FontStyle.Bold);
                }
            }
           
           
        }
    }
}

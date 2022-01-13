using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25112021_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Vhesapla() {
            //void fonksiyon
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show((sayi1+sayi2).ToString());
        }

        void Vhesapla2(int s1, int s2) {
            //void fonksiyon parametreli
            MessageBox.Show((s1+s2).ToString());
        }

        int Rhesapla() {
            //return fonksiyon
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            return sayi1+sayi2;
        }

        int Rhesapla2(int s1,int s2) { 
        //parametreli
            return s1 + s2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vhesapla();






            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            Vhesapla2(sayi1,sayi2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = Rhesapla();
            MessageBox.Show(toplam.ToString());
            label3.Text = toplam.ToString();




            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam2 = Rhesapla2(sayi1,sayi2);
            MessageBox.Show(toplam2.ToString());
            label4.Text = toplam2.ToString();
        }
    }
}

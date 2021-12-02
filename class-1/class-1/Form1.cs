using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Dikdortgen 
        {
            private int a, b;

            public Dikdortgen(int a, int b) {
                this.a = a;
                this.b = b;
             
            }

            public int AlanHesapla()
            {
                return this.a * this.b;
            }

            public int cevreHesapla()
            {
                return 2 * (this.a + this.b);
            }


        }

        class DikdortgenHesapla2 
        {
            public int a, b;

            public int AlanHesapla()
            {
                return this.a * this.b;
            }

            public int cevreHesapla()
            {
                return 2 * (this.a + this.b);
            }
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Dikdortgen DikdortgenClass = new Dikdortgen(10, 20);
            int dikdortgenAlani = DikdortgenClass.AlanHesapla();
            int cevreHesapla = DikdortgenClass.cevreHesapla();
            MessageBox.Show("Alanı: " + dikdortgenAlani.ToString() + "\nÇevresi:" + cevreHesapla.ToString());


            DikdortgenHesapla2 DikgortgenClass2 = new DikdortgenHesapla2();
            DikgortgenClass2.a = 30;
            DikgortgenClass2.b = 40;
            int dikdorgenAlani2 = DikgortgenClass2.AlanHesapla();
            int cevreHesapla2 = DikgortgenClass2.cevreHesapla();
            MessageBox.Show("Alanı: " + dikdorgenAlani2.ToString() + "\nÇevresi:" + cevreHesapla2.ToString());
            
         
        }
    }
}

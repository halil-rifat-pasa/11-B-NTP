using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class islemler 
        {

            public int sayi1, sayi2;

            public int toplamaYap() 
            {
                return this.sayi1 + this.sayi2;
            }

            public int cikarmaYap() 
            {
                return this.sayi1 - this.sayi2;
            }

            public int carpmaYap() 
            {
                return this.sayi1 * this.sayi2;
            }

            public double bolmeYap() 
            {
                return this.sayi1 / this.sayi2;
            }
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islemler islem = new islemler();

            try
            {
                islem.sayi1 = Convert.ToInt16(textBox1.Text);
                islem.sayi2 = Convert.ToInt16(textBox2.Text);

                string yapilacakIslem = comboBox1.Text;
                string sonuc = "0";


                if (yapilacakIslem == "+")
                {
                    sonuc = islem.toplamaYap().ToString();
                }
                else if (yapilacakIslem == "-")
                {
                    sonuc = islem.cikarmaYap().ToString();
                }
                else if (yapilacakIslem == "*")
                {
                    sonuc = islem.carpmaYap().ToString();
                }
                else if (yapilacakIslem == "/")
                {
                    sonuc = islem.bolmeYap().ToString();
                }
                else {
                    sonuc = "Hatalı İşlem Seçimi";
                }

                textBox3.Text = sonuc;
            }
            catch {
                MessageBox.Show("Hatalı bir şey yaptınız :(((");
            }
           

            
            

        }
    }
}

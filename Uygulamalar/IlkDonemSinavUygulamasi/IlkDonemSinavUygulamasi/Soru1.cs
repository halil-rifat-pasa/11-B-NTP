using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkDonemSinavUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string tur = "";

        private void button3_Click(object sender, EventArgs e)
        {
            //Kare

            tur = "Karenin";
            double a = Convert.ToDouble(textBox3.Text);

            if (a > 0) {
                MessageBox.Show(tur + " Alanı:" + (a * a) + " \n Çevresi :" + (4 * a));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // alan: (a*b), çevres (2*a+2*b)
            tur = "Dikdörtgenin ";
            double a = Convert.ToDouble(textBox6.Text);
            double b = Convert.ToDouble(textBox5.Text);

            if (a > 0 && b > 0) {
                MessageBox.Show(tur + " Alanı:" + (a * b) + " \n Çevresi :" + (2 * a + 2 * b));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tur = "Dairenin ";
            double r = Convert.ToDouble(textBox4.Text);
            if (r > 0) {
                MessageBox.Show(tur + " Alanı:" + (3.14 * r * r) + " \n Çevresi :" + (2 * 3.14 * r));
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tur = "Üçgenin ";
            double t = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if (y > 0 && t > 0) {
                MessageBox.Show(tur + " Alanı:" + (t * y / 2));
            }
            
        }
    }
}

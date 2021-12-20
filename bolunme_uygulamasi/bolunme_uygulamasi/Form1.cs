using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolunme_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);

            if (sayi != 0)
            {
                if (sayi % 3 == 0 && sayi % 5 == 0)
                {
                    MessageBox.Show("Sayı 3 ve 5 e tam bölünür.");
                }
                else
                {
                    MessageBox.Show("Sayı 3 ve 5 e tam bölünmez !!");
                }
            }
            else {
                MessageBox.Show("0 giremezsin :((");
            }
           
        }
    }
}

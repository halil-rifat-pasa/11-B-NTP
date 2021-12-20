using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziIleNotGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tiklamaSayisi = 0;
        int[] numara = new int[100];
        int[] not = new int[100];
        double[] ortalama = new double[100];

        private void button1_Click(object sender, EventArgs e)
        {



            numara[tiklamaSayisi] = Convert.ToInt16(textBox1.Text);
            not[tiklamaSayisi] = Convert.ToInt16(textBox2.Text);
            

            listBox1.Items.Add(numara[tiklamaSayisi]+" Numaralı Öğrencinin Notu: "+not[tiklamaSayisi]);
            tiklamaSayisi++;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

  
            for (int i = 0; i < 100; i++)
            {
               
                 ortalama[numara[i]] += not[i];
                 
                 numara[numara[i]] = numara[i];
               
            }

            for (int i = 0; i < 100; i++)
            {
               
                double not = (ortalama[i] / 2);
                if (not > 0) {
                    int ogrNumber = numara[i];
                    MessageBox.Show(ogrNumber.ToString() + " Numaralı Öğrencinin Notu: " + not.ToString());
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerRandomSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[101];
            Random x = new Random();

            int sayac = 1;

            while (sayac < 101)
            {
                int randomSayi =  x.Next(0,101);
            
                if (sayilar.Contains(randomSayi) == false) {
                    sayilar[sayac] = randomSayi;
                    sayac++;
                }
            
            }
            sayac = 1;


            while (sayac < 101)
            {
                listBox1.Items.Add("Sayacın Değeri:"+sayac+" --- "+sayilar[sayac].ToString());
                sayac++;
            }
        }
    }
}

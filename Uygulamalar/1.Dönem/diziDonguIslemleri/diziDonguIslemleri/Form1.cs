using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziDonguIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[40];

            int sayac = 0;

            for (int i = 0; i < 40; i++)
            {
                sayilar[i] = i+1;
                //MessageBox.Show("Sayılar["+i+"] = "+(i+1).ToString());
            }

            while (sayac < 40)
            {
                listBox1.Items.Add(sayilar[sayac]);
                sayac++;
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuzdeHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuzdeOrani = Convert.ToInt16(textBox1.Text);
            int sayi = Convert.ToInt16(textBox2.Text);

            double hesapla = 0;

            hesapla = sayi * yuzdeOrani / 100;

            MessageBox.Show(hesapla.ToString());

        }
    }
}

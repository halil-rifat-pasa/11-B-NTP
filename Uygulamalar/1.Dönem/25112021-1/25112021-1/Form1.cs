using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25112021_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text, soyad=textBox2.Text;
            MessageBox.Show("Hoşgeldiniz "+ad+" "+soyad);
            inputTemizle();
           
        }

        void islemYap(string islem) {
            int s1 = Convert.ToInt32(textBox4.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            int sonuc = 0;
            if(islem == "+") sonuc = Convert.ToInt32(s1) + Convert.ToInt32(s2);
            if (islem == "-") sonuc = Convert.ToInt32(s1) - Convert.ToInt32(s2);

            MessageBox.Show(sonuc.ToString());
        }

        void inputTemizle()
        {
            textBox1.Text = textBox2.Text = "";
            MessageBox.Show("Hoşgeldiniz Temizlendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //temizleme yapar.
            inputTemizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //toplama yapar
            islemYap("+");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //çıkartma yapar
            islemYap("-");
        }
    }
}

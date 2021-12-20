using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, sonuc;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            sonuc = a + b + c;
            textBox4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double h, d, k, l;
            h = Convert.ToDouble(textBox8.Text);
            d = Convert.ToDouble(textBox9.Text);
            k = h * d;


        }

        
        

        }

    }


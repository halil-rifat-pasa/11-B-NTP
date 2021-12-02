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
            public int a, b;

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


        private void Form1_Load(object sender, EventArgs e)
        {
            Dikdortgen DikdortgenClass = new Dikdortgen(10,20);
            //MessageBox.Show(DikdortgenClass.a.ToString());
            //MessageBox.Show(DikdortgenClass.a.ToString());
         
        }
    }
}

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
    public partial class Soru2 : Form
    {
        public Soru2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg = Convert.ToDouble(textBox1.Text);
            double m = Convert.ToDouble(textBox2.Text);
            double vki = kg / (m * m);

            if(vki > 30){
                MessageBox.Show("İdeal Kilonun Çok Üzeri");
            }else if(vki >= 25 && vki < 30){
                MessageBox.Show("İdeal Kilonun Üzeri");
            }
            else if (vki >= 18.5 && vki < 25)
            {
                MessageBox.Show("ideal kilo");
            }
            else {
                MessageBox.Show("İdeal Kilonun Altı");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolme_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);

            int toplam = 0;
            int carpim = 1;

            for (int i = baslangic; i < bitis; i++ )
            {
                toplam += i;
                carpim *= i;
            }

            MessageBox.Show("Toplam:"+toplam.ToString()+" Çarpım:"+carpim.ToString());
        }
    }
}

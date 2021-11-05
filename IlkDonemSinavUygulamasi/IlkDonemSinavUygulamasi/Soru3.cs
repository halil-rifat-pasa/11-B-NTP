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
    public partial class Soru3 : Form
    {
        public Soru3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt16(textBox1.Text);
            int bitis = Convert.ToInt16(textBox2.Text);

            if (radioButton1.Checked == true)
            {
                // for döngüsü

                for (int i = baslangic; i < bitis; i++ )
                {
                    if(i % 2 == 0 || i%3 == 0){
                        listBox1.Items.Add(i);
                    }
                }

            }
            else { 
                //while döngüsü

                while(baslangic < bitis)
                {
                    if (baslangic % 2 == 0 || baslangic % 3 == 0)
                    {
                        listBox1.Items.Add(baslangic);
                    }

                    baslangic++;
                }
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Temizle buton
            listBox1.Items.Clear();
        }
    }
}

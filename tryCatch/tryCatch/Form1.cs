using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCatch
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
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            int toplam = sayi1 + sayi2;
            label3.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            try
            {
                int sayi1 = Convert.ToInt16(textBox3.Text);
                int sayi2 = Convert.ToInt16(textBox4.Text);
                int toplam = sayi1 + sayi2;
                label6.Text = toplam.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata olduğu zaman çalışır. "+ex.Message);
            }
            finally {
                MessageBox.Show("Hata versede vermesede çalışır.");
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt16(textBox5.Text); //textBox5.Text = abc 
            int sayi2 = Convert.ToInt16(textBox6.Text);


            try
            {
                int sayi3 = Convert.ToInt16(textBox7.Text);
                int sayi4 = Convert.ToInt16(textBox8.Text);
                int toplam = sayi1 + sayi2 + sayi3 + sayi4;
                MessageBox.Show(toplam.ToString());
            }
            catch
            {

                MessageBox.Show("Bir Sorunla Karşılaşıldı");
               
            }
            finally
            {
                textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            }
           
        }
    }
}

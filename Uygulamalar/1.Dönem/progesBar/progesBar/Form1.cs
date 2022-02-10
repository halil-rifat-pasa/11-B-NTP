using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progesBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;

            try
            {

                int dorani = Convert.ToInt16(textBox1.Text);
                if (dorani > 0) {
                    progressBar1.Value = dorani;
                }

                if (dorani == 100) {
                    MessageBox.Show("Efkarım birikti sığmaz içime ..");
                    progressBar1.Value = 0;
                }
                
            }
            catch {
                label2.Text = "Bir sorunla Karşılaşıldı";
                label2.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}

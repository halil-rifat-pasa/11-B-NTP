using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelime_icersindeki_sessiz_harfler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            string sessizHarfler = "zyvtşsrpnrmlkhjğgdçcb";
            int sessizHarfSayisi = 0;

            for (int i = 0; i < kelime.Length; i++ )
            {
                string harf = kelime[i].ToString();
   
                if(sessizHarfler.Contains(harf)){
                    sessizHarfSayisi++;
                }
            }
            MessageBox.Show("Sessiz Harf: "+sessizHarfSayisi.ToString()+" Bulundu");
        }
    }
}

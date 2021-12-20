using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hasan, ali, mehmet
            string[] isimler = new string[3] {"Hasan","Ali","Mehmet"};
            int[] sayilar = new int[10] {1,2,3,4,5,6,7,8,9,10};

            string[] soyisimler = new string[4];
            soyisimler[0] = "Kaya";
            soyisimler[1] = "Yılmaz";


            int[] sayilarDizisi = new int[5];
            sayilarDizisi[0] = 10;
            sayilarDizisi[1] = 20;


            bool[] kontroller = new bool[4];
            kontroller[0] = true;
            kontroller[1] = false;

            MessageBox.Show(kontroller[3].ToString());
            //MessageBox.Show(sayilar[5].ToString());
            //MessageBox.Show(isimler[4]);
            //MessageBox.Show(isimler[1]);
        }
    }
}

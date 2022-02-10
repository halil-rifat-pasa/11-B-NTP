using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class ogrenciler
        {
            public string adi, soyadi, okulNumarasi;


            public string MesajVer(string adi, string soyadi, string okulNumarasi)
            {
                //string mesaj = "Hoşgeldin " + this.adi + " " + this.soyadi + " Numaran:" + this.okulNumarasi;
                string mesaj = "Hoşgeldin " + adi + " " + soyadi + " Numaran:" + okulNumarasi;
                MessageBox.Show(mesaj);
                return mesaj;
            }


        }


        private void Form1_load(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();
            ogr.adi = "Hasan";
            ogr.soyadi = "Kaya";
            ogr.okulNumarasi = "50";
            ogr.MesajVer("Büşra", "Aydın", "51");
            //string mesaj = ogr.MesajVer("Büşra","Aydın","51");
            // MessageBox.Show(mesaj);
        }
    }
}

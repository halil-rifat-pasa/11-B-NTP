using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Öğrencinin; Adı, Soyad, Okul No, cinsiyet
        //Bilgisayar; mac, işlemci, ram, ekran kartı, depolama

        class ogrenciler
        { 
            public string adi,soyadi;
            private int okul_no;
            protected bool cinsiyet;

        }


        class bilgisayarlar 
        {
            public string mac, islemci, ram, ekran_karti, depolama;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();
            
            
        }
    }
}

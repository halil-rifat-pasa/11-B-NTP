using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sinemaUygulama
{
    public partial class filmSecim : Form
    {
        public filmSecim()
        {
            InitializeComponent();
        }

        public static string filmAdi = "";

        private void _filmsec(object sender, EventArgs e)
        {
            filmAdi = (sender as PictureBox).Name;

            koltukSecimi sec = new koltukSecimi();
            sec.ShowDialog();
        }
    }
}

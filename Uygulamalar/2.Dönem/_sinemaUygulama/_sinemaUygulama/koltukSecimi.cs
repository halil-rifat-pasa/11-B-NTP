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
    public partial class koltukSecimi : Form
    {
        public koltukSecimi()
        {
            InitializeComponent();
        }

        private void koltukSecimi_Load(object sender, EventArgs e)
        {
            int butonSayisi = 100;


            int x = 30;
            int y = 35;

            int artisMiktariX = 80;
            int artisMiktariY = 80;




            for (int i = 1; i <= butonSayisi; i++)
            {
                //butonun ayarlamalarını yapıyorum.
                Button koltuklar = new Button();
                koltuklar.Name = "koltuk" + i.ToString();
                koltuklar.Text = i.ToString() + " Numaralı Koltuk";
                koltuklar.Size = new Size(65,60);
                koltuklar.FlatStyle = FlatStyle.Flat;
                koltuklar.BackColor = Color.Green;
                koltuklar.ForeColor = Color.White;

                //koltuklar.click += yazdıktan sonra tab tab tuşlarına basarak oluşturulur. butonun click olayını tanımlamış olduk.
                koltuklar.Click += koltuklar_Click;

                koltuklar.Location = new Point(x,y);
                x = x+artisMiktariX;
                /* 
                    Eğer formda oluşan buton sayısı 8 adetse,
                 * Y düzlemini aşağı indirmek için yaptık.
                 
                 */
                if (i % 8 == 0) {
                    x = 30;
                    y = y + artisMiktariY;
                }


                //forma koltuklar nesnesi ekliyorum.
                groupBox1.Controls.Add(koltuklar);

            }



            

            /*foreach (Control koltuklar in groupBox1.Controls)
            {
                
            }*/



        }

        void koltuklar_Click(object sender, EventArgs e)
        {
            string tiklanan = (sender as Button).Name;
            MessageBox.Show(tiklanan);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        string film = "";
        private void koltukSecimi_Load(object sender, EventArgs e)
        {

            
            if (filmSecim.filmAdi == "pictureBox1") {
                film = "batman";
            }
            else if (filmSecim.filmAdi == "pictureBox2")
            {
                film = "uncharted";
            }
            else if (filmSecim.filmAdi == "pictureBox3")
            {
                film = "kırmızı";
            }
            else if (filmSecim.filmAdi == "pictureBox4")
            {
                film = "aslan";
            }
            else if (filmSecim.filmAdi == "pictureBox5")
            {
                film = "ceviz ağacı";
            }



            //MessageBox.Show(film);
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

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_sinemaOtomasyon;Persist Security Info=True;User ID=testUser;Password=123");

        void koltuklar_Click(object sender, EventArgs e)
        {
            
            string tiklanan = (sender as Button).Name;


            if ((sender as Button).BackColor == Color.Green) {
                conn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO koltuk_secimleri(koltuk_adi,film_adi) VALUES('" + tiklanan + "','" + film + "')", conn);
                komut.ExecuteNonQuery();
                conn.Close();

            }

   


            (sender as Button).BackColor = Color.Red;

        }
    }
}

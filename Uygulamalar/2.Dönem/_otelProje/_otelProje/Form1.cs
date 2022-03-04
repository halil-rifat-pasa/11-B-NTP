using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _otelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_OtelVT;User ID=testUser;Password=123");




        private void Form1_Load(object sender, EventArgs e)
        {
            














            int butonSayac = 16;
            foreach (Control x in this.Controls)
            {
                if (x is Button) 
                {
                   
                    x.Text = "Oda " + butonSayac.ToString();
                    x.BackColor = Color.DarkGreen;
                    x.ForeColor = Color.White;
                    
                    conn.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM tbl_musteriler",conn);
                    SqlDataReader oku = komut.ExecuteReader();

                    while (oku.Read())
                    {
                        if (oku["oda_no"].ToString() == x.Text)
                        {
                            x.BackColor = Color.Red;
                        }
                    }

                    conn.Close();



                    butonSayac--;
                }
            }


            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM V_musterileri_getir", conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        }

        public static string seciliOda = ""; 

        private void _odaSec(object sender, EventArgs e)
        {
            //string tiklananButon = (sender as Button).Name.ToString();
            seciliOda = (sender as Button).Text.ToString();


            if ((sender as Button).BackColor == Color.Red)
            {

                /* 
                 * MessageBox.Show("Zaten Dolu ..");
                 * 
                 * DialogResult x =  MessageBox.Show("Oda Dolu, Güncellemek için Ok Tuşuna Basın.","Uyarı",MessageBoxButtons.YesNo);
                if (x == DialogResult.OK) 
                {
                    odaKayit kayit = new odaKayit();
                    kayit.ShowDialog();
               
                } */
                odaKayit kayit = new odaKayit();
                kayit.ShowDialog();




            }
            else 
            {



                odaKayit kayit = new odaKayit();
                kayit.ShowDialog();




                if (odaKayit.odaDurum == true)
                {

                    (sender as Button).BackColor = Color.Red;
                    
                }
            
            
            }



           
        }
    }
}

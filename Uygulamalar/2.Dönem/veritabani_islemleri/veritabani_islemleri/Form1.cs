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

namespace veritabani_islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=_hasankaya;User ID=hasankaya;Password=123");

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            conn.Open(); //bağlantıyı aç
            SqlCommand cmd = new SqlCommand("SELECT * FROM iller",conn);
            SqlDataReader oku = cmd.ExecuteReader();

            while(oku.Read())
            {
                listBox1.Items.Add("ID:"+oku["il_id_PK"].ToString() + " İl Adı: " + oku["il_adi"].ToString());
                comboBox1.Items.Add("ID:" + oku["il_id_PK"].ToString() + " İl Adı: " + oku["il_adi"].ToString());
                textBox2.Text = "ID:" + oku["il_id_PK"].ToString() + " İl Adı: " + oku["il_adi"].ToString();
            }


            conn.Close(); //bağlantıyı kapat..
        }
    }
}

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

namespace hastaneVeriTabani
{
    public partial class hemsireEkrani : Form
    {
        public hemsireEkrani()
        {
            InitializeComponent();
        }


        void listele() 
        {
            DataTable dt = new DataTable();
            girisEkrani.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT hasta_bilgileri_id as 'Hasta Numarası',adi as 'Adı', soyadi as 'Soyadı',dogum_tarihi as 'Doğum Tarihi', oda_numarasi as 'Oda Numarası' FROM tbl_hasta_bilgileri", girisEkrani.conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            girisEkrani.conn.Close();
        }


        private void hemsireEkrani_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(e.ColumnIndex.ToString());
        }

        private void _dataAra(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisEkrani.conn.Open();
            SqlCommand komut = new SqlCommand("UPDATE tbl_hasta_bilgileri SET adi='"+textBox1.Text+"', soyadi='"+textBox2.Text+"',  oda_numarasi = '"+textBox4.Text+"' WHERE  hasta_bilgileri_id = '"+textBox5.Text+"'", girisEkrani.conn);
            komut.ExecuteNonQuery();
            girisEkrani.conn.Close();


            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

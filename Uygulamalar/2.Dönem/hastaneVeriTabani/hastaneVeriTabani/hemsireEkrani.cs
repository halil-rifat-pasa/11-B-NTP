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

        private void hemsireEkrani_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            girisEkrani.conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT adi as 'Adı', soyadi as 'Soyadı',dogum_tarihi as 'Doğum Tarihi', oda_numarasi as 'Oda Numarası' FROM tbl_hasta_bilgileri",girisEkrani.conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            girisEkrani.conn.Close();
        }
    }
}

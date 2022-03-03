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
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }

        void listele() 
        {
            DataTable dt = new DataTable();
            girisEkrani.conn.Open();
            //hastalar bir view'dir.
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM hastalar", girisEkrani.conn);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            girisEkrani.conn.Close();
        
        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}

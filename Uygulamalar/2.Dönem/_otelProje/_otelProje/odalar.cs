using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _otelProje
{
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }

        private void odalar_Load(object sender, EventArgs e)
        {
           

            int x = 30;
            int y = 50;

            for (int i = 1; i <= 105; i++)
            {
                Button btn = new Button();
                btn.Name = "Button"+i.ToString();
                btn.Text = "Oda "+i.ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 50);
                btn.Click += new EventHandler(button1_Click);
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Green;
                btn.FlatStyle = FlatStyle.Flat;


                this.Controls.Add(btn);

                x += 150;
                if (i % 5 == 0) 
                {
                    x = 30;
                    y += 100;
                
                }
                
            }

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text.ToString());
        }
    }
}

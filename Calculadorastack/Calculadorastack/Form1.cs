using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorastack
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string cadenaEntrada;

        private void B7_Click(object sender, EventArgs e)
        {
            txtdatos.Text = txtdatos.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
                txtdatos.Text = txtdatos.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "9";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "9";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "6";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "6";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "5";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "5";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "4";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "4";
            }
        }

        /* private void Bborra1_Click(object sender, EventArgs e)
        {
            txtdatos = txtdatos.ControlRemoved(txtdatos.MaxLength - 1);
        }
        */

        private void Bigual_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser(txtdatos.Text);
            txtdatos.Text = Convert.ToString(parser.Operacion());
            //txtprocedimiento.Text=Convert.

        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "3";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "3";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "2";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "2";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "1";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "1";
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "0";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "0";
            }
        }

        private void Bmas_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "+";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "+";
            }
        }

        private void Bpor_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "*";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "*";
            }
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "-";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "-";
            }
        }

        private void Breciduo_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "%";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "%";
            }
        }

        private void Bdivicion_Click(object sender, EventArgs e)
        {
            if (txtdatos.Text == "")
            {
                txtdatos.Text = "/";
            }
            else
            {
                txtdatos.Text = txtdatos.Text + "/";
            }
        }

        private void txtdatos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPromedio
{
    public partial class frmPromedio : Form
    {

        //declarando variables
        double n1 = 0, n2 = 0, n3 = 0, n4 = 0, prom = 0;
        string con = "";
        public frmPromedio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtProm.ReadOnly = true;
            txtCond.ReadOnly = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validando
            if (txtNot1.Text == "")
            {
                MessageBox.Show("Ingrese la nota 1");
                txtNot1.Focus();
            }
            else if (txtNot2.Text == "")
            {
                MessageBox.Show("Ingrese la nota 2");
                txtNot2.Focus();
            }
            else if (txtNot3.Text == "")
            {
                MessageBox.Show("Ingrese la nota 3");
                txtNot3.Focus();
            }
            else if (txtNot4.Text == "")
            {
                MessageBox.Show("Ingrese la nota 4");
                txtNot4.Focus();
            }
            else
            {
                //capturando valores
                n1 = Convert.ToDouble(txtNot1.Text);
                n2 = Convert.ToDouble(txtNot2.Text);
                n3 = Convert.ToDouble(txtNot3.Text);
                n4 = Convert.ToDouble(txtNot4.Text);
                //realizando operaciones
                prom = (n1 + n2 + n3 + n4) / 4;
                //condicion
                if (prom >= 12.5)
                {
                    con = "Aprobado";
                }
                else
                {
                    con = "Desaprobado";
                }

                //mostrando resultado
                txtProm.Text = prom.ToString();
                txtCond.Text = con.ToString();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            txtNot4.Text = "";
            txtProm.Text = "";
            txtCond.Text = "";
            txtNot1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

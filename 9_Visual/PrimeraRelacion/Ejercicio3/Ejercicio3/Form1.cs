using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTsuma_Click(object sender, EventArgs e)
        {
            double resultado;

            bool res1 = double.TryParse(TBoperador1.Text, out resultado);
            bool res2 = double.TryParse(TBoperador2.Text, out resultado);

            if(res1 == true && res2 == true)
            {
                Lsimbolo.Text = BTsuma.Text;
                Lsimbolo.Visible = true;
                double final = double.Parse(TBoperador1.Text) + double.Parse(TBoperador2.Text);
                TBresultado.Text = final.ToString();
            }
            else
            {
                MessageBox.Show("Los números son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTresta_Click(object sender, EventArgs e)
        {
            double resultado;

            bool res1 = double.TryParse(TBoperador1.Text, out resultado);
            bool res2 = double.TryParse(TBoperador2.Text, out resultado);

            if (res1 == true && res2 == true)
            {
                Lsimbolo.Text = BTresta.Text;
                Lsimbolo.Visible = true;
                double final = double.Parse(TBoperador1.Text) - double.Parse(TBoperador2.Text);
                TBresultado.Text = final.ToString();
            }
            else
            {
                MessageBox.Show("Los números son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTmulti_Click(object sender, EventArgs e)
        {
            double resultado;

            bool res1 = double.TryParse(TBoperador1.Text, out resultado);
            bool res2 = double.TryParse(TBoperador2.Text, out resultado);

            if (res1 == true && res2 == true)
            {
                Lsimbolo.Text = BTmulti.Text;
                Lsimbolo.Visible = true;
                double final = double.Parse(TBoperador1.Text) * double.Parse(TBoperador2.Text);
                TBresultado.Text = final.ToString();
            }
            else
            {
                MessageBox.Show("Los números son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTdivi_Click(object sender, EventArgs e)
        {
            double resultado;

            bool res1 = double.TryParse(TBoperador1.Text, out resultado);
            bool res2 = double.TryParse(TBoperador2.Text, out resultado);

            if (res1 == true && res2 == true)
            {
                Lsimbolo.Text = BTdivi.Text;
                Lsimbolo.Visible = true;
                double final = double.Parse(TBoperador1.Text) / double.Parse(TBoperador2.Text);
                final = Math.Round(final, 2);
                TBresultado.Text = final.ToString();
            }
            else
            {
                MessageBox.Show("Los números son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

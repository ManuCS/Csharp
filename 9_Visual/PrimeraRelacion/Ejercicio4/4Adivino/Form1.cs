using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Adivino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num = 50;
        double numantig;
        double num2;
        
        private void BTaceptar_Click(object sender, EventArgs e)
        {


            BTaceptar.Enabled = false;
            labelTextNum.Visible = true;
            labelNumero.Visible = true;
            BTmayor.Visible = true;
            BTmenor.Visible = true;
            BTdios.Visible = true;
            BTpatata.Visible = true;
            labelNumero.Text = num.ToString();
        }

        private void BTmayor_Click(object sender, EventArgs e)
        {
            
            if(num == 100)
            {
                BTmayor.Enabled = false;
                BTmenor.Enabled = false;
                MessageBox.Show("El número no puede ser mayor que 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if(num == 50)
                {
                    numantig = num;
                    num = num + (num / 2);
                    labelNumero.Text = num.ToString();
                }
                else
                {
                    num2 = Math.Abs(num - numantig);
                    numantig = num;
                    num = Math.Ceiling(num + Math.Ceiling(num2 / 2));
                    labelNumero.Text = num.ToString();
                }
            }
        }

        private void BTmenor_Click(object sender, EventArgs e)
        {

            if(num == 1)
            {
                MessageBox.Show("El número no puede ser menor que 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (num == 50)
                {
                    numantig = num;
                    num = num - num / 2;
                    labelNumero.Text = num.ToString();
                }
                else
                {
                    num2 = Math.Abs(num - numantig);
                    numantig = num;
                    num = Math.Ceiling(num - Math.Ceiling(num2 / 2));
                    labelNumero.Text = num.ToString();
                }

            }
        }

        private void BTdios_Click(object sender, EventArgs e)
        {
            BTmayor.Enabled = false;
            BTmenor.Enabled = false;
            labelDios.Visible = true;
        }

        private void BTpatata_Click(object sender, EventArgs e)
        {
            BTmayor.Enabled = false;
            BTmenor.Enabled = false;
            labelPatata.Visible = true;
        }
    }
}

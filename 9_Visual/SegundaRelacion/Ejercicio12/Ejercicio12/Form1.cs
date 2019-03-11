using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        double resultado, medida;
        public Form1()
        {
            InitializeComponent();
        }

        public double CalculaMedida(double medida)
        {
            if(RBpul1.Checked == true)
            {
                medida = medida * 2.54;
            }
            else
            {
                if(RByard1.Checked == true)
                {
                    medida = medida * 91.4;
                }
            }

            return medida;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RBcent1_CheckedChanged(object sender, EventArgs e)
        {

            if (RBcent1.Checked == true)
            {
                Luni.Text = "cm";
            }
            else
            {
                if(RBpul1.Checked == true)
                {
                    Luni.Text = "pul";
                }
                else
                {
                    if(RByard1.Checked == true)
                    {
                        Luni.Text = "yard";
                    }
                }
            }
        }


        private void TBunidades_TextChanged(object sender, EventArgs e)
        {
            double conver;

            if(double.TryParse(TBunidades.Text, out conver))
            {
                medida = double.Parse(TBunidades.Text);
                medida = CalculaMedida(medida);

                if(RBcent2.Checked == true)
                {
                    resultado = medida;
                }
                else
                {
                    if(RBpul2.Checked == true)
                    {
                        resultado = medida / 2.54;
                    }
                    else
                    {
                        if(RByard2.Checked == true)
                        {
                            resultado = medida / 91.4;
                        }
                        else
                        {
                            resultado = -1;
                        }
                    }
                }
                TBconver.Text = resultado.ToString();
            }
            else
            {
                if(TBunidades.Text == "")
                {
                    TBconver.Text = "";
                }
            }
           


        }
    }
}

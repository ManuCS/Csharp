using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5ConversorPulgadas
{
    public partial class Form1 : Form
    {

        public bool turno = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBcentimetros_TextChanged(object sender, EventArgs e)
        {
            if(!turno)
            {
                turno = true;
                double medida;
                double res;

                if (double.TryParse(TBcentimetros.Text, out medida))
                {
                    res = medida / 2.54;
                    res = Math.Round(res, 4);

                    TBpulgadas.Text = res.ToString();
                }
                else
                {
                    if(TBcentimetros.Text == "")
                    {
                        TBpulgadas.Text = "";
                    } 
                }
            }
            turno = false;
        }

        private void TBpulgadas_TextChanged(object sender, EventArgs e)
        {
            if(!turno)
            {
                turno = true;
                double medida;
                double res;

                if (double.TryParse(TBpulgadas.Text, out medida))
                {
                    res = medida * 2.54;

                    TBcentimetros.Text = res.ToString();
                }
                else
                {
                    if (TBpulgadas.Text == "")
                    {
                        TBcentimetros.Text = "";
                    }
                }

            }
            turno = false;
        }
    }
}

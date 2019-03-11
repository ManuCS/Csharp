using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTtirar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int i, num, suma;
            suma = 0;

            listBox1.Items.Clear();
            TBsuma.Text = "";

            for(i = 0; i < UpDdados.Value; i++)
            {
                num = rnd.Next(1, int.Parse(UpDcaras.Value.ToString())+1);
                listBox1.Items.Add("Dado número " + (i+1) + ": " + num);
                suma = suma + num;
            }

            TBsuma.Text = suma.ToString();
        }
    }
}

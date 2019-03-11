using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTarriba_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X, labelO.Location.Y - 15);
        }

        private void BTabajo_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X, labelO.Location.Y + 15);
        }

        private void BTizquierda_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X - 15, labelO.Location.Y);
        }

        private void BTderecha_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X + 15, labelO.Location.Y);
        }

        private void BTcentro_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(135,124);
        }

        private void BTizqarriba_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X - 15, labelO.Location.Y - 15);
        }

        private void BTderarriba_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X + 15, labelO.Location.Y - 15);
        }

        private void BTizqabajo_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X - 15, labelO.Location.Y + 15);
        }

        private void BTderabajo_Click(object sender, EventArgs e)
        {
            labelO.Location = new Point(labelO.Location.X + 15, labelO.Location.Y + 15);
        }
    }
}

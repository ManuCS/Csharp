using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {

        List<string> listaIngles = new List<string>();
        List<string> listaEsp = new List<string>();

        public Form1()
        {
            InitializeComponent();
            CargaFichero();
        }

        public void CargaFichero()
        {
            string cad, espanol, ingles;
            int pos;

            StreamReader sr = new StreamReader("traductor.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                cad = sr.ReadLine();
                pos = cad.IndexOf(',');
                espanol = cad.Substring(0, pos);
                ingles = cad.Substring(pos + 1);
                listaEsp.Add(espanol);
                listaIngles.Add(ingles);
            }

            sr.Close();
        }


        private void BTesp_Click(object sender, EventArgs e)
        {
            string palabra = TBesp.Text.ToLower();

            int pos = listaEsp.IndexOf(palabra);

            if (pos == -1)
            {
                MessageBox.Show("La palabra que buscas no está en la lista.", "Palabra no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBingles.Text = listaIngles[pos];
            }
        }

        private void BTingles_Click(object sender, EventArgs e)
        {
            string palabra = TBingles.Text.ToLower();

            int pos = listaIngles.IndexOf(palabra);

            if (pos == -1)
            {
                MessageBox.Show("La palabra que buscas no está en la lista.", "Palabra no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TBesp.Text = listaEsp[pos];
            }
        }
    }
}

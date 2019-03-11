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

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            diccionario();
        }

        public void diccionario()
        {
            if (File.Exists("traductor.txt"))
            {
                string palabra;

                StreamReader sr = new StreamReader("traductor.txt", Encoding.Default);

                while (!sr.EndOfStream)
                {
                    palabra = sr.ReadLine();
                    palabra = palabra.Replace(",", " = ");
                    LBdiccionario.Items.Add(palabra);
                }

                sr.Close();
            }
        }


        private void BTanadir_Click(object sender, EventArgs e)
        {
            string traduc;

            traduc = TBesp.Text.Trim() + " = " + TBingles.Text.Trim();

            LBdiccionario.Items.Add(traduc);
            TBesp.Text = "";
            TBingles.Text = "";
        }

        private void TBesp_TextChanged(object sender, EventArgs e)
        {
            if(TBesp.Text != "" && TBingles.Text != "")
            {
                BTanadir.Enabled = true;
            }
            else
            {
                BTanadir.Enabled = false;
            }
        }

        private void TBingles_TextChanged(object sender, EventArgs e)
        {
            if (TBesp.Text != "" && TBingles.Text != "")
            {
                BTanadir.Enabled = true;
            }
            else
            {
                BTanadir.Enabled = false;
            }
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            int pos = LBdiccionario.SelectedIndex;

            LBdiccionario.Items.RemoveAt(pos);
        }

        private void LBdiccionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBdiccionario.SelectedIndices.Count > 0)
            {
                BTborrar.Enabled = true;
            }
            else
            {
                BTborrar.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string palabras;
            int i;

            StreamWriter sw = new StreamWriter("traductor.txt");

            for(i = 0; i < LBdiccionario.Items.Count; i++)
            {
                palabras = LBdiccionario.Items[i].ToString();
                palabras = palabras.Replace(" = ", ",");
                sw.WriteLine(palabras);
            }

            sw.Close();
        }
    }
}

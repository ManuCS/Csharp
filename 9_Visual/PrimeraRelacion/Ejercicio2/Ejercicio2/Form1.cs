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

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("bloc.txt");

            sw.Write(textBox1.Text);
            sw.Close();

            MessageBox.Show("Texto guardado.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("bloc.txt"))
            {
                StreamReader sr = new StreamReader("bloc.txt");

                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                
            }
            else
            {
                MessageBox.Show("Error, el archivo no existe");
            }
        }
    }
}

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

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LeeFicheros();
        }


        public void LeeFicheros()
        {
            string titulo;

            StreamReader sr = new StreamReader("nombre1.txt");

            while (!sr.EndOfStream)
            {
                titulo = sr.ReadLine();
                CBnom1.Items.Add(titulo);
            }

            sr.Close();

            StreamReader sr2 = new StreamReader("nombre2.txt");

            while (!sr2.EndOfStream)
            {
                titulo = sr2.ReadLine();
                CBnom2.Items.Add(titulo);
            }

        }

        private void BTgenera_Click(object sender, EventArgs e)
        {
            if(CBnom1.SelectedIndex >= 0 && CBnom2.SelectedIndex >= 0)
            {
                ltitulo.Visible = true;
                ltitulo.Text = CBnom1.Items[CBnom1.SelectedIndex].ToString() + CBnom2.Items[CBnom2.SelectedIndex].ToString();
            }
        }

        private void BTaleat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int t1, t2;
                t1 = rnd.Next(0, CBnom1.Items.Count);
                t2 = rnd.Next(0, CBnom2.Items.Count);

                ltitulo.Visible = true;
                ltitulo.Text = CBnom1.Items[t1].ToString() + CBnom2.Items[t2].ToString();
            
        }
    }
}

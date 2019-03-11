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

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargaFichero("gatitos.txt");
        }

        string[] a;
        bool modificando = false; //Para cuando se guarda modificando o sin modificar.

        public void CargaFichero(string fichero)
        {
            listView1.Items.Clear();
            int i;

            StreamReader sr = new StreamReader(fichero, Encoding.Default);

            a = sr.ReadLine().Split(',');
            
            for (i = 0; i < a.Length; i++)
            {
                listView1.Columns.Add(a[i]);
            }

            while (!sr.EndOfStream)
            {
                a = sr.ReadLine().Split(',');

                ListViewItem lvi = new ListViewItem(a[0]);

                for (i = 1; i < a.Length; i++)
                {
                    lvi.SubItems.Add(a[i]);
                }

                listView1.Items.Add(lvi);
            }

            sr.Close();

        }

        public void ActivarTB()
        {
            TBnombre.Enabled = true;
            TBojos.Enabled = true;
            TBpelo.Enabled = true;
            TBpeso.Enabled = true;
            TBraza.Enabled = true;
            TBtamano.Enabled = true;
        }

        public void DesactivarTB()
        {
            TBnombre.Enabled = false;
            TBojos.Enabled = false;
            TBpelo.Enabled = false;
            TBpeso.Enabled = false;
            TBraza.Enabled = false;
            TBtamano.Enabled = false;
        }

        public void LimpiarTB()
        {
            TBnombre.Text = "";
            TBojos.Text = "";
            TBpelo.Text = "";
            TBpeso.Text = "";
            TBraza.Text = "";
            TBtamano.Text = "";
        }

        private void BTnuevo_Click(object sender, EventArgs e)
        {
            LimpiarTB();
            ActivarTB();
            BTmodif.Enabled = false;
            BTnuevo.Enabled = false;
            BTguardar.Enabled = true;
        }

        private void BTguardar_Click(object sender, EventArgs e)
        {
            if(modificando == false)
            {
                if(TBnombre.Text != "")
                {
                    ListViewItem lvi = new ListViewItem(TBnombre.Text);
                    lvi.SubItems.Add(TBpelo.Text);
                    lvi.SubItems.Add(TBraza.Text);
                    lvi.SubItems.Add(TBpeso.Text);
                    lvi.SubItems.Add(TBtamano.Text);
                    lvi.SubItems.Add(TBojos.Text);

                    listView1.Items.Add(lvi);

                    LimpiarTB();
                    DesactivarTB();
                    BTnuevo.Enabled = true;
                    BTguardar.Enabled = false;
                }
            }
            else
            {
                if(listView1.SelectedIndices.Count > 0)
                {
                    int pos;
                    pos = listView1.SelectedIndices[0];

                    listView1.Items[pos].Text = TBnombre.Text;
                    listView1.Items[pos].SubItems[1].Text = TBpelo.Text;
                    listView1.Items[pos].SubItems[2].Text = TBraza.Text;
                    listView1.Items[pos].SubItems[3].Text = TBpeso.Text;
                    listView1.Items[pos].SubItems[4].Text = TBtamano.Text;
                    listView1.Items[pos].SubItems[5].Text = TBojos.Text;

                    LimpiarTB();
                    DesactivarTB();
                    BTnuevo.Enabled = true;
                    BTguardar.Enabled = false;
                }
            }
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            int pos;

            if(listView1.SelectedIndices.Count > 0)
            {
                pos = listView1.SelectedIndices[0];

                listView1.Items.RemoveAt(pos);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                BTmodif.Enabled = true;
                BTborrar.Enabled = true;
            }
            else
            {
                BTmodif.Enabled = false;
                BTborrar.Enabled = false;
            }
        }

        private void BTmodif_Click(object sender, EventArgs e)
        {
            ActivarTB();
            int pos;
            pos = listView1.SelectedIndices[0];

            TBnombre.Text = listView1.Items[pos].Text;
            TBpelo.Text = listView1.Items[pos].SubItems[1].Text;
            TBraza.Text = listView1.Items[pos].SubItems[2].Text;
            TBpeso.Text = listView1.Items[pos].SubItems[3].Text;
            TBtamano.Text = listView1.Items[pos].SubItems[4].Text;
            TBojos.Text = listView1.Items[pos].SubItems[5].Text;

            BTmodif.Enabled = false;
            BTnuevo.Enabled = false;
            BTborrar.Enabled = false;
            BTguardar.Enabled = true;
            modificando = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i, j;
            StreamWriter sw = new StreamWriter("gatitos.txt");
            sw.WriteLine("Nombre,Pelo,Raza,Peso,Tamaño,Ojos");
            string cadena = "";

            for (i = 0; i < listView1.Items.Count; i++)
            {
                for (j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    cadena = cadena + listView1.Items[i].SubItems[j].Text + ",";
                }
                sw.WriteLine(cadena);
                cadena = "";
            }
            sw.Close();
        }
    }
}

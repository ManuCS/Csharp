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

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Carga(string fichero)
        {
            listView1.Clear();

            int i;
            string[] a;

            if (File.Exists(fichero))
            {
                StreamReader sr = new StreamReader(fichero);

                a = sr.ReadLine().Split(';');

                for(i = 0; i < a.Length; i++)
                {
                    listView1.Columns.Add(a[i]);
                }

                while (!sr.EndOfStream)
                {
                    a = sr.ReadLine().Split(';');

                    ListViewItem lvi = new ListViewItem(a[0]);

                    for(i = 1; i < a.Length; i++)
                    {
                        lvi.SubItems.Add(a[i]);
                    }

                    listView1.Items.Add(lvi);
                }

                sr.Close();
            }

        }

        private void BTcarga_Click(object sender, EventArgs e)
        {
            Carga(TBfichero.Text);
        }
    }
}

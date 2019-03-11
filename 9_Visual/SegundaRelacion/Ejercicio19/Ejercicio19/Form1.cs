using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrearBotones();
            PintarBotones();
        }

        List<Button> listabotones = new List<Button>();

        private void CrearBotones()
        {
            int i, pos1 = 0, pos2 = 0;


            for (i = 0; i < 64; i++)
            {
                Button b = new Button();
                b.Location = new Point(pos2, pos1);
                b.Click += new EventHandler(PonerColor);
                panel1.Controls.Add(b);
                listabotones.Add(b);
                pos2 += 100;
                if (pos2 == 400)
                {
                    pos2 = 0;
                    pos1 += 30;
                }
            }


        }

        private void PintarBotones()
        {
            for (int i = 0; i < listabotones.Count; i++)
            {
                listabotones[i].Text = (i + 1).ToString();
                listabotones[i].BackColor = Color.Lime;

            }
        }

        private void PonerColor(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (!(b.BackColor == Color.Red))
            {
                if (b.BackColor == Color.Lime)
                {
                    b.BackColor = Color.Yellow;
                }
                else
                {
                    b.BackColor = Color.Lime;
                }
            }
        }

        private bool ContarAmarillos()
        {
            int i, amarillos = 0;

            for (i = 0; i < listabotones.Count; i++)
            {
                if (listabotones[i].BackColor == Color.Yellow)
                {
                    amarillos++;
                }
            }
            if (amarillos > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void BTguardar_Click(object sender, EventArgs e)
        {
            string plazas = "Plazas: ";

            if (ContarAmarillos() == false)
            {
                MessageBox.Show("Debes eligir las plazas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < listabotones.Count; i++)
                {
                    if (listabotones[i].BackColor == Color.Yellow)
                    {
                        plazas = plazas + (i + 1).ToString() + " ";
                        listabotones[i].BackColor = Color.Red;
                    }
                }
                ListViewItem lvi = new ListViewItem(textBox1.Text);
                lvi.SubItems.Add(plazas);

                listView1.Items.Add(lvi);
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                BTguardar.Enabled = false;
            }
            else
            {
                BTguardar.Enabled = true;
            }
        }
    }
}


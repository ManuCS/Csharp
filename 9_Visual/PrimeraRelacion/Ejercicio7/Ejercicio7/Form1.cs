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

namespace Ejercicio7
{
    public partial class Form1 : Form
    {

        static DateTime fecha = System.DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            TBdia.Text = fecha.Day.ToString();
            TBmes.Text = fecha.Day.ToString();
            TByear.Text = fecha.Day.ToString();
            if (File.Exists(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt"))
            {
                StreamReader sr = new StreamReader(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt", Encoding.Default);

                TBagenda.Text = sr.ReadToEnd();

                sr.Close();
            }
            else
            {
                TBagenda.Text = "";
            }
        }

        private void BTanterior_Click(object sender, EventArgs e)
        {

        }
    }
}

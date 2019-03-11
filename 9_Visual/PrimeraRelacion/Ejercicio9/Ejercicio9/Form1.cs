using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static int NumeroVocales(string cadena)
        {
            int i, vocales;

            vocales = 0;

            cadena = cadena.ToLower();

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                {
                    vocales++;
                }
            }

            return vocales;
        }


        static int CuentaPalabras(string cadena)
        {
            string[] palabras;

            while (cadena.Contains("  "))
            {
                cadena = cadena.Replace("  ", " ");
            }

            cadena = cadena.TrimEnd();
            cadena = cadena.TrimStart();

            palabras = cadena.Split(' ');
            if (cadena == "" || cadena == " ")
            {
                return 0;
            }
            else
            {
                int pal = palabras.Length;
                return pal;
            }
        }


        static int NumeroEspacios(string cadena)
        {
            int i, espacios;

            espacios = 0;

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    espacios++;
                }
            }

            return espacios;
        }


        static int NumeroLetras(string cadena)
        {
            int i,cont;
            cont = 0;

            for(i = 0; i < cadena.Length; i++)
            {
                if (char.IsLetter(cadena[i]))
                {
                    cont++;
                }
            }

            return cont;
        }


        static int NumeroConsonantes(string cadena)
        {
            int i, cont;
            cont = 0;
            cadena = cadena.ToLower();

            string vocales = "aeuioáéíïóú";

            for (i = 0; i < cadena.Length; i++)
            {
                if (!vocales.Contains(cadena[i]) && char.IsLetter(cadena[i]))
                {
                    cont++;
                }
            }
            return cont;
        }


        private void TBtexto_TextChanged(object sender, EventArgs e)
        {
            labelNpalabras.Text = CuentaPalabras(TBtexto.Text).ToString();
            labelNvocales.Text = NumeroVocales(TBtexto.Text).ToString();
            labelNespacios.Text = NumeroEspacios(TBtexto.Text).ToString();
            labelNletras.Text = NumeroLetras(TBtexto.Text).ToString();
            labelNconsonantes.Text = NumeroConsonantes(TBtexto.Text).ToString();
        }
    }
}

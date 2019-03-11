using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<int> listaRespuesta = new List<int>();
        int aciertos;
        int pregunta = 1;

        public int CalculaResultado()
        {
            aciertos = 0;

            if(listaRespuesta[0] == 1)
            {
                aciertos++;
            }
            if(listaRespuesta[1] == 1)
            {
                aciertos++;
            }
            if (listaRespuesta[2] == 3)
            {
                aciertos++;
            }
            if (listaRespuesta[3] == 2)
            {
                aciertos++;
            }
            if (listaRespuesta[4] == 3)
            {
                aciertos++;
            }
            return aciertos;
        }

        public int Respuesta()
        {
            if(RBres1.Checked == true)
            {
                return 1;
            }
            else
            {
                if (RBres2.Checked == true)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
        
        private void BTmuestra_Click(object sender, EventArgs e)
        {
            

            switch (pregunta)
            {
                case 1:
                    groupBox1.Visible = true;
                    BTmuestra.Text = "Continuar";
                    lpreguntas.Text = "¿Quién es Harry Potter?";
                    RBres1.Text = "El niño que vivió";
                    RBres2.Text = "Un ratón";
                    RBres3.Text = "Una película";

                    pregunta++;
                    break;

                case 2:
                    listaRespuesta.Add(Respuesta());

                    lpreguntas.Text = "¿Qué hechizo inventó Severus Snape?";
                    RBres1.Text = "Sectumsempra";
                    RBres2.Text = "Serpensortia";
                    RBres3.Text = "Expecto Patronum";

                    pregunta++;
                    break;

                case 3:
                    listaRespuesta.Add(Respuesta());

                    lpreguntas.Text = "¿Quién es Merope Gaunt?";
                    RBres1.Text = "Miembro de la Orden del Fénix";
                    RBres2.Text = "Madre de Draco Malfoy";
                    RBres3.Text = "Madre de Voldemort";

                    pregunta++;
                    break;

                case 4:
                    listaRespuesta.Add(Respuesta());

                    lpreguntas.Text = "¿Qué articulo inventaron los gemelos Weasly?";
                    RBres1.Text = "Zumo con sabor a vómito";
                    RBres2.Text = "Orejas extensibles";
                    RBres3.Text = "Pergamino insultante";

                    pregunta++;
                    break;
                case 5:
                    listaRespuesta.Add(Respuesta());

                    lpreguntas.Text = "Dueño de la varita de Sauco despues de Dumpledore:";
                    RBres1.Text = "Severus Snape";
                    RBres2.Text = "Harry Potter";
                    RBres3.Text = "Draco Malfoy";

                    pregunta++;
                    break;

                case 6:
                    listaRespuesta.Add(Respuesta());
                    groupBox1.Visible = false;
                    BTmuestra.Text = "Reiniciar";
                    if(CalculaResultado() == 5)
                    {
                        lpreguntas.Text = "¡Eres un mago!, has acertado " + CalculaResultado() + " preguntas";
                    }
                    else
                    {
                        if(CalculaResultado() >= 3)
                        {
                            lpreguntas.Text = "Has acertado " + CalculaResultado() + " preguntas";
                        }
                        else
                        {
                            lpreguntas.Text = "¡MUGGLE DETECTADO!, Has acertado " + CalculaResultado() + " preguntas";
                        }
                    }
                    pregunta = 1;
                    aciertos = 0;
                    listaRespuesta.Clear();
                    break;
            }
        }
    }
}

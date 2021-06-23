using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1.Forms
{
    public partial class Jugar : Form
    {
        PictureBox[,] PictureBoxCartas = new PictureBox[6, 6];
        Label[,] LabelsJugadores = new Label[6, 6];
        int[] numCartasPorJugador = new int[6];

        public Jugar()
        {
            InitializeComponent();
            Repartir.Visible = false;
            {
                //Organizamos todos los PictureBox en la matriz PictureBoxCartas
                PictureBoxCartas[0, 0] = Carta1;
                PictureBoxCartas[0, 1] = Carta2;
                PictureBoxCartas[0, 2] = Carta3;
                PictureBoxCartas[0, 3] = Carta4;
                PictureBoxCartas[0, 4] = Carta5;
                PictureBoxCartas[0, 5] = Carta6;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {

                        PictureBoxCartas[0, j].ImageLocation = "Espalda.jpg";
                    }
                }

            }
        }
        private void Jugar_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Portada.jpg";
            pictureBox2.ImageLocation = "Instrucciones.jpg";
            //Organizamos todos los PictureBox en la matriz PictureBoxCartas
            PictureBoxCartas[0, 0] = Carta1;
            PictureBoxCartas[0, 1] = Carta2;
            PictureBoxCartas[0, 2] = Carta3;
            PictureBoxCartas[0, 3] = Carta4;
            PictureBoxCartas[0, 4] = Carta5;
            PictureBoxCartas[0, 5] = Carta6;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                { 
                    PictureBoxCartas[0, j].ImageLocation = "Portada.jpg";
                }
            }

        }

        private void Barajar_Click(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"Barajar.wav");
            simpleSound.Play();
            Repartir.Visible = true;
        }
        public string AsignarImagenCarta(string numrand)
        {
            //A partir del numero rand, retornamos la imagen.jpg

                switch (numrand)
                {
                    case "1":
                        numrand = "Gyoza";
                        break;

                    case "2":
                        numrand = "Maki1";
                        break;

                    case "3":
                        numrand = "Maki2";
                        break;

                    case "4":
                        numrand = "Maki3";
                        break;

                    case "5":
                        numrand = "Nigiri1";
                        break;

                    case "6":
                        numrand = "Nigiri2";
                        break;

                    case "7":
                        numrand = "Nigiri3";
                        break;

                    case "8":
                        numrand = "Tofu";
                        break;

                    case "9":
                        numrand = "Pudin";
                        break;

                    case "10":
                        numrand = "Sashimi";
                        break;

                    case "11":
                        numrand = "Tempura";
                        break;

                    case "12":
                        numrand = "Wasabi";
                        break;

                    default:
                        break;
                }

                return numrand;
        }

        public void Repartir_Click(object sender, EventArgs e)
        {
            //Asignamos a cartas el nombre de sus imagenes correspondientes
            string carta;
            string numrand;
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                numrand = Convert.ToString(r.Next(1, 13));
                carta = AsignarImagenCarta(numrand);

                //Insertamos la imagen de cada carta de mi jugador
                PictureBoxCartas[0, i].ImageLocation = carta + ".jpg";
            }
        }

        private void Jugar_Load_1(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Portada.jpg";
            pictureBox1.ImageLocation = "Instrucciones.jpg";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Instrucciones instrucciones = new Instrucciones();
            instrucciones.ShowDialog();


        }

    }
}

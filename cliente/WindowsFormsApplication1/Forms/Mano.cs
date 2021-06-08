using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class Mano : Form
    {
        int[] IdCarta;
        Socket server;
        int numcartas;
        string NombreCarta;
        PictureBox[,] PictureBoxCartas = new PictureBox[10, 10];

        public Mano(int[] Id, Socket server, int numcartas)
        {
            InitializeComponent();
            this.IdCarta = Id;
            this.server = server;
            this.numcartas = numcartas;
            {
                //Organizamos todos los PictureBox en la matriz PictureBoxCartas
                PictureBoxCartas[0, 0] = carta1;
                PictureBoxCartas[0, 1] = carta2;
                PictureBoxCartas[0, 2] = carta3;
                PictureBoxCartas[0, 3] = carta4;
                PictureBoxCartas[0, 4] = carta5;
                PictureBoxCartas[0, 5] = carta6; 
                PictureBoxCartas[0, 6] = carta7;
                PictureBoxCartas[0, 7] = carta8;
                PictureBoxCartas[0, 8] = carta9;
                PictureBoxCartas[0, 9] = carta10;

            }
        }

        private void Mano_Load(object sender, EventArgs e)
        { 

                for (int j = 0; j < numcartas; j++)
                {
                    NombreCarta = AsignarImagenCarta(IdCarta[j]);
                    PictureBoxCartas[0, j].ImageLocation = NombreCarta + ".jpg";
                }
        }
        public string AsignarImagenCarta(int IdCarta)
        {
            //A partir del numero rand, retornamos la imagen.jpg
            switch (IdCarta)
            {
                case 1:
                    NombreCarta = "Tempura";
                    break;

                case 2:
                    NombreCarta = "Sashimi";
                    break;

                case 3:
                    NombreCarta = "Gyoza";
                    break;

                case 4:
                    NombreCarta = "Maki1";
                    break;

                case 5:
                    NombreCarta = "Maki2";
                    break;

                case 6:
                    NombreCarta = "Maki3";
                    break;

                case 7:
                    NombreCarta = "Nigiri1";
                    break;

                case 8:
                    NombreCarta = "Nigiri2";
                    break;

                case 9:
                    NombreCarta = "Nigiri3";
                    break;

                case 10:
                    NombreCarta = "Pudin";
                    break;

                case 11:
                    NombreCarta = "Wasabi";
                    break;

                case 12:
                    NombreCarta = "Palillos";
                    break;

                default:
                    break;
            }
            return NombreCarta;
        }
    }
}

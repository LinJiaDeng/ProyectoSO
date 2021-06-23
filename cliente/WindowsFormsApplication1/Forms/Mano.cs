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
        int ID_Partida;
        int numjugadores;
        int temp = 40;
        int seleccionado = -1;
        int c = 0;
        int MAX = 10;



        public Mano(int[] Id, Socket server, int numcartas, int ID_Partida, int numjugadores)
        {
            InitializeComponent();
            this.IdCarta = Id;
            this.server = server;
            this.numcartas = numcartas;
            this.ID_Partida = ID_Partida;
            this.numjugadores = numjugadores;
            ControlBox = false;
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

        private void Mano_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Text = "Mano ID: " + ID_Partida;
            seleccionado = -1;
            int j = 0;
            while (j < numcartas)
            {
                NombreCarta = AsignarImagenCarta(IdCarta[j]);
                PictureBoxCartas[0, j].ImageLocation = NombreCarta + ".jpg";
                j++;
            }
            while (j < MAX)
            {
                PictureBoxCartas[0, j].Visible = false;
                j++;
            }
        }
        public string AsignarImagenCarta(int IdCarta)
        {
            //A partir del numero rand, retornamos la imagen.jpg
            switch (IdCarta)
            {
                case 0:
                    NombreCarta = "Tempura";
                    break;

                case 1:
                    NombreCarta = "Sashimi";
                    break;

                case 2:
                    NombreCarta = "Gyoza";
                    break;

                case 3:
                    NombreCarta = "Maki1";
                    break;

                case 4:
                    NombreCarta = "Maki2";
                    break;

                case 5:
                    NombreCarta = "Maki3";
                    break;

                case 6:
                    NombreCarta = "Nigiri1";
                    break;

                case 7:
                    NombreCarta = "Nigiri2";
                    break;

                case 8:
                    NombreCarta = "Nigiri3";
                    break;

                case 9:
                    NombreCarta = "Pudin";
                    break;

                case 10:
                    NombreCarta = "Wasabi";
                    break;

                case 11:
                    NombreCarta = "Tofu";
                    break;

                default:
                    break;
            }
            return NombreCarta;
        }

        private void carta1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[0] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 0)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[0];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[1] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 1)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            seleccionado = IdCarta[1];
            Close();
        }

        private void carta3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[2] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 2)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            seleccionado = IdCarta[2];
            Close();
        }

        private void carta4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[3] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 3)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            seleccionado = IdCarta[3];
            Close();
        }

        private void carta5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[4] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 4)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[4];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[5] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 5)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[5];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[6] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 6)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[6];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[7] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 7)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[7];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[8] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 8)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[8];
            Inicio.server.Send(msg);
            Close();
        }

        private void carta10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[9] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != 9)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            seleccionado = IdCarta[9];
            Inicio.server.Send(msg);
            Close();
        }

        public void EscogeCartaRNG()
        {
            Random RNG = new Random();
            int rng = RNG.Next(0, numcartas);
            numcartas--;
            string mensaje = "11/" + Inicio.N + "/" + ID_Partida + "/" + IdCarta[rng] + "/" + numcartas;
            while (c <= numcartas)
            {
                if (c != rng)
                    mensaje = mensaje + "/" + IdCarta[c];
                c++;
            }
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                timer1.Stop();
                if (seleccionado == -1)
                {
                    EscogeCartaRNG();
                }
            }
                temporizadorTmr.Text = "" + temp--;
            
        }
    }
}

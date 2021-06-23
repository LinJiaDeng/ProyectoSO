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
using System.Media;

namespace WindowsFormsApplication1.Forms
{
    public partial class Resultados : Form
    {

        string[] jugadores = new string[5];
        int[] puntosTotales = new int[5];
        int[] puding = new int[5];
        int ID_partida;
        int numParticipantes;
        int PuntosMAX = 0;
        int k;
        int primeroPudin = 0;
        int ultimoPudin = 99;


        public Resultados(Socket server, string[] jugadores, int[] puntosTotales, int ID_partida,int numParticipantes, int[]puding)
        {
            InitializeComponent();

            SoundPlayer simpleSound = new SoundPlayer(@"final.wav");
            simpleSound.Play();
            podio.ImageLocation = "podio.png";


            this.jugadores = jugadores;
            this.puntosTotales = puntosTotales;
            this.ID_partida = ID_partida;
            this.numParticipantes = numParticipantes;
            this.puding = puding;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pos1=-1;
            int pos2 = -1;
            for (int f = 0; f < numParticipantes; f++)
            {
                if (puding[f] > primeroPudin)
                {
                    primeroPudin = puding[f];
                    pos1 = f;
                }
                if (puding[f] < ultimoPudin)
                {
                    ultimoPudin = puding[f];
                    pos2 = f;
                }

            }
            if (pos1 != -1)
            {
                puntosTotales[pos1] = puntosTotales[pos1] + 6;
            }
            if (pos2 != -1)
            {
                puntosTotales[pos2] = puntosTotales[pos2] - 6;
            }
            j1Lbl.Text = jugadores[0] + " ha conseguido un total de " + puntosTotales[0] + " puntos!" ;
            j2Lbl.Text = jugadores[1] + " ha conseguido un total de " + puntosTotales[1] + " puntos!";
            if (numParticipantes >= 3)
            {
                j3Lbl.Visible = true;
                j3Lbl.Text = jugadores[2] + ": " + puntosTotales[2] + " puntos!";

                if (numParticipantes >= 4)
                {
                    j4Lbl.Visible = true;
                    j4Lbl.Text = jugadores[3] + ": " + puntosTotales[3] + " puntos!";

                    if (numParticipantes == 5)
                    {
                        j5Lbl.Visible = true;
                        j5Lbl.Text = jugadores[4] + ":" + puntosTotales[4] + " puntos!";

                    }

                }
            }
            int i = 0;
            while (i < numParticipantes)
            {
                if (puntosTotales[i] > PuntosMAX)
                {
                    PuntosMAX = puntosTotales[i];
                    k = i;
                }
                i++;
            }
            ganadorLbl.Text = "#1" + jugadores[k];
            switch (numParticipantes)
            {
                case 2:
                    if (Inicio.N == jugadores[0])
                    {
                        string mensaje = "16/" + Inicio.N + "/" + jugadores[k] + "/" + PuntosMAX + "/" + numParticipantes + "/" + jugadores[0] + "/" + jugadores[1];
                        byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                        Inicio.server.Send(msg);
                    }
                    break;
                case 3:
                    if (Inicio.N == jugadores[0])
                    {
                        string mensaje = "16/" + Inicio.N + "/" + jugadores[k] + "/" + PuntosMAX + "/" + numParticipantes + "/" + jugadores[0] + "/" + jugadores[1] + "/" +jugadores[2];
                        byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                        Inicio.server.Send(msg);
                    }
                    break;
                case 4:
                    if (Inicio.N == jugadores[0])
                    {
                        string mensaje = "16/" + Inicio.N + "/" + jugadores[k] + "/" + PuntosMAX + "/" + numParticipantes + "/" + jugadores[0] + "/" + jugadores[1] + "/" + jugadores[2] + "/" + jugadores[3];
                        byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                        Inicio.server.Send(msg);
                    }
                    break;
                case 5:
                    if (Inicio.N == jugadores[0])
                    {
                        string mensaje = "16/" + Inicio.N + "/" + jugadores[k] + "/" + PuntosMAX + "/" + numParticipantes + "/" + jugadores[0] + "/" + jugadores[1] + "/" + jugadores[2] + "/" + jugadores[3] + "/" + jugadores[4];
                        byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                        Inicio.server.Send(msg);
                    }
                    break;
            }
            
        }




    }
}

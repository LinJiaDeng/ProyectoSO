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

namespace WindowsFormsApplication1
{
    public partial class Lobby : Form
    {

        int ID_Partida;
        Socket server;
        delegate void DelegadochatLbl(string nombreMsg, string chat);
        delegate void DelegadonumParticipantes(int numParticipantes);
        public bool clicked = false;
        int lineasChat;
        int numParticipantes;


        public Lobby(int ID_Partida, Socket server, int numParticipantes)
        {
            InitializeComponent();
            this.ID_Partida = ID_Partida;
            this.server = server;
            this.numParticipantes = numParticipantes;
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "/")
            {
                string mensaje = "8/" + Inicio.N + "/" + ID_Partida + "/" + textBox1.Text;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                Inicio.server.Send(msg);
                textBox1.Clear();
            }
        }

        public void tomaRespuesta(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {
                case 9:
                    DelegadochatLbl delegado = new DelegadochatLbl(EscribirMensaje);
                    Invoke(delegado, new object[] { respuesta[1], respuesta[3] });
                    if (respuesta.Length == 5)
                    {
                        DelegadonumParticipantes delegadoNumParticipantes = new DelegadonumParticipantes(EscribirNumParticipantes);
                        Invoke(delegadoNumParticipantes, new object[] { Convert.ToInt32(respuesta[4]) });
                    }
                    break;
            }
        }
        public void EscribirNumParticipantes(int numParticipantes)
        {
            numJugadoresLbl.Text = "Jugadores: " + numParticipantes + "/5";
            this.numParticipantes = numParticipantes;
        }

        public void EscribirMensaje(string nombreMsg, string mensajeChat)
        {
            lineasChat += (mensajeChat.Length / 32 + 1);
            if (lineasChat > 28)
            {
                string[] separado = chatLbl.Text.Split('\n');
                chatLbl.Text = separado[1];
                for (int i = 2; i < separado.Length; i++)
                    chatLbl.Text = chatLbl.Text + '\n' + separado[i];
            }
            chatLbl.Text = chatLbl.Text + '\n' + mensajeChat;
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            partidaIdLbl.Text = "ID de la partida: " + ID_Partida;
            panel1.Enabled = false;
            panel1.Visible = false;
            lineasChat = 1;
            if (numParticipantes != 1)
            {
                empezarPartidaBtn.Visible = false;
                empezarPartidaBtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                panel1.Enabled = true;
                panel1.Visible = true;
                clicked = true;
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                clicked = false;
            }
        }

        private void empezarPartidaBtn_Click(object sender, EventArgs e)
        {
            string mensaje = "9/" + Inicio.N + "/" + ID_Partida;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);

            switch (numParticipantes)
            {
                case 1:
                    rondasLbl.Text = "No hay suficientes jugadores";
                    break;
                case 2:
                    panelM2.Visible = true;
                    panelM4.Visible = true;
                    break;
                case 3:
                    panelM1.Visible = true;
                    panelM3.Visible = true;
                    panelM5.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox10.Enabled = false;
                    pictureBox24.Visible = false;
                    pictureBox24.Enabled = false;
                    pictureBox46.Visible = false;
                    pictureBox46.Enabled = false;
                    break;
                case 4:
                    panelM1.Visible = true;
                    panelM2.Visible = true;
                    panelM3.Visible = true;
                    panelM4.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox9.Enabled = false;
                    pictureBox10.Visible = false;
                    pictureBox10.Enabled = false;
                    pictureBox13.Visible = false;
                    pictureBox13.Enabled = false;
                    pictureBox14.Visible = false;
                    pictureBox14.Enabled = false;
                    pictureBox24.Visible = false;
                    pictureBox24.Enabled = false;
                    pictureBox25.Visible = false;
                    pictureBox25.Enabled = false;
                    pictureBox35.Visible = false;
                    pictureBox35.Enabled = false;
                    pictureBox36.Visible = false;
                    pictureBox36.Enabled = false;
                    break;
                case 5:
                    panelM1.Visible = true;
                    panelM2.Visible = true;
                    panelM4.Visible = true;
                    panelM3.Visible = true;
                    panelM5.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox8.Enabled = false;
                    pictureBox9.Visible = false;
                    pictureBox9.Enabled = false;
                    pictureBox10.Visible = false;
                    pictureBox10.Enabled = false;
                    pictureBox13.Visible = false;
                    pictureBox13.Enabled = false;
                    pictureBox14.Visible = false;
                    pictureBox14.Enabled = false;
                    pictureBox15.Visible = false;
                    pictureBox15.Enabled = false;
                    pictureBox24.Visible = false;
                    pictureBox24.Enabled = false;
                    pictureBox25.Visible = false;
                    pictureBox25.Enabled = false;
                    pictureBox26.Visible = false;
                    pictureBox26.Enabled = false;
                    pictureBox35.Visible = false;
                    pictureBox35.Enabled = false;
                    pictureBox36.Visible = false;
                    pictureBox36.Enabled = false;
                    pictureBox37.Visible = false;
                    pictureBox37.Enabled = false;
                    pictureBox46.Visible = false;
                    pictureBox46.Enabled = false;
                    pictureBox47.Visible = false;
                    pictureBox47.Enabled = false;
                    pictureBox48.Visible = false;
                    pictureBox48.Enabled = false;
                    break;
                default:
                    break;
            }
            empezarPartidaBtn.Visible = false;
            empezarPartidaBtn.Enabled = false;
        }

    }
}

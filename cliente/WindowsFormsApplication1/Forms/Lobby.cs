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

        public Lobby(int ID_Partida, Socket server)
        {
            InitializeComponent();
            this.ID_Partida = ID_Partida;
            this.server = server;
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {        
            string mensaje = "8/" + Inicio.N +  "/" + ID_Partida + "/" + textBox1.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
        }

        public void tomaRespuesta(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {
                case 9:
                    DelegadochatLbl delegado = new DelegadochatLbl(EscribirMensaje);
                    this.Invoke(delegado,new object[]{respuesta[1],respuesta[3]});
                    break;
            }
        }

        public void EscribirMensaje(string nombreMsg, string mensajeChat)
        {
           
            chatLbl.Text = chatLbl.Text + Environment.NewLine + nombreMsg+": "+ mensajeChat;
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            partidaIdLbl.Text = "ID de la partida: " + ID_Partida;
        }

    }
}

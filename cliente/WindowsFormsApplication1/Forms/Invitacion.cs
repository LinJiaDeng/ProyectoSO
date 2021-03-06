using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Invitacion : Form
    {
        string host;
        int ID_Partida;

        public Invitacion(int ID_Partida, string host)
        {
            InitializeComponent();
            this.host = host;
            this.ID_Partida = ID_Partida;
        }

        private void Invitacion_Load(object sender, EventArgs e)
        {
            lblinvitacion.Text = this.host + " te ha invitado a una partida 😎👾.";
            ControlBox = false;
        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            string mensaje = "7/" + Inicio.N +  "/" + ID_Partida + "/1";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            this.Close();
        }

        private void rechazarbtn_Click(object sender, EventArgs e)
        {
            string mensaje = "7/" + Inicio.N + "/" + ID_Partida + "/0";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            this.Close();
        }
    }
}

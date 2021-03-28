using System;
using System.Collections.Generic;
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
    public partial class Perfil : Form
    {
        Socket server;
        IniciarSesion perfil = new IniciarSesion();

        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (PuntuacionRonda.Checked)
            {
                string mensaje = "3/" + perfil.txtnombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(perfil.txtnombre.Text + " tiene " + mensaje + " puntos");

            }
            else if (NumeroCartasMano.Checked)
            {
                string mensaje = "4/" + perfil.txtnombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(perfil.txtnombre.Text + " tiene " + mensaje + " cartas");
            }
            else if (puntuaciontotal.Checked)
            {
                string mensaje = "5/" + perfil.txtnombre.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(perfil.txtnombre.Text + " tiene " + mensaje + " puntos");
            }
        }
    }
}

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
       
        Inicio servidor = new Inicio();
       

        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (IniciarSesion.A == 1)
            {

                if (PuntuacionRonda.Checked)
                {
                    string mensaje = "3/" + IniciarSesion.N;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    Inicio.server.Send(msg);
                }
                else if (NumeroCartasMano.Checked)
                {
                    string mensaje = "4/" + IniciarSesion.N;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    Inicio.server.Send(msg);                
                }
                else if (puntuaciontotal.Checked)
                {
                    string mensaje = "5/" + IniciarSesion.N;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    Inicio.server.Send(msg);                                   
                }
            }
            else
                MessageBox.Show("No has iniciado sesión!");
        }
    }
}

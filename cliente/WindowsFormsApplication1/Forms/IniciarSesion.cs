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
using System.Threading;

namespace WindowsFormsApplication1.Forms
{
    public partial class IniciarSesion : Form
    {
        
        Inicio menu = new Inicio();
        public static int A;
        public static string N;
        bool RegisterCheck = false;

        public IniciarSesion()
        {
            InitializeComponent();
        }


        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }
 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (A != 1)
            {
               
                IniciarSesion.A = 1;
                IniciarSesion.N = txtnombre.Text;

    

                string mensaje = "2/" + txtnombre.Text + "/" + txtcontrasena.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                Inicio.server.Send(msg);                
                
            }
            else
                MessageBox.Show("Ya has iniciado una sesión debes desconectarte primero.");
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

           

            string mensaje = "1/" + txtnombre.Text + "/" + txtcontrasena.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            RegisterCheck = true;
        }
    }
}

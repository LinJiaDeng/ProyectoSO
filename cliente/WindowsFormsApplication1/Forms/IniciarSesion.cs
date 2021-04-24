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
                if (RegisterCheck == false)
                {

                }
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

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);


            //Creamos el socket 
            Inicio.server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                Inicio.server.Connect(ipep);//Intentamos conectar el socket

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                return;

            }

            string mensaje = "1/" + txtnombre.Text + "/" + txtcontrasena.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            RegisterCheck = true;
        }
    }
}

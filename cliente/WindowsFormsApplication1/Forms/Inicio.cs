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

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static Socket server;
        Thread atender;


        public Inicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color2 = Color.FromArgb(245, 66, 66);
            public static Color color3 = Color.FromArgb(245, 132, 66);
            public static Color color4 = Color.FromArgb(176, 245, 66);
            public static Color color5 = Color.FromArgb(66, 245, 102);
            public static Color color6 = Color.FromArgb(66, 245, 206);
        }

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0,0,0);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.ForeColor = color;
            }
        }

        private void DesactivarBoton()
        {
        if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0,0,0);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaConectados.Columns.Add("nombre","Jugadores online");

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);

            
            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                MessageBox.Show("Perfecto");
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                return;

            }
            

            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();
        }

        public void AtenderServidor ()
        {
            while (true)
            {
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string [] respuesta = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(respuesta[0]);
                string mensaje = respuesta[1].Split('\0')[0];

                switch (codigo)
                {
                    case 0:
                        MessageBox.Show(mensaje);
                        break;
                    case 1:
                        MessageBox.Show(mensaje + " se ha registrado correctamente, Ahora inicie sesión!");        
                        break;
                    case 2:
                        MessageBox.Show(mensaje + " ha iniciado sesión correctamente"); 
                        break;
                    case 3:
                        MessageBox.Show(IniciarSesion.N + " tiene " + mensaje + " puntos");
                        break;
                    case 4:
                        MessageBox.Show(IniciarSesion.N + " tiene " + mensaje + " cartas");
                        break;
                    case 5:
                        MessageBox.Show(IniciarSesion.N + " tiene " + mensaje + " puntos");
                        break;
                    case 6:
                        
                        break;
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            OpenChildForm(new IniciarSesion());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            OpenChildForm(new Perfil());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            OpenChildForm(new Jugar());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            OpenChildForm(new Instrucciones());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            OpenChildForm(new Créditos());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DesactivarBoton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Inicio";
            lblTitleChildForm.ForeColor = Color.White;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Windowed_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            if (IniciarSesion.A == 1)
            {
                //Mensaje de desconexión
                string mensaje = "0/" + IniciarSesion.N;

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                MessageBox.Show("Desconectado");

                // Nos desconectamos
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                atender.Abort();
                IniciarSesion.A = 0;
            }
            else
            {
                MessageBox.Show("Todavía no estás conectado!");
            }
        }
    }
}

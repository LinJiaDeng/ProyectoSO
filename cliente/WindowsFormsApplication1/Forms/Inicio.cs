using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using WindowsFormsApplication1.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication1
{
    //Version con anti-afk en estado alpha
    public partial class Inicio : Form
    {
        public Thread atender;
        Thread T;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static int A;
        public static string N;
        bool RegisterCheck = false;
        public static Socket server;
        delegate void DelegadoDataGridView(DataGridView ListaConectados);
        delegate void DelegadoRegistrarVisible(string btn);
        delegate void DelegadoModificarPerfil(string[] respuesta);
        delegate void DelegadoDataGridView2(DataGridView ListaConectados, string[] respuesta, int k);
        List<Lobby> partidas = new List<Lobby>();
        List<Mano> manos = new List<Mano>();



        public Inicio()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
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
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            ListaConectados.Visible = false;
            ListaConectados.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaConectados.ColumnCount = 1;
        }

        public void LimpiarDatagrid (DataGridView Listaconectados)
        {
            ListaConectados.Rows.Clear();
        }

        public void AñadirDatagrid (DataGridView ListaConectados, string[] respuesta, int k)
        {
            ListaConectados.Rows.Add(respuesta[k]);
        }

        public void ModificarDatosPerfil(string[] respuesta)
        {
            switch (Convert.ToInt32(respuesta[0]))
            {
                case 0:
                    nombrePerfilLbl.Text = "";
                    break;
                case 2:
                    nombrePerfilLbl.Text = N;
                    break;
            }
        }

        public void crearPartida(int IdPartida, int numParticipantes, string nombre)
        {     
            Lobby lobby = new Lobby(IdPartida,server,numParticipantes, nombre);
            partidas.Add(lobby);
            lobby.ShowDialog();
        }

        public void crearMano(int[] IdCarta, int numcartas, int ID_Partida, int numjugadores)
        {
            Mano mano = new Mano(IdCarta, server, numcartas, ID_Partida, numjugadores);
            manos.Add(mano);
            mano.ShowDialog();
        }
        public void AtenderServidor ()
        {
            while (true)
            {
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                //Limpiar el mensaje de basura
                string mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                string [] respuesta = mensaje.Split('/');
                int codigo = Convert.ToInt32(respuesta[0]);

                    switch (codigo)
                    {
                        case 0:
                            mensaje = respuesta[1];
                            lblconexion.ForeColor = Color.Black;
                            DelegadoModificarPerfil delegadoModificarPerfil = new DelegadoModificarPerfil(ModificarDatosPerfil);
                            Invoke(delegadoModificarPerfil, new object[] { respuesta });
                            //lblconexion.Text = mensaje;
                            atender.Abort();
                            break;
                        case 1:
                            mensaje = respuesta[1];
                            if (mensaje == "err") // En caso de querer registrarse con un usuario ya existente
                            {
                                MessageBox.Show("Este usuario ya existe!");
                                A = 0;
                                server.Shutdown(SocketShutdown.Both);
                                server.Close();
                                atender.Abort();
                            }
                            else
                            {
                                RegisterCheck = true;
                                MessageBox.Show(mensaje + " se ha registrado correctamente, Ahora inicie sesión!");
                            }
                            break;
                        case 2:
                            mensaje = respuesta[1];
                            if (mensaje == "err1") // En caso de querer iniciar sesión con un usuario no existente
                            {
                                A = 0;
                                MessageBox.Show("Este usuario no existe!");
                                server.Shutdown(SocketShutdown.Both);
                                server.Close();
                                atender.Abort();
                            }
                            else if (mensaje == "err2") // Si ya se ha iniciado sesión con esa cuenta
                            {
                                 A = 0;
                                 MessageBox.Show("Este usuario ya ha iniciado sesion");
                                 server.Shutdown(SocketShutdown.Both);
                                 server.Close();
                                 atender.Abort();
                            }
                            else
                            {
                                MessageBox.Show(mensaje + " ha iniciado sesión correctamente");
                                //lblconexion.Text = "Conectado";
                                delegadoModificarPerfil = new DelegadoModificarPerfil(ModificarDatosPerfil);
                                Invoke(delegadoModificarPerfil, new object[] { respuesta });
                                btnRegistrarse.Invoke(new DelegadoRegistrarVisible(PonInvisible), new object[] { "btnRegistrarse" });
                                lblconexion.ForeColor = Color.Green;
                            }
                            break;
                        case 3:
                              mensaje = respuesta[1];
                              if (mensaje == "err3") // Error al eliminar un usuario inexistente
                              {
                              A = 0;
                              MessageBox.Show("Este usuario no existe!");
                              server.Shutdown(SocketShutdown.Both);
                              server.Close();
                              atender.Abort();
                              }
                              else
                              {
                                 MessageBox.Show(mensaje + " se ha dado de baja correctamente");
                              }
                             break;
                        case 4:
                             mensaje = respuesta[1];
                             DelegadoRegistrarVisible delegadoModificarPeticion2 = new DelegadoRegistrarVisible(Peticion2);
                                peticion2Lbl.Invoke(delegadoModificarPeticion2, new object[] { mensaje });
                            break;
                        case 5:
                                mensaje = respuesta[1];
                                DelegadoRegistrarVisible delegadoModificarPeticion = new DelegadoRegistrarVisible(Peticion1);
                                peticion1Lbl.Invoke(delegadoModificarPeticion, new object[] { mensaje });

                            break;
                        case 6:
                            //ListaConectados.Rows.Clear();
                            int numConectados = Convert.ToInt32(respuesta[1]);
                            DelegadoDataGridView delegado = new DelegadoDataGridView(LimpiarDatagrid);
                            ListaConectados.Invoke(delegado, new object[] { ListaConectados });
                            int j = 0, k = 2;
                            DelegadoDataGridView2 delegado2 = new DelegadoDataGridView2(AñadirDatagrid);
                            while (j < numConectados)
                            {
                                //ListaConectados.Rows.Add(respuesta[k]);
                                ListaConectados.Invoke(delegado2, new object[] { ListaConectados, respuesta, k });
                                j++;
                                k++;
                            }
                            break;
                        case 7:
                            //Llega una invitación, mostramos el mensaje al usuario.
                            int IdPartida = Convert.ToInt32(respuesta[1]);
                            string host = respuesta[2];
                            Invitacion invitacion = new Invitacion(IdPartida, host);
                            invitacion.ShowDialog();
                            break;
                        case 8:
                            IdPartida = Convert.ToInt32(respuesta[1]);
                            int numParticipantes = Convert.ToInt32(respuesta[2]);
                            string nombre = respuesta[3];
                            ThreadStart ts = delegate { crearPartida(IdPartida,numParticipantes, nombre); };
                            T = new Thread(ts);
                            T.Start();
                            break;
                        case 9:
                            IdPartida = Convert.ToInt32(respuesta[2]);
                            partidas[IdPartida].tomaRespuesta(respuesta);
                            break;
                        case 10:
                            MessageBox.Show("La partida esta llena");
                            break;
                        case 11:
                            IdPartida = Convert.ToInt32(respuesta[1]);
                            partidas[IdPartida].configurarPartida(Convert.ToInt32(respuesta[2]));
                            break;
                        case 12:
                        //Recibimos la ID de las cartas repartidas
                            IdPartida = Convert.ToInt32(respuesta[1]);
                            int numjugadores = Convert.ToInt32(respuesta[2]);
                            int numCartas = Convert.ToInt32(respuesta[3]);
                            
                                int[] IdCarta = new int[10];
                                int n = 0;
                                int m = 4;
                                while (n < numCartas)
                                {
                                    IdCarta[n] = Convert.ToInt32(respuesta[m]);
                                    n++;
                                    m++;
                                }
                                if (numCartas != 0)
                                {
                                    ts = delegate { crearMano(IdCarta, numCartas, IdPartida, numjugadores); };
                                    T = new Thread(ts);
                                    T.Start();
                                    SoundPlayer simpleSound = new SoundPlayer(@"repartir.wav");
                                    simpleSound.Play();
                        }
                                else {
                                        partidas[IdPartida].AsignarPuntuacionRonda(numjugadores);
                                     }
                                    
                              
                            
                            break;
                        case 13:
                        
                        IdPartida = Convert.ToInt32(respuesta[1]);
                    
                        partidas[IdPartida].tomaRespuesta(respuesta);
                        
                            break;
                        case 14:

                            IdPartida = Convert.ToInt32(respuesta[1]);
                        partidas[IdPartida].tomaRespuesta(respuesta);
                        break;

                        case 15:
                            IdPartida = Convert.ToInt32(respuesta[1]);
                            partidas[IdPartida].VaciarTabla();
                        break;
                        case 16:
                        IdPartida = Convert.ToInt32(respuesta[1]);
                        partidas[IdPartida].EscribirPuntuacion(respuesta);
                        break;
                        case 17:
                            IdPartida = Convert.ToInt32(respuesta[1]);
                    
                            partidas[IdPartida].tomaRespuesta(respuesta);
                           break;

                        default:
                            break;
                    }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Sección de Iniciar sesión
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivarBoton(sender, RGBColors.color2);
            lblName.Visible = true;
            sushi.Visible = false;
            lblName.Enabled = true;
            peticion1Lbl.Visible = false;
            lblContrasena.Visible = true;
            lblContrasena.Enabled = true;
            txtnombre.Visible = true;
            txtnombre.Enabled = true;
            txtcontrasena.Visible = true;
            txtcontrasena.Enabled = true;
            btnIniciarSesion.Visible = true;
            btnIniciarSesion.Enabled = true;
            btnRegistrarse.Visible = true;
            btnRegistrarse.Enabled = true;
            Desconectarbtn.Visible = true;
            Desconectarbtn.Enabled = true;
            ListaConectados.Visible = true;
            ListaConectados.Enabled = true;
            invitarbtn.Visible = true;
            peticion2Lbl.Visible = false; 
            invitarbtn.Enabled = true;
            nombrePerfilLbl.Visible = false;
            nombrePerfilLbl.Enabled = false;
            darseDeBajaBtn.Visible = true;
            darseDeBajaBtn.Enabled = true;
            lblTitleChildForm.Text = "Iniciar Sesión";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Sección de perfil
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivarBoton(sender, RGBColors.color3);
            lblName.Visible = false;
            sushi.Visible = false;
            lblName.Enabled = false;
            lblContrasena.Visible = false;
            lblContrasena.Enabled = false;
            txtnombre.Visible = false;
            txtnombre.Enabled = false;
            txtcontrasena.Visible = false;
            txtcontrasena.Enabled = false;
            btnIniciarSesion.Visible = false;
            btnIniciarSesion.Enabled = false;
            btnRegistrarse.Visible = false;
            btnRegistrarse.Enabled = false;
            Desconectarbtn.Visible = false;
            Desconectarbtn.Enabled = false;
            ListaConectados.Visible = false;
            invitarbtn.Visible = false;
            invitarbtn.Enabled = false;
            nombrePerfilLbl.Visible = true;
            nombrePerfilLbl.Enabled = true;
            darseDeBajaBtn.Visible = false;
            darseDeBajaBtn.Enabled = false;
            lblTitleChildForm.Text = "Perfil";
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (A == 1)
            {
                string mensaje = "5/" + N;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

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
            Convert.ToString(ListaConectados.MultiSelect);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DesactivarBoton();
            sushi.Visible = true;
            leftBorderBtn.Visible = false;
            peticion1Lbl.Visible = false;
            peticion2Lbl.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Inicio";
            lblTitleChildForm.ForeColor = Color.White;
            lblName.Visible = false;
            nombrePerfilLbl.Visible = false;
            lblName.Enabled = false;
            lblContrasena.Visible = false;
            lblContrasena.Enabled = false;
            txtnombre.Visible = false;
            txtnombre.Enabled = false;
            txtcontrasena.Visible = false;
            txtcontrasena.Enabled = false;
            btnIniciarSesion.Visible = false;
            btnIniciarSesion.Enabled = false;
            btnRegistrarse.Visible = false;
            btnRegistrarse.Enabled = false;
            Desconectarbtn.Visible = false;
            Desconectarbtn.Enabled = false;
            ListaConectados.Visible = false;
            ListaConectados.Enabled = false;
            invitarbtn.Visible = false;
            invitarbtn.Enabled = false;
            darseDeBajaBtn.Visible = false;
            darseDeBajaBtn.Enabled = false;
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

            if (A == 1)
            {
                //Mensaje de desconexión
                string mensaje = "0/" + N;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


                // Nos desconectamos
                MessageBox.Show("Te has desconectado");
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                atender.Abort();
                A = 0;
                btnRegistrarse.Visible = true;
                sushi.Visible = false;
                btnIniciarSesion.Visible = true;
                darseDeBajaBtn.Visible = true;
                peticion1Lbl.Visible = false;
                peticion2Lbl.Visible = false;
            }
            else
            {
                Application.Exit();
            }
        
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
                if (A != 1 && txtcontrasena.Text != "" && txtnombre.Text != "")
                {
                    if (RegisterCheck == false)
                    {
                        //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                        //al que deseamos conectarnos
                        //IP de shiva: 147.83.117.22
                        //IP Ubuntu: 192.168.56.102 
                        IPAddress direc = IPAddress.Parse("147.83.117.22");
                        IPEndPoint ipep = new IPEndPoint(direc, 50079);


                        //Creamos el socket 
                        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        try
                        {
                            server.Connect(ipep);//Intentamos conectar el socket
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
                    RegisterCheck = false;
                    A = 1;
                    N = txtnombre.Text;

                    string mensaje = "2/" + txtnombre.Text + "/" + txtcontrasena.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                }
                else
                {
                    if (txtcontrasena.Text != "" && txtnombre.Text != "")
                        MessageBox.Show("Introduce tus datos.");
                    else
                        MessageBox.Show("Ya has iniciado una sesión debes desconectarte primero.");
                }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
                //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
                //al que deseamos conectarnos
                IPAddress direc = IPAddress.Parse("147.83.117.22");
                IPEndPoint ipep = new IPEndPoint(direc, 50079);


                //Creamos el socket 
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    server.Connect(ipep);//Intentamos conectar el socket     

                }
                catch (SocketException ex)
                {
                    //Si hay excepcion imprimimos error y salimos del programa con return 
                    return;

                }
                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();

            string mensaje = "1/" + txtnombre.Text + "/" + txtcontrasena.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
           
        }

        private void Desconectarbtn_Click(object sender, EventArgs e)
        {
            if (A == 1)
            {
                //Mensaje de desconexión
                string mensaje = "0/" + N;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);


                // Nos desconectamos
                MessageBox.Show("Te has desconectado");
                server.Shutdown(SocketShutdown.Both);
                server.Close();
                atender.Abort();
                A = 0;
                btnRegistrarse.Visible = true;
                darseDeBajaBtn.Visible = true;
                btnIniciarSesion.Visible = true;
            }
            else
            {
                MessageBox.Show("Todavía no estás conectado!");
            }
        }

        StringBuilder sb = new StringBuilder();

        private void invitarbtn_Click(object sender, EventArgs e)
        {
            string mensaje;
            int numParticipantes = 1;
            sb.Clear();
            sb.Append("6/" + N + "/");
            foreach (DataGridViewCell item in ListaConectados.SelectedCells)
            {
                if (item.Value.ToString() != N)
                {
                    numParticipantes++;
                }
            }
            sb.Append(numParticipantes + "/");
            foreach (DataGridViewCell item in ListaConectados.SelectedCells)
            {
                if (item.Value.ToString() != N)
                {
                    sb.Append(item.Value.ToString() + "/");
                }
            }
            
            mensaje = sb.ToString();
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }
        private void PonInvisible(string btn)
        {
            if (btn == "btnRegistrarse")
                btnRegistrarse.Visible = false;
                darseDeBajaBtn.Visible = false;
                btnIniciarSesion.Visible = false;
        }

        private void darseDeBajaBtn_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc, 50079);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket     
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                return;
            }
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

            string mensaje = "3/" + txtnombre.Text + "/" + txtcontrasena.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        public void Peticion1(string mensaje)
        {
            peticion1Lbl.Visible = true;
            peticion1Lbl.Text = "Partidas ganadas: " + mensaje;
        }
        public void Peticion2(string mensaje)
        {
            peticion2Lbl.Visible = true;
            peticion2Lbl.Text = "Partidas jugadas: " + mensaje;
        }


    }
}
   

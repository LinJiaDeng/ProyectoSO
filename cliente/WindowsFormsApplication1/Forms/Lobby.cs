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
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Lobby : Form
    {
        List<Resultados> resultados = new List<Resultados>();
        int ID_Partida;
        Socket server;
        delegate void DelegadochatLbl(string nombreMsg, string chat);
        delegate void DelegadonumParticipantes(int numParticipantes);
        delegate void DelegadoEscribir(string[] respuesta);
        delegate void DelegadoempezarPartida();
        delegate void DelegadoempezarRonda();
        public bool clicked = false;
        int lineasChat;
        int numParticipantes;
        int vueltas = 0;
        int rondas = 0;
        int IdCarta;
        string NombreCarta;
        string nombre;
        PictureBox[,] PictureBoxCartas = new PictureBox[5, 10];
        string [] jugador = new string [5];
        int [,] puntosRonda = new int [5, 3];
        int[] puntosTotales = new int [5];
        int[,] cartasMesa = new int [5, 10];
        bool[] ok = new bool[5];
        int [,] mano = new int [5,10];
        int pasada = 0;
        int q = 0;
        bool wasabi;
        int[] puding = new int [5];
        int[] puntosMaki = new int[5];
        PictureBox[] PictureBoxPudin = new PictureBox[5];
        int PosiBaraja = 0;
        bool next = false;
        int[] TablaJugadores = new int[5];
        string [] MensajeServer = new string [5];
        int numcartas;



        public Lobby(int ID_Partida, Socket server, int numParticipantes, string nombre)
        {
            InitializeComponent();
            this.ID_Partida = ID_Partida;
            this.server = server;
            this.numParticipantes = numParticipantes;
            this.nombre = nombre;
            ControlBox = false;
            PictureBoxCartas[0, 0] = carta1;
            PictureBoxCartas[0, 1] = carta2;
            PictureBoxCartas[0, 2] = carta3;
            PictureBoxCartas[0, 3] = carta4;
            PictureBoxCartas[0, 4] = carta5;
            PictureBoxCartas[0, 5] = carta6;
            PictureBoxCartas[0, 6] = carta7;
            PictureBoxCartas[0, 7] = carta8;
            PictureBoxCartas[0, 8] = carta9;
            PictureBoxCartas[0, 9] = carta10;
            PictureBoxCartas[1, 0] = carta11;
            PictureBoxCartas[1, 1] = carta12;
            PictureBoxCartas[1, 2] = carta13;
            PictureBoxCartas[1, 3] = carta14;
            PictureBoxCartas[1, 4] = carta15;
            PictureBoxCartas[1, 5] = carta16;
            PictureBoxCartas[1, 6] = carta17;
            PictureBoxCartas[1, 7] = carta18;
            PictureBoxCartas[1, 8] = carta19;
            PictureBoxCartas[1, 9] = carta20;
            PictureBoxCartas[2, 0] = carta21;
            PictureBoxCartas[2, 1] = carta22;
            PictureBoxCartas[2, 2] = carta23;
            PictureBoxCartas[2, 3] = carta24;
            PictureBoxCartas[2, 4] = carta25;
            PictureBoxCartas[2, 5] = carta26;
            PictureBoxCartas[2, 6] = carta27;
            PictureBoxCartas[2, 7] = carta28;
            PictureBoxCartas[2, 8] = carta29;
            PictureBoxCartas[2, 9] = carta30;
            PictureBoxCartas[3, 0] = carta31;
            PictureBoxCartas[3, 1] = carta32;
            PictureBoxCartas[3, 2] = carta33;
            PictureBoxCartas[3, 3] = carta34;
            PictureBoxCartas[3, 4] = carta35;
            PictureBoxCartas[3, 5] = carta36;
            PictureBoxCartas[3, 6] = carta37;
            PictureBoxCartas[3, 7] = carta38;
            PictureBoxCartas[3, 8] = carta39;
            PictureBoxCartas[3, 9] = carta40;
            PictureBoxCartas[4, 0] = carta41;
            PictureBoxCartas[4, 1] = carta42;
            PictureBoxCartas[4, 2] = carta43;
            PictureBoxCartas[4, 3] = carta44;
            PictureBoxCartas[4, 4] = carta45;
            PictureBoxCartas[4, 5] = carta46;
            PictureBoxCartas[4, 6] = carta47;
            PictureBoxCartas[4, 7] = carta48;
            PictureBoxCartas[4, 8] = carta49;
            PictureBoxCartas[4, 9] = carta50;
            PictureBoxPudin[0] = pudin1;
            PictureBoxPudin[1] = pudin2;
            PictureBoxPudin[2] = pudin3;
            PictureBoxPudin[3] = pudin4;
            PictureBoxPudin[4] = pudin5;
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

                        if (respuesta.Length > 5)
                        {
                           DelegadonumParticipantes delegadoNumParticipantes = new DelegadonumParticipantes(EscribirNumParticipantes);
                           Invoke(delegadoNumParticipantes, new object[] { Convert.ToInt32(respuesta[4]) });

                             if (respuesta[1] == Inicio.N)
                             {
                               DelegadoempezarPartida delegadoEmpezarPartida = new DelegadoempezarPartida(EmpezarPartida);
                               Invoke(delegadoEmpezarPartida, new object[] { });
                               
                        }
                            int k = 0;
                            while (k < Convert.ToInt32(respuesta[4]))
                            {
                                jugador[k] = respuesta[k + 5];
                                k++;
                            }
                        }       
                    break;

                case 13:
                    IdCarta = Convert.ToInt32(respuesta[2]);


                            if (jugador[0] == respuesta[4]) // Compara el nombre del jugador con el que ha puesto carta
                            {
                                ok[0] = true;
                                PictureBoxCartas[TablaJugadores[0], vueltas].ImageLocation = "Espalda.jpg";
                                int n = 1;
                                mano[0, 0] = IdCarta;
                                while (n < Convert.ToInt32(respuesta[6])+1) // numcartas
                                {
                                    mano[0, n] = Convert.ToInt32(respuesta[6 + n]);
                                    n++;
                                }
                            }
                            else if (jugador[1] == respuesta[4])
                            {
                                ok[1] = true;
                                PictureBoxCartas[TablaJugadores[1], vueltas].ImageLocation = "Espalda.jpg";
                                int n = 1;
                                mano[1, 0] = IdCarta;
                                while (n < Convert.ToInt32(respuesta[6])+1)//numcartas
                                {
                                    mano[1, n] = Convert.ToInt32(respuesta[6 + n]);
                                    n++;
                                }
                            }
                            else if (jugador[2] == respuesta[4])
                            {
                                ok[2] = true;
                                PictureBoxCartas[TablaJugadores[2], vueltas].ImageLocation = "Espalda.jpg";
                                int n = 1;
                                mano[2, 0] = IdCarta;
                                while (n < Convert.ToInt32(respuesta[6])+1)//numcartas
                                {
                                    mano[2, n] = Convert.ToInt32(respuesta[6 + n]);
                                    n++;
                                }
                            }
                            else if (jugador[3] == respuesta[4])
                            {
                                ok[3] = true;
                                PictureBoxCartas[TablaJugadores[3], vueltas].ImageLocation = "Espalda.jpg";
                                int n = 1;
                                mano[3, 0] = IdCarta;
                                while (n < Convert.ToInt32(respuesta[6]) + 1)//numcartas
                                {
                                    mano[3, n] = Convert.ToInt32(respuesta[6 + n]);
                                    n++;
                                }
                            }
                            else
                            {
                                ok[4] = true;
                                PictureBoxCartas[TablaJugadores[4], vueltas].ImageLocation = "Espalda.jpg";
                                int n = 1;
                                mano[4, 0] = IdCarta;
                                while (n < Convert.ToInt32(respuesta[6]) + 1)//numcartas
                                {
                                    mano[4, n] = Convert.ToInt32(respuesta[6 + n]);
                                    n++;
                                }
                            }
                            SoundPlayer simpleSound = new SoundPlayer(@"ponercarta.wav");
                            simpleSound.Play();
                    switch (Convert.ToInt32(respuesta[3])) // numJugadores
                            {
                                case 2:

                                    if (ok[0] == true && ok[1] == true)
                                    {
                                        int k = 0;

                                        if (jugador[0] == Inicio.N)
                                        {
                                            string mensaje ="12/" + Inicio.N + "/" + ID_Partida + "/" + numParticipantes + "/" + Convert.ToInt32(respuesta[6]);
                                            while (k < numParticipantes)
                                            {
                                                mensaje = mensaje + "/" + jugador[k] + "/" + mano[k, 0];
                                               
                                                int c = 1;
                                                while (c <= Convert.ToInt32(respuesta[6]))//numcartas
                                                {
                                                    mensaje = mensaje + "/" + mano[k, c];
            
                                                    c++;
                                                }
                                               
                                               
                                                
                                                k++;
                                            }
                                            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                                            Inicio.server.Send(msg);  
                                            ok[0] = false;
                                            ok[1] = false;
                                        }
                                      
                                    }
                                    break;
                                case 3:

                                    if (ok[0] == true && ok[1] == true && ok[2] == true)
                                    {

                                        int k = 0;

                                        if (jugador[0] == Inicio.N)
                                        {
                                            string mensaje = "12/" + Inicio.N + "/" + ID_Partida + "/" + numParticipantes + "/" + Convert.ToInt32(respuesta[6]);
                                            while (k < numParticipantes)
                                            {
                                                mensaje = mensaje + "/" + jugador[k] + "/" + mano[k, 0];

                                                int c = 1;
                                                while (c <= Convert.ToInt32(respuesta[6]))//numcartas
                                                {
                                                    mensaje = mensaje + "/" + mano[k, c];

                                                    c++;
                                                }



                                                k++;
                                            }
                                            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                                            Inicio.server.Send(msg);
                                            ok[0] = false;
                                            ok[1] = false;
                                            ok[2] = false;
                                        }

                                    }
                                    break;
                                case 4:

                                    if (ok[0] == true && ok[1] == true && ok[2] == true && ok[3] == true)
                                    {
                                        int k = 0;

                                        if (jugador[0] == Inicio.N)
                                        {
                                            string mensaje = "12/" + Inicio.N + "/" + ID_Partida + "/" + numParticipantes + "/" + Convert.ToInt32(respuesta[6]);
                                            while (k < numParticipantes)
                                            {
                                                mensaje = mensaje + "/" + jugador[k] + "/" + mano[k, 0];

                                                int c = 1;
                                                while (c <= Convert.ToInt32(respuesta[6]))//numcartas
                                                {
                                                    mensaje = mensaje + "/" + mano[k, c];

                                                    c++;
                                                }



                                                k++;
                                            }
                                            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                                            Inicio.server.Send(msg);
                                            ok[0] = false;
                                            ok[1] = false;
                                            ok[2] = false;
                                            ok[3] = false;
                                        }

                                    }
                                    break;
                                case 5:

                                    if (ok[0] == true && ok[1] == true && ok[2] == true && ok[3] == true && ok[4] == true)
                                    {
                                        int k = 0;

                                        if (jugador[0] == Inicio.N)
                                        {
                                            string mensaje = "12/" + Inicio.N + "/" + ID_Partida + "/" + numParticipantes + "/" + Convert.ToInt32(respuesta[6]);
                                            while (k < numParticipantes)
                                            {
                                                mensaje = mensaje + "/" + jugador[k] + "/" + mano[k, 0];

                                                int c = 1;
                                                while (c <= Convert.ToInt32(respuesta[6]))//numcartas
                                                {
                                                    mensaje = mensaje + "/" + mano[k, c];

                                                    c++;
                                                }



                                                k++;
                                            }
                                            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                                            Inicio.server.Send(msg);
                                            ok[0] = false;
                                            ok[1] = false;
                                            ok[2] = false;
                                            ok[3] = false;
                                            ok[4] = false;
                                        }

                                    }
                                    break;
                            }
                            break;


                case 14:
                    IdCarta = Convert.ToInt32(respuesta[2]);

                    
                            if (jugador[0] == respuesta[4])
                            {
                                NombreCarta = AsignarImagenCarta(IdCarta);
                                cartasMesa[0, q] = IdCarta;
                                PictureBoxCartas[TablaJugadores[0], vueltas].ImageLocation = NombreCarta + ".jpg";
                            }
                            else if (jugador[1] == respuesta[4])
                            {
                                NombreCarta = AsignarImagenCarta(IdCarta);
                                cartasMesa[1, q] = IdCarta;
                                PictureBoxCartas[TablaJugadores[1], vueltas].ImageLocation = NombreCarta + ".jpg";
                            }
                            else if (jugador[2] == respuesta[4])
                            {
                                NombreCarta = AsignarImagenCarta(IdCarta);
                                cartasMesa[2, q] = IdCarta;
                                PictureBoxCartas[TablaJugadores[2], vueltas].ImageLocation = NombreCarta + ".jpg";
                            }
                            else if (jugador[3] == respuesta[4])
                            {
                                NombreCarta = AsignarImagenCarta(IdCarta);
                                cartasMesa[3, q] = IdCarta;
                                PictureBoxCartas[TablaJugadores[3], vueltas].ImageLocation = NombreCarta + ".jpg";
                            }
                            else if (jugador[4] == respuesta[4])
                            {
                                NombreCarta = AsignarImagenCarta(IdCarta);
                                cartasMesa[4, q] = IdCarta;
                                PictureBoxCartas[TablaJugadores[4], vueltas].ImageLocation = NombreCarta + ".jpg";
                            }
                            pasada++;
                            
                            switch (Convert.ToInt32(respuesta[3])) // numJugadores
                            {
                                case 2:
                                    if (pasada == 2)
                                    {
                                        vueltas++;
                                        if (vueltas == 10)
                                            {
                                                vueltas = 0;
                                    
                                                if (jugador[0] == Inicio.N)
                                                {

                                            DelegadoempezarRonda delegadoEmpezarRonda = new DelegadoempezarRonda(EmpezarRonda);
                                            Invoke(delegadoEmpezarRonda, new object[] { });
                                        
                                                }
                                            }
                                        q++;
                                        pasada = 0;
                                    }
                                break;
                                case 3:
                                if (pasada == 3)
                                {
                                    vueltas++;
                                    
                                    if (vueltas == 9)
                                    {
                                        vueltas = 0;

                                        if (jugador[0] == Inicio.N)
                                        {

                                            DelegadoempezarRonda delegadoEmpezarRonda = new DelegadoempezarRonda(EmpezarRonda);
                                            Invoke(delegadoEmpezarRonda, new object[] { });

                                        }
                                    }
                                    q++;
                                    pasada = 0;
                                }
                                break;
                                case 4:
                                if (pasada == 4)
                                {
                                    vueltas++;
                                    
                                    if (vueltas == 8)
                                    {
                                        vueltas = 0;

                                        if (jugador[0] == Inicio.N)
                                        {

                                            DelegadoempezarRonda delegadoEmpezarRonda = new DelegadoempezarRonda(EmpezarRonda);
                                            Invoke(delegadoEmpezarRonda, new object[] { });

                                        }
                                    }
                                    q++;
                                    pasada = 0;
                                }
                                break;
                                case 5:
                                if (pasada == 5)
                                {
                                    vueltas++;
                                   
                                    if (vueltas == 7)
                                    {
                                        vueltas = 0;

                                        if (jugador[0] == Inicio.N)
                                        {

                                            DelegadoempezarRonda delegadoEmpezarRonda = new DelegadoempezarRonda(EmpezarRonda);
                                            Invoke(delegadoEmpezarRonda, new object[] { });

                                        }
                                    }
                                    q++;
                                    pasada = 0;
                                }
                                break;
                            }
                           
                    
                    break;
                    case 17:

                                    Resultados resultado = new Resultados(server, jugador, puntosTotales, ID_Partida, numParticipantes, puding);
                                    resultados.Add(resultado);
                                    resultado.ShowDialog();
                    break;
            }
        }


        public void EmpezarPartida()
        {
            empezarPartidaBtn.Visible = false;
        }
        public void EmpezarRonda()
        {
            rondaBtn.Visible = true;
        }
        public void FinalParitda()
        {
            rondaBtn.Text = "Ver resultados";
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

        public void MostrarTablero(int numParticipantes)
        {
            rondasLbl.Visible = true;

            switch (numParticipantes)
            {
                case 1:
                    rondasLbl.Text = "No hay suficientes jugadores";
                    break;
                case 2:
                    panelM2.Visible = true;
                    panelM4.Visible = true;
                    label4.Text = jugador[0] + " Puntuación de ronda: 0";
                    label8.Text = jugador[1] + " Puntuación de ronda: 0";
                    TablaJugadores[0] = 1;
                    TablaJugadores[1] = 3;
                    break;
                case 3:
                    panelM1.Visible = true;
                    panelM3.Visible = true;
                    panelM5.Visible = true;
                    carta10.Visible = false;
                    carta10.Enabled = false;
                    carta30.Visible = false;
                    carta30.Enabled = false;
                    carta50.Visible = false;
                    carta50.Enabled = false;
                    label1.Text = jugador[0] + " Puntuación de ronda: 0";
                    label6.Text = jugador[1] + " Puntuación de ronda: 0";
                    label10.Text = jugador[2] + " Puntuación de ronda: 0";
                    TablaJugadores[0] = 0;
                    TablaJugadores[1] = 2;
                    TablaJugadores[2] = 4;
                    break;
                case 4:
                    panelM1.Visible = true;
                    panelM2.Visible = true;
                    panelM3.Visible = true;
                    panelM4.Visible = true;
                    carta9.Visible = false;
                    carta9.Enabled = false;
                    carta10.Visible = false;
                    carta10.Enabled = false;
                    carta20.Visible = false;
                    carta20.Enabled = false;
                    carta19.Visible = false;
                    carta19.Enabled = false;
                    carta30.Visible = false;
                    carta30.Enabled = false;
                    carta29.Visible = false;
                    carta29.Enabled = false;
                    carta40.Visible = false;
                    carta40.Enabled = false;
                    carta39.Visible = false;
                    carta39.Enabled = false;
                    label1.Text = jugador[0] + " Puntuación de ronda: 0";
                    label4.Text = jugador[1] + " Puntuación de ronda: 0";
                    label6.Text = jugador[2] + " Puntuación de ronda: 0";
                    label8.Text = jugador[3] + " Puntuación de ronda: 0";
                    TablaJugadores[0] = 0;
                    TablaJugadores[1] = 1;
                    TablaJugadores[2] = 2;
                    TablaJugadores[3] = 3;
                    break;
                case 5:
                    panelM1.Visible = true;
                    panelM2.Visible = true;
                    panelM4.Visible = true;
                    panelM3.Visible = true;
                    panelM5.Visible = true;
                    carta8.Visible = false;
                    carta8.Enabled = false;
                    carta9.Visible = false;
                    carta9.Enabled = false;
                    carta10.Visible = false;
                    carta10.Enabled = false;
                    carta20.Visible = false;
                    carta20.Enabled = false;
                    carta19.Visible = false;
                    carta19.Enabled = false;
                    carta18.Visible = false;
                    carta18.Enabled = false;
                    carta30.Visible = false;
                    carta30.Enabled = false;
                    carta29.Visible = false;
                    carta29.Enabled = false;
                    carta28.Visible = false;
                    carta28.Enabled = false;
                    carta40.Visible = false;
                    carta40.Enabled = false;
                    carta39.Visible = false;
                    carta39.Enabled = false;
                    carta38.Visible = false;
                    carta38.Enabled = false;
                    carta50.Visible = false;
                    carta50.Enabled = false;
                    carta49.Visible = false;
                    carta49.Enabled = false;
                    carta48.Visible = false;
                    carta48.Enabled = false;
                    label1.Text = jugador[0] + " Puntuación de ronda: 0";
                    label4.Text = jugador[1] + " Puntuación de ronda: 0";
                    label6.Text = jugador[2] + " Puntuación de ronda: 0";
                    label8.Text = jugador[3] + " Puntuación de ronda: 0";
                    label10.Text = jugador[4] + " Puntuación de ronda: 0";
                    TablaJugadores[0] = 0;
                    TablaJugadores[1] = 1;
                    TablaJugadores[2] = 2;
                    TablaJugadores[3] = 3;
                    TablaJugadores[4] = 4;
                    break;
                default:
                    break;
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            partidaIdLbl.Text = "ID de la partida: " + ID_Partida;
            panel1.Enabled = false;
            panel1.Visible = false;
            lineasChat = 7;
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
        public void configurarPartida (int numParticipantes)
        {
            DelegadonumParticipantes delegado = new DelegadonumParticipantes(MostrarTablero);
            Invoke(delegado, new object[] { numParticipantes });   
        }
        private void empezarPartidaBtn_Click(object sender, EventArgs e)
        {

            string mensaje = "9/" + Inicio.N + "/" + ID_Partida;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            Inicio.server.Send(msg);
            SoundPlayer simpleSound = new SoundPlayer(@"Barajar.wav");
            simpleSound.Play();

            if (numParticipantes > 1)
            {
                empezarPartidaBtn.Visible = false;
            }
        }

        private void salirPartidaBtn_Click(object sender, EventArgs e)
        {
            if (rondas == 3 || rondas == 0)
            {
                string mensaje = "10/" + Inicio.N + "/" + ID_Partida;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                Inicio.server.Send(msg);
                

                Close();
            }
        }

        public string AsignarImagenCarta(int IdCarta)
        {
            //A partir del numero rand, retornamos la imagen.jpg
            switch (IdCarta)
            {
                case 0:
                    NombreCarta = "Tempura";
                    break;

                case 1:
                    NombreCarta = "Sashimi";
                    break;

                case 2:
                    NombreCarta = "Gyoza";
                    break;

                case 3:
                    NombreCarta = "Maki1";
                    break;

                case 4:
                    NombreCarta = "Maki2";
                    break;

                case 5:
                    NombreCarta = "Maki3";
                    break;

                case 6:
                    NombreCarta = "Nigiri1";
                    break;

                case 7:
                    NombreCarta = "Nigiri2";
                    break;

                case 8:
                    NombreCarta = "Nigiri3";
                    break;

                case 9:
                    NombreCarta = "Pudin";
                    break;

                case 10:
                    NombreCarta = "Wasabi";
                    break;

                case 11:
                    NombreCarta = "Tofu";
                    break;

                default:
                    break;
            }
            return NombreCarta;
        }
        

        public void AsignarPuntuacionRonda(int numjugadores)
        {

                    int primeroMaki = 0, segundoMaki = 0;
                    int j = 0;
                    string mensaje = "14/" + Inicio.N +"/" + numjugadores;
                    while (j < numjugadores)
                    {
                        int contTempura = 0, contSashimi = 0, contGyoza = 0, contMaki = 0, contTofu = 0; 
                        q = 0; 
                        wasabi = false;

                        puntosRonda[j, rondas] = 0;
                        switch (numjugadores) 
                        { 
                            case 2:
                                numcartas = 10;
                                break;
                            case 3:
                                numcartas = 9;
                                break;
                            case 4:
                                numcartas = 8;
                                break;
                            case 5:
                                numcartas = 7;
                                break;

                        }
                        while (q < numcartas )
                        {
                            if (cartasMesa[j, q] == 0) // tempura
                            {
                                contTempura++;
                                if ((contTempura % 2) == 0)
                                {
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 5;
                                    contTempura = 0;
                                }
                            }

                            if (cartasMesa[j, q] == 1) // sashimi
                            {
                                contSashimi++;
                                if ((contSashimi % 3) == 0)
                                {
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 10;
                                    contSashimi = 0;
                                }
                            }

                            if (cartasMesa[j, q] == 2) // gyoza
                            {
                                contGyoza++;
                            }

                            if (cartasMesa[j, q] == 3) // maki1
                            {
                                contMaki++;
                            }

                            if (cartasMesa[j, q] == 4) // maki2
                            {
                                contMaki = contMaki + 2;
                            }

                            if (cartasMesa[j, q] == 5) // maki3
                            {
                                contMaki = contMaki + 3;
                            }
                            if (cartasMesa[j, q] == 6) // tortilla
                            {
                                if (wasabi == true)
                                {
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 3;
                                    wasabi = false;
                                }
                                else
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 1;
                            }
                            if (cartasMesa[j, q] == 7) // salmon
                            {
                                if (wasabi == true)
                                {
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 6;
                                    wasabi = false;
                                }
                                else
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 2;
                            }
                            if (cartasMesa[j, q] == 8) // calamar
                            {
                                if (wasabi == true)
                                {
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 9;
                                    wasabi = false;
                                }
                                else
                                    puntosRonda[j, rondas] = puntosRonda[j, rondas] + 3;
                            }
                            if (cartasMesa[j, q] == 9) // pudin
                            {
                                puding[j]++;
                            }
                            if (cartasMesa[j, q] == 10) // wasabi
                            {
                                wasabi = true;
                            }
                            if (cartasMesa[j, q] == 11) // Tofu
                            {
                                contTofu++;
                            }
                            q++;
                        }
                        if (contGyoza == 1)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 1;
                        }
                        else if (contGyoza == 2)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 3;
                        }
                        else if (contGyoza == 3)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 6;
                        }
                        else if (contGyoza == 4)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 10;
                        }
                        else if (contGyoza >= 5)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 15;
                        }
                        if (contTofu == 1)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 2;
                        }
                        else if (contTofu == 2)
                        {
                            puntosRonda[j, rondas] = puntosRonda[j, rondas] + 6;
                        }
                        puntosMaki[j] = contMaki;
                        q = 0;
                        j++;
                    }
                    int pos1 = -1;
                    int pos2 = -1;
                    for (int f = 0; f < numjugadores; f++)
                    {
                        if (puntosMaki[f] > segundoMaki)
                        {

                            if (puntosMaki[f] > primeroMaki)
                            {
                                primeroMaki = puntosMaki[f];
                                if (pos1 != -1)
                                {
                                    segundoMaki = puntosMaki[pos1];
                                    pos2 = pos1;
                                }
                                pos1 = f;
                            }
                            else
                            {
                                segundoMaki = puntosMaki[f];
                                pos2 = f;
                            }
                                
                        }
                    }
                    if (pos1 != -1)
                    puntosRonda[pos1, rondas] = puntosRonda[pos1, rondas] + 6;
                    if (pos2 != -1)
                    puntosRonda[pos2, rondas] = puntosRonda[pos2, rondas] + 3;

                    for (int f = 0; f < numjugadores; f++)
                    {     
                        mensaje = mensaje + "/" + jugador[f] + "/" + ID_Partida + "/" + puntosRonda[f, rondas] + "/" + puding[f];
                    }

                        rondas++;
                    if (jugador[0] == Inicio.N)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                        Inicio.server.Send(msg);
                        if (rondas > 2)
                        {
                            DelegadoempezarRonda delegadoFinalPartida = new DelegadoempezarRonda(FinalParitda);
                            Invoke(delegadoFinalPartida, new object[] { });
                        }
                    }

        }

        private void rondaBtn_Click(object sender, EventArgs e)
        {
            switch (numParticipantes)
            {
                case 2:
                    if (rondas <= 2)
                    {
                        PosiBaraja = PosiBaraja + 10;
                        next = true;
                    }

                    break;
                case 3:
                    if (rondas <= 2)
                    {
                        PosiBaraja = PosiBaraja + 9;
                        next = true;
                    }

                    break;
                case 4:
                    if (rondas <= 2)
                    {
                        PosiBaraja = PosiBaraja + 8;
                        next = true;
                    }

                    break;
                case 5:
                    if (rondas <= 2)
                    {
                        PosiBaraja = PosiBaraja + 7;
                        next = true;
                    }

                    break;
            }
            if (next)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"campana.wav");
                simpleSound.Play();
                string mensaje = "13/" + Inicio.N + "/" + ID_Partida + "/" + numParticipantes + "/" + PosiBaraja;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                Inicio.server.Send(msg);
                rondaBtn.Visible = false;
                next = false;
            }
            else 
            {

                string mensaje = "15/" + Inicio.N;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                Inicio.server.Send(msg);
                rondaBtn.Visible = false;



            }
            
        }

        public void Vaciar()
        {
            int h = 0;
            int p = 0;

            while (h <= 4)
            {
                while (p <= 9)
                {
                    PictureBoxCartas[h, p].Image = null;
                    p++;
                }
                h++;
                p = 0;
            }
        }
        public void RondaLbl()
        {
            rondasLbl.Text = "Ronda " + (rondas+1) + "/3";
        }
        public void VaciarTabla()
        {
            DelegadoempezarRonda delegadoVaciar = new DelegadoempezarRonda(Vaciar);
            Invoke(delegadoVaciar, new object[] { });
            DelegadoempezarRonda delegadoRondaLbl = new DelegadoempezarRonda(RondaLbl);
            Invoke(delegadoRondaLbl, new object[] { });
        }

        public void EscribirPuntuacion(string[] respuesta)
        {
       
            DelegadoEscribir delegadoEscribirPuntuacion = new DelegadoEscribir(escribir);
            Invoke(delegadoEscribirPuntuacion, new object[] { respuesta });

        }
        public void escribir(string[] respuesta)
        {
            switch (numParticipantes)
            {
                case 2:
                    if (jugador[0] == respuesta[2])
                    {
                        label4.Text = jugador[0] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[0] = puntosTotales[0] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[1].ImageLocation = "Pudin.jpg";
                        }
                        label3.Visible = true;
                        label3.Text = "X" + Convert.ToString(respuesta[4]);

                    }
                    else
                    {
                        label8.Text = jugador[1] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[1] = puntosTotales[1] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[3].ImageLocation = "Pudin.jpg";
                        }
                        label7.Visible = true;
                        label7.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    break;
                case 3:
                    if (jugador[0] == respuesta[2])
                    {
                        label1.Text = jugador[0] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[0] = puntosTotales[0] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[0].ImageLocation = "Pudin.jpg";
                        }
                        label11.Visible = true;
                        label11.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[1] == respuesta[2])
                    {
                        label6.Text = jugador[1] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[1] = puntosTotales[1] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[2].ImageLocation = "Pudin.jpg";
                        }
                        label5.Visible = true;
                        label5.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else
                    {
                        label10.Text = jugador[2] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[2] = puntosTotales[2] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[4].ImageLocation = "Pudin.jpg";
                        }
                        label12.Visible = true;
                        label12.Text = "X" + Convert.ToString(respuesta[4]);
 
                    }
                    break;
                case 4:
                    if (jugador[0] == respuesta[2])
                    {
                        label1.Text = jugador[0] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[0] = puntosTotales[0] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[0].ImageLocation = "Pudin.jpg";
                        }
                        label11.Visible = true;
                        label11.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[1] == respuesta[2])
                    {
                        label4.Text = jugador[1] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[1] = puntosTotales[1] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[1].ImageLocation = "Pudin.jpg";
                        }
                        label3.Visible = true;
                        label3.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[2] == respuesta[2])
                    {
                        label6.Text = jugador[2] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[2] = puntosTotales[2] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[2].ImageLocation = "Pudin.jpg";
                        }
                        label5.Visible = true;
                        label5.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else
                    {
                        label8.Text = jugador[3] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[3] = puntosTotales[3] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[3].ImageLocation = "Pudin.jpg";
                        }
                        label7.Visible = true;
                        label7.Text = "X" + Convert.ToString(respuesta[4]);

                    }
                    break;
                case 5:
                    if (jugador[0] == respuesta[2])
                    {
                        label1.Text = jugador[0] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[0] = puntosTotales[0] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[0].ImageLocation = "Pudin.jpg";
                        }
                        label11.Visible = true;
                        label11.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[1] == respuesta[2])
                    {
                        label4.Text = jugador[1] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[1] = puntosTotales[1] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[1].ImageLocation = "Pudin.jpg";
                        }
                        label3.Visible = true;
                        label3.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[2] == respuesta[2])
                    {
                        label6.Text = jugador[2] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[2] = puntosTotales[2] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[2].ImageLocation = "Pudin.jpg";
                        }
                        label5.Visible = true;
                        label5.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else if (jugador[3] == respuesta[2])
                    {
                        label8.Text = jugador[3] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[3] = puntosTotales[3] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[3].ImageLocation = "Pudin.jpg";
                        }
                        label7.Visible = true;
                        label7.Text = "X" + Convert.ToString(respuesta[4]);
                    }
                    else
                    {
                        label10.Text = jugador[4] + " Puntuación de ronda: " + respuesta[3] + " puntos";
                        puntosTotales[4] = puntosTotales[4] + Convert.ToInt32(respuesta[3]);
                        if (Convert.ToInt32(respuesta[4]) > 0)
                        {
                            PictureBoxPudin[4].ImageLocation = "Pudin.jpg";
                        }
                        label12.Visible = true;
                        label12.Text = "X" + Convert.ToString(respuesta[4]);

                    }
                    break;
            }
        }

    }
}

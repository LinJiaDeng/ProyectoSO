#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>
#include <time.h>

typedef struct {
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados [100];
	int num;
}ListaConectados;

typedef struct {	
	int ID_carta [108];
	int numRepartidas;	
}Baraja;
typedef struct {
	int ID;
	int numParticipantes;
	Conectado conectados [8];
	Baraja baraja;
	
}Partida;

typedef struct {
	Partida partidas [100];
	int num;
}ListaPartidas;

int i;
int sockets[100];
char notificacion[500];
ListaConectados lista;
ListaPartidas listap;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void BarajarCartas(int ID) {
		//Esta funcion se usa al principio de cada ronda para barajar las cartas
		//Primero de todo, se reinician las variables relacionadas con la baraja de la anterior ronda
		for(int k = 0; k < 108; k++) {
			listap.partidas[ID].baraja.ID_carta[k] = -1;
			
		}
		listap.partidas[ID].baraja.numRepartidas = 0;
		
		//Se inicia un bucle en el que se extrae un numero entre 1 y 12 
		//se comprueba que esa combinacion no este en la lista y, si es asi, se asigna la combinacion
		
		int i = 0; 
		int contador1 = 0;// ID = 1 Tempuras (14)
		int contador2 = 0;// ID = 2 Sashimi (14)
		int contador3 = 0;// ID = 3 Gyozas (14)
		int contador4 = 0;// ID = 4 Maki1 (6)
		int contador5 = 0;// ID = 5 Maki2 (12)
		int contador6 = 0;// ID = 6 Maki3 (8)
		int contador7 = 0;// ID = 7 Nigiri1 (5)
		int contador8 = 0;// ID = 8 Nigiri2 (10)
		int contador9 = 0;// ID = 9 Nigiri3 (5)
		int contador10 = 0;// ID = 10 Pudin (10)
		int contador11 = 0;// ID = 11 Wasabi (6)
		int contador12 = 0;// ID = 12 Palillos (4)
		while(i < 108) {
			int randomID = (rand() % 12) + 1;
			
			int j = 0;
			int encontrado = 0;
			
			switch (randomID)
			{
			case 1:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador1 <= 14)
					{
						encontrado = 1;
						contador1++;
					}
					else
					{
						contador1++;
						j++;
					}
				}
				break;
			case 2:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador2 < 14)
					{
						encontrado = 1;
						contador2++;
					}
					else
					{
						contador2++;
						j++;
					}
				}
				break;
			case 3:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador3 < 14)
					{
						encontrado = 1;
						contador3++;
					}
					else
					{
						contador3++;
						j++;
					}
				}
				break;
			case 4:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador4 < 6)
					{
						encontrado = 1;
						contador4++;
					}
					else
					{
						contador4++;
						j++;
					}
				}
				break;
			case 5:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador5 < 12)
					{
						encontrado = 1;
						contador5++;
					}
					else
					{
						contador5++;
						j++;
					}
				}
				break;
			case 6:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador6 < 8)
					{
						encontrado = 1;
						contador6++;
					}
					else
					{
						contador6++;
						j++;
					}
				}
				break;
			case 7:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador7 < 5)
					{
						encontrado = 1;
						contador7++;
					}
					else
					{
						contador7++;
						j++;
					}
				}
				break;
			case 8:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador8 < 10)
					{
						encontrado = 1;
						contador8++;
					}
					else
					{
						contador8++;
						j++;
					}
				}
				break;
			case 9:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador9 < 5)
					{
						encontrado = 1;
						contador9++;
					}
					else
					{
						contador9++;
						j++;
					}
				}
				break;
			case 10:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador10 < 10)
					{
						encontrado = 1;
						contador10++;
					}
					else
					{
						contador10++;
						j++;
					}
				}
				break;
			case 11:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador11 < 6)
					{
						encontrado = 1;
						contador11++;
					}
					else
					{
						contador11++;
						j++;
					}
				}
				break;
			case 12:
				while (j < i && !encontrado) {
					if(listap.partidas[ID].baraja.ID_carta[j] == randomID && contador12 > 4)
					{
						encontrado = 1;
						
					}
					else
					{
						contador12++;
					   j++;
					}
				}
				break;
			}
			if(!encontrado) {
				listap.partidas[ID].baraja.ID_carta[i] = randomID;
				
				i++;
			}
			
		}
}
int Conectarse (ListaConectados *lista, char nombre[20], int socket){
	if (lista->num == 100)
		return -1;
	else {
		strcpy (lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
}

int DameSocket (ListaConectados *lista, char nombre[20]){
	//Devueleve el socket
	int i=0;
	int encontrado = 0;
	while ((i<= lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre, nombre) == 0)
			encontrado =1;
		if (!encontrado)
			i=i+1;
	}
	if (encontrado)
		return lista->conectados[i].socket;
	else
		return -1;
}


int DamePosicion (ListaConectados *lista, char nombre[20]){
	//Devueleve la posicion
	int i=0;
	int encontrado = 0;
	while ((i< lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre, nombre) == 0)
			encontrado =1;
		if (!encontrado)
			i=i+1;
	}
	if (encontrado)
		return i;
	else
		return -1;
}


int Eliminar (ListaConectados *lista, char nombre[20]){
	//Retorna 0 si elimina y -1 si el usuario no est￡ en la lista
	int pos = DamePosicion (lista, nombre);
	if (pos == -1)
		return -1;
	else
	{
		int i;
		for (i=pos; i< lista->num-1; i++)
		{
			strcpy (lista->conectados[i].nombre, lista->conectados[i+1].nombre);
			lista->conectados[i].socket = lista->conectados[i+1].socket;          
		}
		lista->num--;
		return 0;
	}
}


void DameConectados (ListaConectados *lista, char conectados[500]){
	//Devuelve los nombres de los conectados separados por /.

	sprintf (conectados, "6/%d", lista->num);
	int i;
	for (i=0; i< lista->num; i++)
	{
		sprintf (conectados,"%s/%s", conectados, lista->conectados[i].nombre);
	}
}
int GetID (ListaPartidas *listap){
	int max = 0;
	for(int k = 0; k<listap->num; k++)
	{
		if (listap->partidas[k].ID > max)
			max = listap->partidas[k].ID;
	}
	return max;
}
int AnadirPartida (ListaPartidas *listap){
	if (listap->num == 100)
		return -1;
	else {
		listap->partidas[listap->num].ID = listap->num;
		listap->num++;
		return 0;
	}
}
int AnadirParticipante(ListaPartidas *listap, int ID, char nombre[20], int sock_conn){
	if (listap->partidas[ID].numParticipantes == 5)
	{
		return -1;
	}
	else
	{
	int encontrado = 0;
	int i = 0;
	while (i < listap->num && encontrado == 0)
	{
		if (listap->partidas[i].ID == ID)
			encontrado = 1;
		else
		i++;
	}
	strcpy(listap->partidas[i].conectados[listap->partidas[i].numParticipantes].nombre, nombre);
	listap->partidas[i].conectados[listap->partidas[i].numParticipantes].socket = sock_conn;
	listap->partidas[i].numParticipantes++;
	return 0;
	}
}

int PuntuacionRonda (char nombre[20], char resultado[150]){
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	char consulta [150];
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "T4_BBDDjuego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	sprintf (consulta, "SELECT ROUND_SCORE.SCORE FROM (ROUND_SCORE,PLAYER) WHERE PLAYER.NAME = '%s' AND PLAYER.ID = ROUND_SCORE.ID_P ;",nombre);
	
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		sprintf (resultado,"3/Error al consultar datos de la base %u %s",
				 mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	
	if (row == NULL) {
		sprintf (resultado,"3/No se han obtenido datos en la consulta\n");
		// Y lo enviamos
	}
	else
		sprintf(resultado,"3/%s",row[0]);
	return 0;
}

int NumeroCartasMano(char nombre[20], char resultado[150]){
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	char consulta [150];
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "T4_BBDDjuego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	// construimos la consulta SQL
	sprintf (consulta, "SELECT HAND.NUMBER_OF_CARDS FROM (HAND,PLAYER) WHERE PLAYER.NAME = '%s' AND HAND.ID_P = PLAYER.ID;",nombre);
	// hacemos la consulta 
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	if (row == NULL){
		sprintf (resultado,"4/No se han obtenido datos en la consulta\n");
	}
	else
		sprintf(resultado,"4/%s",row[0]); 
	return 0;
}

int PuntuacionTotal (char nombre[20], char resultado[150]){
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	char consulta [150];
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "T4_BBDDjuego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	sprintf (consulta, "SELECT GAME.TOTAL_SCORE FROM (GAME,PLAYER) WHERE PLAYER.NAME = '%s' AND GAME.ID_P = PLAYER.ID;",nombre);
	
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		sprintf (resultado,"5/Error al consultar datos de la base %u %s",
				 mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	
	if (row == NULL){
		sprintf (resultado,"5/No se han obtenido datos en la consulta\n");
	}
	else
		sprintf(resultado,"5/%s",row[0]); 
	return 0;
	
}

int Registrarse (char usuario[20], char contrasena[20]) {	
	MYSQL *conn;
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	int err;
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T4_BBDDjuego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	err=mysql_query (conn, "SELECT * FROM PLAYER");
	if (err!=0) {
		printf ("Error al consultar la base de datos %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado_c = mysql_store_result (conn);
	int i = 0;
	row = mysql_fetch_row (resultado_c);
	while(row != NULL) {
		i++;
		row = mysql_fetch_row (resultado_c);
	}
	strcpy(consulta, "SELECT * FROM PLAYER WHERE PLAYER.NAME ='");
	strcat(consulta, usuario);
	strcat(consulta, "'");
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	resultado_c = mysql_store_result (conn);
	row = mysql_fetch_row (resultado_c);
	if(row != NULL) {
		printf("Error. Ya hay alguien con ese nombre.");
		return -1;
	}
	sprintf(consulta, "INSERT INTO PLAYER (ID,NAME,PASSWORD,GAMES_WON) VALUES ('%d','%s','%s','0');", i + 1, usuario, contrasena);
	
	printf("consulta = %s\n", consulta);
	// Ahora ya podemos realizar la insercion 
	err = mysql_query(conn, consulta);
	if (err!=0) {
		printf ("Error al introducir datos la base %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	return 0;	
}

int LogIn(char usuario[20], char contrasena[20]) {
	MYSQL *conn;
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	int err;
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexiￃﾳn, entrando nuestras claves de acceso y
	//el nombre de la base de datos a la que queremos acceder 
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "T4_BBDDjuego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	strcpy(consulta, "SELECT * FROM PLAYER WHERE PLAYER.NAME='");
	strcat(consulta, usuario);
	strcat(consulta, "' AND PLAYER.PASSWORD='");
	strcat(consulta, contrasena);
	strcat(consulta, "'");
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	resultado_c = mysql_store_result (conn);
	row = mysql_fetch_row (resultado_c);
	if(row == NULL) {
		printf("Error. Los datos no coinciden.");
		return -1;
	}
	
	return 0;
}

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	int error;
	
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos su nombre, que dejamos en buff
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		//Escribimos el nombre en la consola
		printf ("Se ha conectado: %s\n",peticion);
		
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		char nombre[20];
		p = strtok( NULL, "/");
		strcpy (nombre, p);
		printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		int ID = 0;
				
		switch (codigo)
		{
		case 0:
			terminar = 1;
			pthread_mutex_lock(&mutex);
			Eliminar(&lista,nombre);
			pthread_mutex_unlock(&mutex);
			DameConectados(&lista,notificacion);
			int j;
			for (j=0; j<lista.num; j++)
			{
				write (sockets[j],notificacion, strlen(notificacion));
			}
			char respuesta0[50];
			strcpy(respuesta0,"0/Te has desconectado");
			write (sock_conn,respuesta0,strlen(respuesta0));
			break;
			
		case 1:
			//Registrar un usuario
			p = strtok( NULL, "/");
			char respuesta1[50];
			char contrasena[20];
			strcpy (contrasena, p);
			pthread_mutex_lock(&mutex);
			error = Registrarse(nombre,contrasena);
			pthread_mutex_unlock(&mutex);
			
			if (error != 0)
			{
				terminar = 1;
				pthread_mutex_lock(&mutex);
				Eliminar(&lista,nombre);
				pthread_mutex_unlock(&mutex);
				
				printf ("Ha ocurrido un error en el caso 1");
				sprintf(respuesta1,"1/err");
				write (sock_conn,respuesta1,strlen(respuesta1));
			}
			
			else
			{
				sprintf(respuesta1,"1/%s",nombre);
				write (sock_conn,respuesta1,strlen(respuesta1));
			}	
			break;
			
		case 2:
			//Iniciar Sesion
			p = strtok( NULL, "/");
			char respuesta2[50];
			strcpy (contrasena, p);
			pthread_mutex_lock(&mutex);
			error = LogIn(nombre,contrasena);
			pthread_mutex_unlock(&mutex);

			if (error != 0)
			{
				terminar = 1;
				pthread_mutex_lock(&mutex);
				Eliminar(&lista,nombre);
				pthread_mutex_unlock(&mutex);
								
			printf ("Ha ocurrido un error en el caso 2");
			sprintf(respuesta2,"2/err");
			write (sock_conn,respuesta2,strlen(respuesta2));
			}
			else
			{
				sprintf(respuesta2,"2/%s",nombre);
				write (sock_conn,respuesta2,strlen(respuesta2));
				
				pthread_mutex_lock(&mutex);
				int errorCON = Conectarse (&lista,nombre,sock_conn);
				pthread_mutex_unlock(&mutex);
				if (errorCON != 0)
				printf ("Ha ocurrido un error en el caso 1, no se ha podido anadir a la lista de conectados");
				else		
				DameConectados(&lista,notificacion);
				for (j=0; j<lista.num; j++)
				{
				write (sockets[j],notificacion, strlen(notificacion));
				}
			}			
			break;
			
		case 3:
			error = PuntuacionRonda(nombre,respuesta);
			write (sock_conn,respuesta, strlen(respuesta));
			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 3");
			break;
			
		case 4:
			error = NumeroCartasMano(nombre,respuesta);
			write (sock_conn,respuesta, strlen(respuesta));
			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 4");
			break;
			
		case 5:
			error = PuntuacionTotal(nombre,respuesta);
			write (sock_conn,respuesta, strlen(respuesta));
			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 5");
			break;
			
		case 6:		
			pthread_mutex_lock(&mutex);
			AnadirPartida(&listap);
			pthread_mutex_unlock(&mutex);
			ID = GetID(&listap);
			pthread_mutex_lock(&mutex);
			AnadirParticipante(&listap,ID,nombre,sock_conn);
			pthread_mutex_unlock(&mutex);
			strcpy(respuesta,"");
			sprintf(respuesta,"7/%d/%s",ID,nombre);
			p = strtok( NULL, "/");
			int numParticipantes =  atoi (p);
			int i=0;
			j=0;
			char invitado[20];
			char info[25];
			
			while(i<numParticipantes-1)
			{
				p = strtok( NULL, "/");
				strcpy(invitado,p);
				j=0;
				while(j < lista.num)
				{
				 if (strcmp(invitado, lista.conectados[j].nombre)==0)
					 write (sockets[j],respuesta, strlen(respuesta));
					 j++;
				}
				i++;
			}
			strcpy(respuesta,"");
			sprintf(respuesta,"8/%d/%d",ID,listap.partidas[ID].numParticipantes);
			write(sock_conn,respuesta, strlen(respuesta));
			break;
			
		case 7:
			// aceptar partida
			p = strtok( NULL, "/");
			int ID =  atoi (p);			
			
			p = strtok( NULL, "/");
			int SiNo =  atoi (p);	
			char aceptar[25];
			sprintf(aceptar,"8/%d/%d",ID,listap.partidas[ID].numParticipantes);
			char notificacion [200];
			
			if( SiNo == 1)
			{
				int sock = DameSocket(&lista,nombre);
				pthread_mutex_lock(&mutex);
				int error = AnadirParticipante(&listap,ID,nombre,sock);
				pthread_mutex_unlock(&mutex);
				if (error == 0)
				{
				write(sock,aceptar, strlen(aceptar));
				sleep(1);
				sprintf (notificacion, "9/%s/%d/%s se ha unido a la partida/%d",nombre,ID,nombre,listap.partidas[ID].numParticipantes);
				j=0;
					while(j < listap.partidas[ID].numParticipantes)
					{		
						write (listap.partidas[ID].conectados[j].socket,notificacion, strlen(notificacion));
						j++;
					}
				}
				else
				{
				char respuesta[30];
				strcpy(respuesta,"10/");
				write(sock,respuesta,strlen(respuesta));
				}
			}			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 7");
			break;
		
		case 8:			
			p = strtok( NULL, "/");
			ID =  atoi (p);
			p = strtok (NULL, "/");
			char mensajeChat [1000];
			strcpy(mensajeChat,p);
			char reenvioChat [1000];
			sprintf(reenvioChat, "9/%s/%d/%s: %s",nombre,ID,nombre,mensajeChat);
			
				j=0;
				while(j < listap.partidas[ID].numParticipantes)
				{		
						write (listap.partidas[ID].conectados[j].socket,reenvioChat, strlen(reenvioChat));
					j++;
				}						
			break;
		case 9:
			p = strtok( NULL, "/");
			ID =  atoi (p);
			BarajarCartas(ID);
			int necesarioRepartir;
			i=0;
			int n=0;
			//Descubrir cuantas cartas hay que repartir.
			if(listap.partidas[ID].numParticipantes == 2){
				necesarioRepartir = 10;

					for (j=0;j<listap.partidas[ID].numParticipantes;j++)
			{
				//Enviamos 11/ID_carta
				sprintf(respuesta,"11/%d",necesarioRepartir);
				n=0;
				// La n es el num de cartas que se reparte a cada jugador, y la i es el identificador de las cartas del mazo de cada jugador.
				while (n < necesarioRepartir)
				{	
					sprintf(respuesta, "%s/%d",respuesta, listap.partidas[ID].baraja.ID_carta[i]);
					i++;
					n++;
				}

				write (listap.partidas[ID].conectados[j].socket,respuesta, strlen(respuesta));
			}
			}


			else if (listap.partidas[ID].numParticipantes == 3){
				necesarioRepartir = 9;

				
					for (j=0;j<listap.partidas[ID].numParticipantes;j++)
			{
				//Enviamos 11/ID_carta
				sprintf(respuesta,"11/%d",necesarioRepartir);
				n=0;
				while (n < necesarioRepartir)
				{	
					sprintf(respuesta, "%s/%d",respuesta, listap.partidas[ID].baraja.ID_carta[i]);
					i++;
					n++;
				}

				write (listap.partidas[ID].conectados[j].socket,respuesta, strlen(respuesta));
			}
			}


			else if(listap.partidas[ID].numParticipantes == 4){
				necesarioRepartir = 8;
				
				for (j=0;j<listap.partidas[ID].numParticipantes;j++)
			{
				//Enviamos 11/ID_carta
				sprintf(respuesta,"11/%d",necesarioRepartir);
				n=0;
				
				while (n < necesarioRepartir)
				{	
					sprintf(respuesta, "%s/%d",respuesta, listap.partidas[ID].baraja.ID_carta[i]);
					i++;
					n++;
				}

				write (listap.partidas[ID].conectados[j].socket,respuesta, strlen(respuesta));
			}
			}


			else if(listap.partidas[ID].numParticipantes == 5){
				necesarioRepartir = 7;
					for (j=0;j<listap.partidas[ID].numParticipantes;j++)
			{
				//Enviamos 11/ID_carta
				sprintf(respuesta,"11/%d",necesarioRepartir);
				n=0;

				while (n < necesarioRepartir)
				{	
					sprintf(respuesta, "%s/%d",respuesta, listap.partidas[ID].baraja.ID_carta[i]);
					i++;
					n++;
				}

				write (listap.partidas[ID].conectados[j].socket,respuesta, strlen(respuesta));
			}
			}
			//Repartimos las cartas a cada jugador teniendo en cuenta el numero de participantes.
		
			break;
		default:
			
			// statements executed if expression does not equal
			// any case constant_expression
			break;
		}
		
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}

int main(int argc, char *argv[])
{
	lista.num=0;
	listap.num=0;
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	int puerto = 50079;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 50079
	serv_adr.sin_port = htons(puerto);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	
	pthread_t thread;
	i=0;
	printf ("Escuchando\n");
	
	for(;;){
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
	}
	
}


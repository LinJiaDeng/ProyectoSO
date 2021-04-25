#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

typedef struct {
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados [100];
	int num;
}ListaConectados;

int i;
int sockets[100];
ListaConectados lista;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

int Conectarse (ListaConectados *lista, char nombre[20], int socket){
	char notificacion[500];
	if (lista->num == 100)
		return -1;
	else {
		strcpy (lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		DameConectados(&lista,notificacion);
		int j;
		for (j=0; j<i; j++)
		{
			write (sockets[j],notificacion, strlen(notificacion));
		}
		return 0;
	}
}

int DameSocket (ListaConectados *lista, char nombre[20]){
	//Devueleve el socket
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
	char notificacion[500];
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
		DameConectados(&lista,notificacion);
		int j;
		for (j=0; j<i; j++)
		{
			write (sockets[j],notificacion, strlen(notificacion));
		}
		return 0;
	}
}


void DameConectados (ListaConectados *lista, char conectados[500]){
	//Devuelve los nombres de los conectados separados por /.
	sprintf (conectados, "6/%d/", lista->num);
	int i;
	for (i=0; i< lista->num; i++)
	{
		sprintf (conectados,"%s/%s", conectados, lista->conectados[i].nombre);
	}
}


int PuntuacionRonda (char nombre[20], char resultado[150])
{
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
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

int NumeroCartasMano(char nombre[20], char resultado[150])
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	char consulta [150];
	
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi\uffc3\uffb3n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexi\uffc3\uffb3n: %u %s\n", 
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

int PuntuacionTotal (char nombre[20], char resultado[150])
{
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
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
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
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
		exit (1);
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
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
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
		exit (1);
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
				
		switch (codigo)
		{
		case 0:
			terminar = 1;
			pthread_mutex_lock(&mutex);
			Eliminar(&lista,nombre);
			pthread_mutex_unlock(&mutex);
			char respuesta0[50];
			strcpy(respuesta0,"0/Te has desconectado");
			write (sock_conn,respuesta0,strlen(respuesta0));
			break;
		case 1:
			//Registrar un usuario
			p = strtok( NULL, "/");
			char respuesta1[50];
			char contrasena[50];
			strcpy (contrasena, p);
			error = Registrarse(nombre,contrasena);
			sprintf(respuesta1,"1/%s",nombre);
			write (sock_conn,respuesta1,strlen(respuesta1));
			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 1");
			
			break;
			
		case 2:
			//Iniciar Sesion
			p = strtok( NULL, "/");
			
			char respuesta2[50];
			
			strcpy (contrasena, p);
			error = LogIn(nombre,contrasena);
			sprintf(respuesta2,"2/%s",nombre);
			write (sock_conn,respuesta2,strlen(respuesta2));
			int numsocket = DameSocket(&lista,nombre);
			
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 2");
			
			pthread_mutex_lock(&mutex);
			int errorCON = Conectarse (&lista,nombre,numsocket);
			pthread_mutex_unlock(&mutex);
			
			if (errorCON != 0)
				printf ("Ha ocurrido un error en el caso 1, no se ha podido a�adir a la lista de conectados");
			
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
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
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
	// escucharemos en el port 9080
	serv_adr.sin_port = htons(9080);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	
	pthread_t thread;
	i=0;
	
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
	}
	
}


#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>

typedef struct{
	char nombre[20];
	int socket;
} Conectado;

typedef struct{
	Conectado conectados[100];
	int num;
}ListaConectados;

int Pon (ListaConectados *lista, char nombre[20], int socket) {
	//Devuelve -1 si no se ha podido añadir un conectado a la lista y 0 si
	//todo ha ido bien.
	if (lista->num == 100)	
		return -1;
	else{
		strcpy (lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
}

int DameSocket (ListaConectados *lista, char nombre[20]) {
	int i=0;
	int encontrado = 0; 
	while ((i< lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado = 1;
		if(!encontrado)
			i++;
	}
	if (encontrado)
		return lista->conectados[i].socket;
	else 
		return -1;
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
		sprintf (resultado,"Error al consultar datos de la base %u %s",
				 mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	
	if (row == NULL) {
		sprintf (resultado,"No se han obtenido datos en la consulta\n");
		// Y lo enviamos
	}
	else
		strcpy(resultado,row[0]);
	
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
		sprintf (resultado,"No se han obtenido datos en la consulta\n");
	}
	else
		sprintf(resultado,row[0]); 
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
		sprintf (resultado,"Error al consultar datos de la base %u %s",
				 mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	
	if (row == NULL){
		sprintf (resultado,"No se han obtenido datos en la consulta\n");
	}
	else
		strcpy(resultado,row[0]); 
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
	//inicializar la conexiï¿ƒï¾³n, entrando nuestras claves de acceso y
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

int main(int argc, char *argv[])
{
	ListaConectados listaconectados;
	listaconectados.num = 0;
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	int error;
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
	
	
	printf ("Escuchando\n");
	
	sock_conn = accept(sock_listen, NULL, NULL);
	printf ("He recibido conexion\n");
	//sock_conn es el socket que usaremos para este cliente
	
	for(;;){
		
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
		if(codigo!=0){
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		else
		   codigo=0;
		
		switch (codigo)
		{
		case 0:
			close(sock_conn);
			break;
		case 1:
                //Registrar un usuario
			p = strtok( NULL, "/");
			char contrasena[20];
			strcpy (contrasena, p);
			error = Registrarse(nombre,contrasena);
			write (sock_conn,nombre, strlen(nombre));
			 
				if (error != 0)
					printf ("Ha ocurrido un error en el caso 1");
		
			break;
			
		case 2:
			p = strtok( NULL, "/");
			
			strcpy (contrasena, p);
			error = LogIn(nombre,contrasena);
			int err = Pon(&listaconectados, nombre,sock_conn);
			if (err != 0)
				printf ("Ha ocurrido un error, no se ha podido añadir a la lista.");
			else{
			printf("OK");
			}
			write (sock_conn,nombre,strlen(nombre));
				
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
			
			
		default:
			
				// statements executed if expression does not equal
			// any case constant_expression
			break;
		}
	}
	
}


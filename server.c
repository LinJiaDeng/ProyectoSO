#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>

int main(int argc, char *argv[])
{
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
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9070);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	int i;
	// Atenderemos solo 5 peticione
	for(i=0;i<7;i++){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
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
		p = strtok( NULL, "/");
		char nombre[20];
		strcpy (nombre, p);
		printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		
		switch (codigo)
		{

		case 1:
                //Registrar un usuario
			break;
			
		case 2:
				error = PuntuacionRonda(nombre,respuesta);
				if (error != 0)
					printf ("Ha ocurrido un error en el caso 2");

			break;
		
		case 3:
			error = NumeroCartasMano(nombre,respuesta);
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 3");

			break;
		case 4:
			error = PuntuacionTotal(nombre,respuesta);
			if (error != 0)
				printf ("Ha ocurrido un error en el caso 3");
			break;
			
		default:
			// statements executed if expression does not equal
			// any case constant_expression
			break;
		}
		
	}
}

int PuntuacionRonda (char nombre[20], char resultado[80])
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
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
	
	sprintf (consulta, "SELECT ROUND_SCORE.SCORE FROM (ROUND_SCORE,PLAYER) WHERE PLAYER.NAME = '%s' AND ROUND_SCORE.ID_P = PLAYER.ID;",nombre);
	
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		sprintf (resultado,"Error al consultar datos de la base %u %s",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado_c = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado_c);
	
	if (row == NULL)
		sprintf (resultado,"No se han obtenido datos en la consulta\n");
	// Y lo enviamos
	write (sock_conn,respuesta, strlen(respuesta));
	// Se acabo el servicio para este cliente
	close(sock_conn); 
	else
		strcpy(resultado,row[0]);

	write (sock_conn,respuesta, strlen(respuesta));
	close(sock_conn); 
		return 0;
	
}

int NumeroCartasMano(char nombre[20], char resultado[80])
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
	char Nombre_Jugador[20];
	char consulta [80];

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
	
	printf ("\n Dame el nombre de la persona que quieres buscar\n"); 
	scanf ("%s", Nombre_Jugador);
	// construimos la consulta SQL
	sprintf (consulta, "SELECT HAND.NUMBER_OF_CARDS FROM (HAND,PLAYER) WHERE PLAYER.NAME = '%s' AND HAND.ID_P = PLAYER.ID;",Nombre_Jugador);
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
		// Y lo enviamos
		write (sock_conn,respuesta, strlen(respuesta));
		// Se acabo el servicio para este cliente
		close(sock_conn); 
	}
	else
		sprintf(resultado,row[0]);
	write (sock_conn,respuesta, strlen(respuesta));
	close(sock_conn); 
		return 0;
}

int PuntuacionTotal (char nombre[20], char resultado[80])
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado_c;
	MYSQL_ROW row;
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
	
	if (row == NULL)
		sprintf (resultado,"No se han obtenido datos en la consulta\n");
	write (sock_conn,respuesta, strlen(respuesta));
	close(sock_conn); 
	else
		strcpy(resultado,row[0]);
	write (sock_conn,respuesta, strlen(respuesta));
	close(sock_conn); 
	return 0;
	
}

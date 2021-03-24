//programa en C para consultar los datos de la base de datos
//Incluir esta libreria para poder hacer las llamadas en shiva2.upc.es
//#include <my_global.h>
#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
int main(int argc, char **argv)
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char nombre[20];
	int ronda=1;
	char consulta [80];
	int numcartas;
	char Id_jugador[10];
	char Id_carta[10];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexiￃﾳn: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "sushigo",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexiￃﾳn: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//Consulta la puntuacion de una ronda de un jugador en concreto.
	 printf("Introduce el nombre del jugador del cual quieres saber la puntuacion de todas las rondas: \n");
	 scanf("%s",nombre);
	
	 sprintf (consulta, "SELECT ROUND_SCORE.SCORE FROM (ROUND_SCORE,PLAYER) WHERE PLAYER.NAME = '%s' AND ROUND_SCORE.ID_P = PLAYER.ID;",nombre);

		err=mysql_query (conn, consulta); 
		if (err!=0) {
			printf ("Error al consultar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		//recogemos el resultado de la consulta 
		resultado = mysql_store_result (conn); 
		row = mysql_fetch_row (resultado);
		if (row == NULL)
			printf ("No se han obtenido datos en la consulta\n");
		else
			printf ("Puntuaciones: \n");
			while (row != NULL) {
				printf ("     Ronda %d:    %s puntos\n", ronda, row[0]);
				row = mysql_fetch_row (resultado);
				ronda++;
			}


	err=mysql_query (conn, "SELECT * FROM HAND");
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		while (row !=NULL) {
			// la columna 2 contiene una palabra que es la edad
			// la convertimos a entero 
			numcartas = atoi (row[2]);
			// las columnas 0 y 1 contienen DNI y nombre 
			printf ("\n Id_jugador: %s, Id_carta: %s, numcartas: %d\n", row[0], row[1], numcartas);
			// obtenemos la siguiente fila
			row = mysql_fetch_row (resultado);
	}
		
		
		
		// Ahora vamos a buscar el nombre de la persona cuyo DNI es uno
		// dado por el usuario
		printf ("\n Dame el ID de la persona que quieres buscar\n"); 
		scanf ("%s", Id_jugador);
		// construimos la consulta SQL
		strcpy (consulta,"SELECT NUMBER_OF_CARDS FROM HAND WHERE ID_P = '"); 
		strcat (consulta, Id_jugador);
		strcat (consulta,"'");
		// hacemos la consulta 
		err=mysql_query (conn, consulta); 
		if (err!=0) {
			printf ("Error al consultar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		//recogemos el resultado de la consulta 
		resultado = mysql_store_result (conn); 
		row = mysql_fetch_row (resultado);
		if (row == NULL)
			printf ("No se han obtenido datos en la consulta\n");
		else
			// El resultado debe ser una matriz con una sola fila
			// y una columna que contiene el nombre
			printf ("El jugador %s tiene: %s cartas. \n", Id_jugador, row[0] );
		
		printf("Introduce el nombre del jugador del cual quieres saber la puntuacion total: \n");
		scanf("%s",nombre);
		
		sprintf (consulta, "SELECT GAME.TOTAL_SCORE FROM (GAME,PLAYER) WHERE PLAYER.NAME = '%s' AND GAME.ID_P = PLAYER.ID;",nombre);
		
		err=mysql_query (conn, consulta); 
		if (err!=0) {
			printf ("Error al consultar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		resultado = mysql_store_result (conn); 
		row = mysql_fetch_row (resultado);
		if (row == NULL)
			printf ("No se han obtenido datos en la consulta\n");
		else
			printf ("Puntuacion: \n");
		while (row != NULL) {
			printf ("El jugador tiene:  %s puntos\n", row[0]);
			row = mysql_fetch_row (resultado);
			ronda++;
		}


		// cerrar la conexion con el servidor MYSQL 
		mysql_close (conn);
		exit(0);
}

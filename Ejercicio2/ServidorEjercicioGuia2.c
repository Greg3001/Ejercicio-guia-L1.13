#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
#include <ctype.h>

int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

int i, j;
int sockets[100];

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		int numForm;
		// Ya tenemos el c?digo de la petici?n
		char temperatura[20];
		
		if (codigo !=0)
		{
			p = strtok( NULL, "/");
			numForm =  atoi (p);
			p = strtok( NULL, "/");
			strcpy (temperatura, p);
			// Ya tenemos la temperatura
			printf ("Codigo: %d, Temperatura: %s\n", codigo, temperatura);
		}
		
		if (codigo ==0) //petici?n de desconexi?n
			terminar=1;
		else if (codigo ==1) {//Celcius a Farenheit
		
			p = strtok( NULL, "/");
			float grados_celsius = atof(p);
			float grados_fahrenheit = (grados_celsius * 9/5) + 32;
			
			sprintf (respuesta,"1/%d/%f",numForm, grados_fahrenheit);
		}
		else 
			// Farenheit a Celcius
			p = strtok( NULL, "/");
			float grados_fahrenheit = atof(p);
            		float grados_celsius = (grados_fahrenheit -32) *5/9;
			
			sprintf (respuesta,"2/%d/%f",numForm, grados_celsius);
			
			
			
			if (codigo !=0)
			{
				
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			if ((codigo ==1)||(codigo==2))
			{
				pthread_mutex_lock( &mutex ); //No me interrumpas ahora
				contador = contador +1;
				pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
				// notificar a todos los clientes conectados
				char notificacion[20];
				sprintf (notificacion, "3/%d",contador);
				int j;
				for (j=0; j< i; j++)
					write (sockets[j],notificacion, strlen(notificacion));
				
			}
			
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
	
}


int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
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
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	contador =0;
	
	pthread_t thread;
	i=0;
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}
	
}

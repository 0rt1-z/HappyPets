using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using Microsoft.Data.SqlClient;


namespace CapaDatos
{
    //esta clase es abstracta porque no puede ser instanciada solo se puede 
    //usar como una clase base
    public abstract class ConexionSql
    {

        private readonly string _connectionString; // Cadena de conexión privada para la base de datos
        
        public ConexionSql() // Constructor de la clase
        {
            // en este apartado creamos la cadena que nos permite la conexion con la BD 
            _connectionString = "SERVER="+Dns.GetHostName()+";DataBase=HappyPets; integrated security=true;TrustServerCertificate=true";
        }

        //Metodo protegido para obtener la conexion
        protected SqlConnection GetConnection()
        {
            //Esto nos devuelve una nueva instancia de SqlConnection usando la cadena de conexión predeterminada
            return new SqlConnection(_connectionString);
        }
        protected SqlConnection GetConnection(string connectionString) // Método protegido para obtener la conexión utilizando una cadena de conexión personalizada
        {
            return new SqlConnection(connectionString); // Devuelve una nueva instancia de SqlConnection usando la cadena de conexión proporcionada
        }


    }
}
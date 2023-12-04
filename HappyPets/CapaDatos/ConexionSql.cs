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
        private readonly string _connectionString;
        public ConexionSql()
        {
            _connectionString = "SERVER=MARVIN_GOMEZ;DataBase=HappyPets; integrated security=true;TrustServerCertificate=true";
        }

        //Metodo protegido para obtener la conexion
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        protected SqlConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }


    }
}
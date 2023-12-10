using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaDatos
{
    public class DatosBaño : ConexionSql
    {

        public string nombre, raza, edad, genero, observacion, servicio;
        public int RegistrarBaños(DatosBaño datos)
        {
            using var conexion = GetConnection(); // Obtiene una conexión utilizando el método de la clase base
            conexion.Open();
            using var cmd = new SqlCommand("INSERT INTO Cuidado(nombre,raza,edad,genero,servicio,observacion ) VALUES (@Nombre, @Raza, @Edad, @Genero, @Servicio, @Observacion)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", datos.nombre);
            cmd.Parameters.AddWithValue("@Raza", datos.raza);
            cmd.Parameters.AddWithValue("@Edad", datos.edad);
            cmd.Parameters.AddWithValue("@Genero", datos.genero);
            cmd.Parameters.AddWithValue("@Observacion", datos.observacion);
            cmd.Parameters.AddWithValue("@Servicio", datos.servicio);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

    }
}

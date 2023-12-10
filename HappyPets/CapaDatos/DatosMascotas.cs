using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DatosMascotas : ConexionSql
    {
        public string nombre, raza, tipo, color;
        public int edad, id, id_usuario;
        public double altura, peso;
        public int RegistroMascotas(DatosMascotas mascota)
        {
            using var conexion = GetConnection();
            conexion.Open();

            using var cmd = new SqlCommand("AgregarMascota", conexion); // Nombre del procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure; // Indica que se está ejecutando un procedimiento almacenado

            cmd.Parameters.AddWithValue("@Nombre", mascota.nombre);
            cmd.Parameters.AddWithValue("@Edad", mascota.edad);
            cmd.Parameters.AddWithValue("@Raza", mascota.raza);
            cmd.Parameters.AddWithValue("@Tipo", mascota.tipo);
            cmd.Parameters.AddWithValue("@Color", mascota.color);
            cmd.Parameters.AddWithValue("@Altura", mascota.altura);
            cmd.Parameters.AddWithValue("@Peso", mascota.peso);
            cmd.Parameters.AddWithValue("@Id_usuario", mascota.id_usuario);

            // Ejecuta el procedimiento almacenado
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}

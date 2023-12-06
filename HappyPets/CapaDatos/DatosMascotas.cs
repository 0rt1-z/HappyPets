using System;
using System.Collections.Generic;
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

            using var cmd = new SqlCommand("INSERT INTO Mascota (Nombre,Edad,Raza,Tipo,Color,Altura,Peso,Id_usuario) VALUES(@Nombre,@Edad,@Raza,@Tipo,@Color,@Altura,@Peso,@Id_usuario)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", mascota.nombre);
            cmd.Parameters.AddWithValue("@Edad", mascota.edad);
            cmd.Parameters.AddWithValue("@Raza", mascota.raza);
            cmd.Parameters.AddWithValue("@Tipo", mascota.tipo);
            cmd.Parameters.AddWithValue("@Color", mascota.color);
            cmd.Parameters.AddWithValue("@Altura", mascota.altura);
            cmd.Parameters.AddWithValue("@Peso", mascota.peso);
            cmd.Parameters.AddWithValue("@Id_usuario", mascota.id_usuario);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}

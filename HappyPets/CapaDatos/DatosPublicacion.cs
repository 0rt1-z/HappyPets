using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace CapaDatos
{
    public class DatosPublicacion : ConexionSql
    {
        public string texto;
        public byte[] foto;
        public int id_usuario;

        public int AgregarPublicacion(DatosPublicacion publicacion)
        {
            using var conexion = GetConnection();
            conexion.Open();

            using var cmd = new SqlCommand("INSERT INTO Publicacion (Texto, Foto, Id_usuario) VALUES(@texto, @foto, @Id_usuario)", conexion);
            cmd.Parameters.AddWithValue("@Texto", publicacion.texto);
            cmd.Parameters.AddWithValue("@Foto", publicacion.foto);
            cmd.Parameters.AddWithValue("@Id_usuario", publicacion.id_usuario);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public List<DatosPublicacion> ObtenerUltimasPublicaciones()
        {
            List<DatosPublicacion> ultimasPublicaciones = new List<DatosPublicacion>();

            using var conexion = GetConnection();
            conexion.Open();

            // Consulta SQL para obtener las últimas 3 filas ordenadas por Id_publicacion de forma descendente
            string consulta = "SELECT TOP 3 Texto, Foto FROM Publicacion ORDER BY Id_publicacion DESC";

            using var cmd = new SqlCommand(consulta, conexion);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DatosPublicacion publicacion = new DatosPublicacion
                {
                    texto = reader["Texto"].ToString(),
                    foto = (byte[])reader["Foto"]
                };
                ultimasPublicaciones.Add(publicacion);
            }

            return ultimasPublicaciones;
        }
    }
}

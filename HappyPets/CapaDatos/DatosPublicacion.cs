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
        public string texto, correo;
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

        public List<DatosPublicacion> ObtenerUltimasPublicaciones()  // Método para obtener las últimas publicaciones desde la base de datos
        {
            // Lista para almacenar las últimas publicaciones obtenidas desde la base de datos
            List<DatosPublicacion> ultimasPublicaciones = new List<DatosPublicacion>();

            using var conexion = GetConnection();
            conexion.Open();

            string consulta = "SELECT TOP 3 P.Texto, P.Foto, U.Correo " +
                      "FROM Publicacion P " +
                      "INNER JOIN Usuario U ON P.Id_usuario = U.Id_usuario " +
                      "ORDER BY P.Id_publicacion DESC";

            // Preparar y ejecutar la consulta SQL de selección
            using var cmd = new SqlCommand(consulta, conexion);
            using var reader = cmd.ExecuteReader();

            // Leer los resultados de la consulta y almacenarlos en la lista de últimas publicaciones
            while (reader.Read())
            {
                // Crear un objeto DatosPublicacion para cada fila y asignar valores desde el resultado de la consulta
                DatosPublicacion publicacion = new DatosPublicacion
                {
                    texto = reader["Texto"].ToString(),
                    foto = (byte[])reader["Foto"],
                    correo = reader["Correo"].ToString()
                };
                ultimasPublicaciones.Add(publicacion);
            }

            return ultimasPublicaciones;
        }
    }
}

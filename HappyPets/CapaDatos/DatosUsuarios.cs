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
    public class DatosUsuarios : ConexionSql
    {
        public string nombre, telefono, correo, contrasena;

        public bool Login(string username)
        {
            using var conexion = GetConnection();
            conexion.Open();
            using SqlCommand command = new SqlCommand("select * From Usuario where Correo = @usuario", conexion);
            command.Parameters.AddWithValue("@usuario", username);
            using SqlDataReader reader = command.ExecuteReader();

            return reader.HasRows;
        }

        public int RegistroUsuario(DatosUsuarios usuario) 
        {
            using var conexion = GetConnection();
            conexion.Open();

            using var cmd = new SqlCommand("INSERT INTO Usuario (Nombre, Telefono, Correo, Contraseña) VALUES(@nombre, @telefono, @correo, @contrasena)", conexion);
            cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
            cmd.Parameters.AddWithValue("@telefono", usuario.telefono);
            cmd.Parameters.AddWithValue("@correo", usuario.correo);
            cmd.Parameters.AddWithValue("@contrasena", usuario.contrasena);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

        public string CompararContrasena(string username)
        {
            string contrasenaUsuario = "";

            using var conexion = GetConnection();
            conexion.Open();
            SqlDataReader reader;
            using SqlCommand cmd = new SqlCommand("select * From Usuario where Correo = @usuario", conexion);
            cmd.Parameters.AddWithValue("@usuario", username);
            reader = cmd.ExecuteReader();
       
            while (reader.Read())
            {
                contrasenaUsuario = reader["Contraseña"].ToString();
            }

            return contrasenaUsuario;
        }

        public bool ExisteCorreo(string correo)
        {
            using var conexion = GetConnection();
            conexion.Open();
            using var cmd = new SqlCommand("SELECT * FROM Usuario WHERE correo = @correo", conexion);
            cmd.Parameters.AddWithValue("@correo", correo);
            bool existe = cmd.ExecuteReader().HasRows;
            return existe;
        }
    }
}

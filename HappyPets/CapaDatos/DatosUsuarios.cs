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

        public bool Login(string username, string password)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("select * From Usuario where Correo = @usuario and Contraseña = @contraseña", conexion))
                {
                    command.Parameters.AddWithValue("@usuario", username);
                    command.Parameters.AddWithValue("@contraseña", password);
                  
                    using(SqlDataReader reader = command.ExecuteReader())
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
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

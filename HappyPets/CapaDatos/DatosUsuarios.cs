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
        public bool Login(string username, string password)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("select * From Usuarios where NombreLogin = @usuario and Contraseña = @contraseña", conexion))
                {
                    command.Parameters.AddWithValue("@usuario", username);
                    command.Parameters.AddWithValue("contraseña", password);
                  
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
    }
}

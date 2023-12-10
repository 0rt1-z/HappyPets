using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosVacunacion : ConexionSql 
    {
        // definimos las variables 
        public string nombre, raza, tipo_vacuna;
        public int edad, id_usuario;
        public double peso;
        public DateTime fecha;

        public int RegistroVacunacion(DatosVacunacion vacunacion) // Método para registrar información de vacunación en la base de datos
        {
            using var conexion = GetConnection();
            conexion.Open();

           // Asignamos los valores a los parametros de la consulta con el objeto creado
            using var cmd = new SqlCommand("INSERT INTO Cita (Nombre,Raza,Edad,Peso,Tipo_Vacuna,Fecha,Id_usuario) VALUES(@Nombre,@Raza,@Edad,@Peso,@Tipo_Vacuna,@Fecha,@Id_usuario)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", vacunacion.nombre );
            cmd.Parameters.AddWithValue("@Raza", vacunacion.raza);
            cmd.Parameters.AddWithValue("@Edad", vacunacion.edad);
            cmd.Parameters.AddWithValue("@Peso", vacunacion.peso);
            cmd.Parameters.AddWithValue("@Tipo_Vacuna", vacunacion.tipo_vacuna);
            cmd.Parameters.AddWithValue("@Fecha", vacunacion.fecha);
            cmd.Parameters.AddWithValue("@Id_usuario", vacunacion.id_usuario);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }   
}

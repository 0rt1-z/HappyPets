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
        public int edad;
        public double peso;
        public DateTime fecha;

        public int RegistroVacunacion(DatosVacunacion vacunacion) // Método para registrar información de vacunación en la base de datos
        {
            using var conexion = GetConnection();
            conexion.Open();

<<<<<<< Updated upstream
            using var cmd = new SqlCommand("INSERT INTO Cita (Nombre,Raza,Edad,Peso,Tipo_Vacuna,Fecha) VALUES(@Nombre,@Raza,@Edad,@Peso,@Tipo_Vacuna,@Fecha)", conexion);
=======
            using var cmd = new SqlCommand("INSERT INTO Cita (Nombre,Raza,Edad,Peso,Tipo_Vacuna,Fecha,Id_usuario) VALUES(@Nombre,@Raza,@Edad,@Peso,@Tipo_Vacuna,@Fecha,@Id_usuario)", conexion);
           // Asignamos los valores a los parametros de la consulta con el objeto creado
>>>>>>> Stashed changes
            cmd.Parameters.AddWithValue("@Nombre", vacunacion.nombre );
            cmd.Parameters.AddWithValue("@Raza", vacunacion.raza);
            cmd.Parameters.AddWithValue("@Edad", vacunacion.edad);
            cmd.Parameters.AddWithValue("@Peso", vacunacion.peso);
            cmd.Parameters.AddWithValue("@Tipo_Vacuna", vacunacion.tipo_vacuna);
            cmd.Parameters.AddWithValue("@Fecha", vacunacion.fecha);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }   
}

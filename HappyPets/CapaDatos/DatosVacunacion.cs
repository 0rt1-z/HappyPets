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
        public string nombre, raza, tipo_vacuna;
        public int edad;
        public double peso;
        public DateTime fecha;

        public int RegistroVacunacion(DatosVacunacion vacunacion)
        {
            using var conexion = GetConnection();
            conexion.Open();

            using var cmd = new SqlCommand("INSERT INTO Cita (Nombre,Raza,Edad,Peso,Tipo_Vacuna,Fecha) VALUES(@Nombre,@Raza,@Edad,@Peso,@Tipo_Vacuna,@Fecha)", conexion);
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

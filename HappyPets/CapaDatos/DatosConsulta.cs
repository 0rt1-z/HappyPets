using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosConsulta : ConexionSql
    {
        public string nombre, MotivoConsulta;
        public int edad;
        public double peso;

        public int RegistroConsulta(DatosConsulta consulta)
        {
            using var conexion = GetConnection();
            conexion.Open();

            using var cmd = new SqlCommand("INSERT INTO Consulta (Nombre,Edad,Peso,Motivo_Consulta) VALUES(@Nombre,@Edad,@Peso,@Motivo_Consulta)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", consulta.nombre);
            cmd.Parameters.AddWithValue("@Edad", consulta.edad);
            cmd.Parameters.AddWithValue("@Peso", consulta.peso);
            cmd.Parameters.AddWithValue("@Motivo_Consulta", consulta.MotivoConsulta);
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }
    }
}

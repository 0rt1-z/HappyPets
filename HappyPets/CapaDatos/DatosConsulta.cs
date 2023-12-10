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
        // creacion de variables que se ocuparan para el form consulta
        public string nombre, MotivoConsulta;
        public int edad;
        public double peso;

        public int RegistroConsulta(DatosConsulta consulta)
        {
            // Se establece una conexión a la base de datos utilizando la clase base ConexionSql
            // Se obtiene una instancia de conexión y Se abre la conexión con la base de datos
            using var conexion = GetConnection(); 
            conexion.Open();

<<<<<<< Updated upstream
            using var cmd = new SqlCommand("INSERT INTO Consulta (Nombre,Edad,Peso,Motivo_Consulta) VALUES(@Nombre,@Edad,@Peso,@Motivo_Consulta)", conexion);
            cmd.Parameters.AddWithValue("@Nombre", consulta.nombre);
            cmd.Parameters.AddWithValue("@Edad", consulta.edad);
            cmd.Parameters.AddWithValue("@Peso", consulta.peso);
            cmd.Parameters.AddWithValue("@Motivo_Consulta", consulta.MotivoConsulta);
            int resultado = cmd.ExecuteNonQuery();
=======
            // Se crea un comando SQL para insertar datos en la tabla Consulta
            using var cmd = new SqlCommand("INSERT INTO Consulta (Nombre,Edad,Peso,Motivo_Consulta,Id_usuario) VALUES(@Nombre,@Edad,@Peso,@Motivo_Consulta,@Id_usuario)", conexion);
            // Se asignan valores a los parámetros del comando SQL con los datos de la consulta proporcionados
            cmd.Parameters.AddWithValue("@Nombre", consulta.nombre);// Se asigna el valor del campo nombre de la consulta
            cmd.Parameters.AddWithValue("@Edad", consulta.edad);// Se asigna el valor del campo edad de la consulta
            cmd.Parameters.AddWithValue("@Peso", consulta.peso);// Se asigna el valor del campo peso de la consulta
            cmd.Parameters.AddWithValue("@Motivo_Consulta", consulta.MotivoConsulta);// Se asigna el valor del campo MotivoConsulta de la consulta
            cmd.Parameters.AddWithValue("@Id_usuario", consulta.id_usuario);// Se asigna el valor del campo id_usuario de la consulta

            // Se ejecuta el comando SQL para insertar los datos en la base de datos
            // y se guarda el número de filas afectadas
            int resultado = cmd.ExecuteNonQuery();// Se ejecuta la consulta y se obtiene el número de filas afectadas
           
            // Se devuelve el número de filas afectadas por la operación de inserción
>>>>>>> Stashed changes
            return resultado;

        }
    }
}

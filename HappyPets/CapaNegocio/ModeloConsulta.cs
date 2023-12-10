using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ModeloConsulta
    {
        // Creación de una instancia de DatosConsulta para utilizar en esta clase
        DatosConsulta DatosConsulta = new DatosConsulta();

        public string RegistrarConsulta(DatosConsulta consulta) // Método para registrar una consulta
        {
            string respuesta = ""; // Variable para almacenar la respuesta

            try
            {
                DatosConsulta.RegistroConsulta(consulta); // Se intenta registrar la consulta llamando al método RegistroConsulta de DatosConsulta
            }
            catch (Exception ex)
            {
                respuesta = "Ha ocurrido un error: " + ex.Message;
            }
            return respuesta;
        }
    }
}

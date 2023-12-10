using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ModeloVacunacion
    {
        DatosVacunacion datosVacunacion = new DatosVacunacion(); // Instancia de la clase DatosVacunacion

        public string RegistrarVacuna(DatosVacunacion vacunacion) // Método para registrar una vacunación
        {
            string respuesta = "";

            try
            {
                datosVacunacion.RegistroVacunacion(vacunacion);
            }
            catch (Exception ex)
            {
                respuesta = "Ha ocurrido un error: " + ex.Message;
            }
            return respuesta;
        }
        
    }
}

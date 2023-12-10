using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ModeloMascota
    {
        // Creación de una instancia de DatosMascotas para utilizar en esta clase
        DatosMascotas datosMascotas = new DatosMascotas();

        public string RegistrarMascota(DatosMascotas mascota) // Método para registrar una mascota
        {
            string respuesta = "";

            try
            {
                datosMascotas.RegistroMascotas(mascota);
            }
            catch (Exception ex)
            {
                respuesta = "Ha ocurrido un error: " + ex.Message;
            }
            return respuesta;
        }

    }
}

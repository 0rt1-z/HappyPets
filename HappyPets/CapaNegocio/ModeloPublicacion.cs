using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ModeloPublicacion
    {
        // Creación de una instancia de DatosPublicacion para utilizar en esta clase
        DatosPublicacion datosPublicacion = new DatosPublicacion();
        public string AgregarPublicacion(DatosPublicacion publicacion) // Método para agregar una publicación
        {
            string respuesta = "";
            datosPublicacion.AgregarPublicacion(publicacion);
            return respuesta;
        }
    }
}

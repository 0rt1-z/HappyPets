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
        DatosPublicacion datosPublicacion = new DatosPublicacion();
        public string AgregarPublicacion(DatosPublicacion publicacion)
        {
            string respuesta = "";
            datosPublicacion.AgregarPublicacion(publicacion);
            return respuesta;
        }
    }
}

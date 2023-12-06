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

        DatosConsulta DatosConsulta = new DatosConsulta();

        public string RegistrarConsulta(DatosConsulta consulta)
        {
            string respuesta = "";

            try
            {
                DatosConsulta.RegistroConsulta(consulta);
            }
            catch (Exception ex)
            {
                respuesta = "Ha ocurrido un error: " + ex.Message;
            }
            return respuesta;
        }
    }
}

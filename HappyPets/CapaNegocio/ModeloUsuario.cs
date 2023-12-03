using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloUsuario
    {
        DatosUsuarios datosUsuarios = new DatosUsuarios();
        public bool LoginUsuarios(string username , string password)
        {
            return datosUsuarios.Login(username, password);
        }
    }
}

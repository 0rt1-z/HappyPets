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

        public string RegistrarUsuario(DatosUsuarios usuario)
        {
            string respuesta = "";

            try
            {
                bool existeCorreo = datosUsuarios.ExisteCorreo(usuario.correo);

                if (existeCorreo)
                {
                    respuesta = "El correo electrónico ya se encuentra en nuestros registros";
                } 
                else
                {
                    datosUsuarios.RegistroUsuario(usuario);
                }
            }
            catch (Exception ex)
            {
                respuesta = "Ha ocurrido un error: " + ex.Message;
            }

            return respuesta;
        }
    }
}

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
        Password pass = new Password();

        public bool LoginUsuarios(string username , string password)
        {
            bool existeUsuario = datosUsuarios.Login(username);

            if (existeUsuario)
            {
                return datosUsuarios.CompararContrasena(username) == pass.Encriptar(password);
            }
            else
            {
                return false;
            }
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
                    usuario.contrasena = pass.Encriptar(usuario.contrasena);
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

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
        DatosUsuarios datosUsuarios = new DatosUsuarios(); // Instancia de la clase DatosUsuarios
        Password pass = new Password(); // Instancia de la clase Password (posiblemente para manejar contraseñas)

        public bool LoginUsuarios(string username, string password) 
        {
            //Validando si existe usuario
            bool existeUsuario = datosUsuarios.Login(username);

            if (existeUsuario)
            {
                //Onteniendo datos de usuario para registrarlos en sesion
                DatosUsuarios us = datosUsuarios.ObtenerDatosSession(username);

                // Comparando contraseña ingresada por el usuario con la de la BD
                if (datosUsuarios.CompararContrasena(username) == pass.Encriptar(password))
                {
                    Session.idUsuario = us.id;
                    Session.nombre = us.nombre;
                    Session.correo = us.correo;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string RegistrarUsuario(DatosUsuarios usuario) // Método para registrar un nuevo usuario
        {
            string respuesta = "";

            try
            {
                // Verificar si el correo electrónico del usuario ya existe en la base de datos
                bool existeCorreo = datosUsuarios.ExisteCorreo(usuario.correo);

                if (existeCorreo)
                {
                    respuesta = "El correo electrónico ya se encuentra en nuestros registros";
                } 
                else
                {
                    // Encriptar la contraseña antes de almacenarla en la base de datos
                    usuario.contrasena = pass.Encriptar(usuario.contrasena);
                    // Registrar el nuevo usuario en la base de datos
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

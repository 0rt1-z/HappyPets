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

        public bool LoginUsuarios(string username , string password)  // Método para iniciar sesión de usuarios
        {
            bool existeUsuario = datosUsuarios.Login(username); // Verificar si existe el usuario con el nombre de usuario proporcionado

            if (existeUsuario)
            {
<<<<<<< Updated upstream
                return datosUsuarios.CompararContrasena(username) == pass.Encriptar(password);
=======
                // Si el usuario existe, obtener sus datos de sesión
                DatosUsuarios us = datosUsuarios.ObtenerDatosSession(username);

                // Verificar si la contraseña encriptada coincide con la contraseña proporcionada
                if (datosUsuarios.CompararContrasena(username) == pass.Encriptar(password))
                {
                    // Si coinciden, se asignan los datos de usuario a la sesión y se retorna true
                    Session.idUsuario = us.id;
                    Session.nombre = us.nombre;
                    Session.correo = us.correo;
                    return true;
                }
                else
                {
                    // Si no coinciden retorna false 
                    return false;
                }
>>>>>>> Stashed changes
            }
            else
            {
                // y si el usuario no existe retornara false
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

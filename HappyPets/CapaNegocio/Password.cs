using System.Text;
using System.Security.Cryptography;

namespace CapaNegocio
{
    public class Password
    {
        public string Encriptar(string contrasena) // Método para encriptar una contraseña usando el algoritmo SHA1
        {
            // Crear una instancia de UTF8Encoding para convertir la cadena a bytes UTF-8
            UTF8Encoding enc = new UTF8Encoding();  
            // Convertir la cadena de contraseña a una secuencia de bytes UTF-8
            byte[] data = enc.GetBytes(contrasena);
            // Variable para almacenar el resultado del hash
            byte[] resultado;

            // Crear un proveedor de servicios de hash SHA1
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            // Calcular el hash SHA1 de la contraseña
            resultado = sha.ComputeHash(data);

            // Crear un objeto StringBuilder para construir la representación hexadecimal del hash
            StringBuilder sb = new StringBuilder();

            // Recorrer el array de bytes resultado y convertir cada byte a su representación hexadecimal
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] < 16)
                {
                    // Si el byte es menor que 16, agregar un '0' para mantener la representación hexadecimal de dos dígitos
                    sb.Append("0");
                }
                // Convertir el byte a su representación hexadecimal y agregarlo al StringBuilder
                sb.Append(resultado[i].ToString("x"));
            }

            // Devolver el hash en su representación hexadecimal como una cadena
            return sb.ToString();
        }
    }
}

using System.Text;
using System.Security.Cryptography;

namespace CapaNegocio
{
    public class Password
    {
        public string Encriptar(string contrasena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(contrasena);
            byte[] resultado;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            resultado = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(resultado[i].ToString("x"));
            }


            return sb.ToString();
        }
    }
}

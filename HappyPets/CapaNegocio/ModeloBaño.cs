using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class ModeloBaño
    {
        public int RegistrarBaños(string nombre, string raza, string edad, string genero, string observacion, string servicio)
        {
            // se validad los datos antes de  enviarlos a la capa de datos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(raza) || string.IsNullOrEmpty(edad) || string.IsNullOrEmpty(genero))
            {
                //excepción por campos obligatorios                
                throw new ArgumentException("Los campos obligatorios no pueden estar vacíos.");
            }

            DatosBaño datosBaño = new DatosBaño
            {
                nombre = nombre,
                raza = raza,
                edad = edad,
                genero = genero,
                observacion = observacion,
                servicio = servicio
            };

            // Llamada a la capa de datos para registrar los baños.
            DatosBaño capaDatos = new DatosBaño();
            int resultado = capaDatos.RegistrarBaños(datosBaño);
            return resultado;
        }
    }
}
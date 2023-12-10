using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Bano : Form
    {
        public Bano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obteniendo los valores de las cajas de texto del formulario
                string nombre = txtNombre.Text;
                string raza = txtRaza.Text;
                string edad = txtEdad.Text;
                string genero = radMacho.Checked ? "Macho" : "Hembra";
                string servicio = radBaño.Checked ? "Baño" : (radCorte.Checked ? "Corte" : "Uñas");
                string observacion = richComentario.Text;

                ModeloBaño modeloBaño = new ModeloBaño();
                // Llama al método de la capa de negocio para registrar el baño
                int resultado = modeloBaño.RegistrarBaños(nombre, raza, edad, genero, observacion, servicio);


                // Verifica el resultado y muestra un mensaje
                if (resultado > 0)
                {
                    MessageBox.Show("Baño registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Metodo de limpieza de botones
                    LimpiarCajas();
                }
                else
                {
                    MessageBox.Show("Error al registrar el baño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                // excepción de argumento inválido (campos obligatorios vacíos)
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Metodo de limpieza de las cajas de texto
        public void LimpiarCajas()
        {
            
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
            radMacho.Checked = false;
            radHembra.Checked = false;
            radBaño.Checked = false;
            radCorte.Checked = false;
            radUñas.Checked = false;
            richComentario.Clear();
        }
    }
}

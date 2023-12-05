using CapaDatos;
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
    public partial class Vacunacion : Form
    {
        public Vacunacion()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text)
                    || string.IsNullOrEmpty(txtTipoVacuna.Text) || string.IsNullOrEmpty(txtTipoVacuna.Text)
                    || string.IsNullOrEmpty(txtRaza.Text) || string.IsNullOrEmpty(calFechaVacuna.SelectionStart.ToString())
                )
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DatosVacunacion datosVacunacion = new DatosVacunacion();
                    datosVacunacion.nombre = txtNombre.Text;
                    datosVacunacion.raza = txtRaza.Text;
                    datosVacunacion.edad = Convert.ToInt32(txtEdad.Text);
                    datosVacunacion.peso = Convert.ToDouble(txtTipoVacuna.Text);
                    datosVacunacion.tipo_vacuna = txtTipoVacuna.Text;
                    datosVacunacion.fecha = calFechaVacuna.SelectionStart;

                    ModeloVacunacion vacunacion = new ModeloVacunacion();
                    string respuesta = vacunacion.RegistrarVacuna(datosVacunacion);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("datos registrados", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

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
    public partial class Consulta : Form
    {

        public Consulta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombreMascota.Text) || string.IsNullOrEmpty(txtEdadMascota.Text)
                    || string.IsNullOrEmpty(txtPesoMascota.Text) || string.IsNullOrEmpty(rchComentarioConsulta.Text)

                )
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DatosConsulta datosConsulta = new DatosConsulta();
                    datosConsulta.nombre = txtnombreMascota.Text;
                    datosConsulta.edad = Convert.ToInt32(txtEdadMascota.Text);
                    datosConsulta.peso = Convert.ToDouble(txtPesoMascota.Text);
                    datosConsulta.MotivoConsulta = rchComentarioConsulta.Text;
                    datosConsulta.id_usuario = Session.idUsuario;

                    ModeloConsulta consulta = new ModeloConsulta();
                    string respuesta = consulta.RegistrarConsulta(datosConsulta);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("datos registrados", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Inicio inicio = new Inicio();
                        inicio.Show();
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

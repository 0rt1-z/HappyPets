using CapaNegocio;
using CapaDatos;
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
    public partial class DatosMascotas : Form
    {
        Session session= new Session();
        public DatosMascotas()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text)
                    || string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrEmpty(txtAltura.Text)
                    || string.IsNullOrEmpty(txtRaza.Text) || string.IsNullOrEmpty(txtColor.Text)
                    || string.IsNullOrEmpty(txtTipo.Text) 
                )
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DatosMascotas datosMascotas = new DatosMascotas();
                    datosMascotas.nombre = txtNombre.Text;
                    datosMascotas.raza = txtRaza.Text;
                    datosMascotas.edad = Convert.ToInt32(txtEdad.Text);
                    datosMascotas.peso = Convert.ToDouble(txtPeso.Text);
                    datosMascotas.tipo = txtTipo.Text;
                    datosMascotas.color = txtColor.Text;
                    datosMascotas.txtAltura = Convert.ToDouble(txtAltura.Text);
                    datosMascotas.id_usuario = session.idUsuario;


                    ModeloMascota mascota = new ModeloMascota();
                    string respuesta = mascota.RegistrarMascota(datosMascotas);

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

            this.Hide();

            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}

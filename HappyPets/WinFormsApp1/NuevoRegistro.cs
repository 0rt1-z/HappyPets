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
    public partial class NuevoRegistro : Form
    {
        public NuevoRegistro()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                    || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContrasena.Text)
                )
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    DatosUsuarios datosUsuarios = new DatosUsuarios();
                    datosUsuarios.nombre = txtNombre.Text;
                    datosUsuarios.telefono = txtTelefono.Text;
                    datosUsuarios.correo = txtCorreo.Text;
                    datosUsuarios.contrasena = txtContrasena.Text;

                    ModeloUsuario usuario = new ModeloUsuario();
                    string respuesta = usuario.RegistrarUsuario(datosUsuarios);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario registrado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

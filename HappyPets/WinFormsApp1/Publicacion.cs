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
    public partial class Publicacion : Form
    {
        public Publicacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrirCarpetas = new OpenFileDialog())
            {
                abrirCarpetas.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
                abrirCarpetas.Title = "Seleccionar imagen";

                if (abrirCarpetas.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen seleccionada en el PictureBox
                        picPublicacionImage.Image = Image.FromFile(abrirCarpetas.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbTextoPublicacion.Text) || picPublicacionImage.Image == null)
                {
                    MessageBox.Show("Los campos son obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DatosPublicacion datosPublicacion = new DatosPublicacion();
                    datosPublicacion.texto = rtbTextoPublicacion.Text;
                    ImageConverter converter = new ImageConverter();
                    datosPublicacion.foto = (byte[])converter.ConvertTo(picPublicacionImage.Image, typeof(byte[]));
                    datosPublicacion.id_usuario = Session.idUsuario;
                    ModeloPublicacion publicacion = new ModeloPublicacion();
                    string respuesta = publicacion.AgregarPublicacion(datosPublicacion);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Publicacion exitosa", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

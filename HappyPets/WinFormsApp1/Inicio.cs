﻿using CapaDatos;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void mostrarFormularios(Form formulario)
        {
            panelEscritorio.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formulario);
            formulario.Show();
        }

        private void mASCOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new RegistroMascotas());
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }



        private void cONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Consulta());
        }

        private void vACUNACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Vacunacion());
        }

        private void bAÑOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormularios(new Bano());
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nUEVACITAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Publicacion fr = new Publicacion();
            //Hide();
            //fr.ShowDialog();
            //Show();
            mostrarFormularios(new Publicacion());
        }

        private void btnMUPublicaciones_Click(object sender, EventArgs e)
        {
            grpPOne.Visible = true;
            grpPTwo.Visible = true;
            grpPThree.Visible = true;
            MostrarUltimasPublicaciones();
        }

        private void MostrarUltimasPublicaciones()
        {
            try
            {
                DatosPublicacion datosPublicacion = new DatosPublicacion();
                var ultimasPublicaciones = datosPublicacion.ObtenerUltimasPublicaciones();

                // Ocultar todos los GroupBox al principio
                grpPOne.Visible = false;
                grpPTwo.Visible = false;
                grpPThree.Visible = false;

                // Verificar la cantidad de registros y mostrar los GroupBox correspondientes
                if (ultimasPublicaciones.Count >= 1)
                {
                    grpPOne.Visible = true;
                    grpPOne.Text = ultimasPublicaciones[0].correo;
                    lblTextOne.Text = ultimasPublicaciones[0].texto;
                    picImageOne.Image = ConvertirBytesAImagen(ultimasPublicaciones[0].foto);
                    btnMUPublicaciones.Text = "Actualizar Ultimas Publicaciones";
                }

                if (ultimasPublicaciones.Count >= 2)
                {
                    grpPTwo.Visible = true;
                    grpPTwo.Text = ultimasPublicaciones[1].correo;
                    lblTextTwo.Text = ultimasPublicaciones[1].texto;
                    picImageTwo.Image = ConvertirBytesAImagen(ultimasPublicaciones[1].foto);
                }

                if (ultimasPublicaciones.Count >= 3)
                {
                    grpPThree.Visible = true;
                    grpPThree.Text = ultimasPublicaciones[2].correo;
                    lblTextThree.Text = ultimasPublicaciones[2].texto;
                    picImageThree.Image = ConvertirBytesAImagen(ultimasPublicaciones[2].foto);
                }

                // Mostrar mensaje de error si no hay datos
                if (ultimasPublicaciones.Count == 0)
                {
                    throw new Exception("No hay publicaciones disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes == null)
                return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void grpPOne_Enter(object sender, EventArgs e)
        {

        }

        private void iNICIOtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}

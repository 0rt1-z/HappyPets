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
            mostrarFormularios(new DatosMascotas());
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}

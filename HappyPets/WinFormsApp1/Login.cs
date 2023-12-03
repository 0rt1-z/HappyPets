using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.VisualBasic.ApplicationServices;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegistrarL_Click(object sender, EventArgs e)
        {
            NuevoRegistro formularioRegistro = new NuevoRegistro();
            formularioRegistro.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    ModeloUsuario modeloUsuario = new ModeloUsuario();
                    var validLogin = modeloUsuario.LoginUsuarios(txtUsuario.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Datos Incorrectos de Usuario y contraseña");
                        txtUsuario.Clear();
                        txtPassword.Clear();
                    }

                }
                else msgError("Ingrese una contraseña Valida");
            }
            else msgError("Porfavor Ingrese su Usuario");
        }
        private void msgError(string msg)
        {
            lblErrorMensaje.Text = "" + msg;
            lblErrorMensaje.Visible = true;
        }
    }
}

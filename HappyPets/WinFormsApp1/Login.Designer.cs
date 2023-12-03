namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAcceder = new Button();
            linkLabel1 = new LinkLabel();
            btnRegistrarL = new Button();
            picMinimizar = new PictureBox();
            picCerrar = new PictureBox();
            lblErrorMensaje = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 155, 247);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 455);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.perro;
            pictureBox3.Location = new Point(35, 113);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(312, 300);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(480, 136);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(376, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(480, 220);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 23);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(485, 98);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(480, 189);
            label2.Name = "label2";
            label2.Size = new Size(147, 27);
            label2.TabIndex = 4;
            label2.Text = "CONTRASEÑA";
            // 
            // btnAcceder
            // 
            btnAcceder.Cursor = Cursors.Hand;
            btnAcceder.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.Location = new Point(490, 355);
            btnAcceder.Margin = new Padding(3, 4, 3, 4);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(167, 58);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(575, 311);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(204, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Has olvidado tu contraseña?";
            // 
            // btnRegistrarL
            // 
            btnRegistrarL.Cursor = Cursors.Hand;
            btnRegistrarL.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarL.Location = new Point(689, 355);
            btnRegistrarL.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarL.Name = "btnRegistrarL";
            btnRegistrarL.Size = new Size(167, 58);
            btnRegistrarL.TabIndex = 9;
            btnRegistrarL.Text = "REGISTRAR";
            btnRegistrarL.UseVisualStyleBackColor = true;
            btnRegistrarL.Click += btnRegistrarL_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = Properties.Resources.icon_minimizar_negro;
            picMinimizar.Location = new Point(810, 15);
            picMinimizar.Margin = new Padding(3, 4, 3, 4);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(46, 50);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 8;
            picMinimizar.TabStop = false;
            picMinimizar.Click += pictureBox2_Click;
            // 
            // picCerrar
            // 
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = Properties.Resources.icon_cerrar_negro;
            picCerrar.Location = new Point(862, 15);
            picCerrar.Margin = new Padding(3, 4, 3, 4);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(46, 50);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 7;
            picCerrar.TabStop = false;
            picCerrar.Click += pictureBox1_Click;
            // 
            // lblErrorMensaje
            // 
            lblErrorMensaje.AutoSize = true;
            lblErrorMensaje.Location = new Point(484, 264);
            lblErrorMensaje.Name = "lblErrorMensaje";
            lblErrorMensaje.Size = new Size(121, 20);
            lblErrorMensaje.TabIndex = 10;
            lblErrorMensaje.Text = "Mensaje de Error";
            lblErrorMensaje.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(925, 455);
            Controls.Add(lblErrorMensaje);
            Controls.Add(btnRegistrarL);
            Controls.Add(picMinimizar);
            Controls.Add(picCerrar);
            Controls.Add(linkLabel1);
            Controls.Add(btnAcceder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnAcceder;
        private LinkLabel linkLabel1;
        private PictureBox picCerrar;
        private PictureBox picMinimizar;
        private PictureBox pictureBox3;
        private Button btnRegistrarL;
        private Label lblErrorMensaje;
    }
}


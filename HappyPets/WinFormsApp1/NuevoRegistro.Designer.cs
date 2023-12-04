namespace CapaPresentacion
{
    partial class NuevoRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picMinimizarR = new PictureBox();
            picCerrarR = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            btnRegistrar = new Button();
            txtTelefono = new MaskedTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picMinimizarR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picMinimizarR
            // 
            picMinimizarR.Cursor = Cursors.Hand;
            picMinimizarR.Image = Properties.Resources.icon_minimizar_negro;
            picMinimizarR.Location = new Point(862, 15);
            picMinimizarR.Margin = new Padding(3, 4, 3, 4);
            picMinimizarR.Name = "picMinimizarR";
            picMinimizarR.Size = new Size(56, 49);
            picMinimizarR.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizarR.TabIndex = 2;
            picMinimizarR.TabStop = false;
            picMinimizarR.Click += pictureBox2_Click;
            // 
            // picCerrarR
            // 
            picCerrarR.Cursor = Cursors.Hand;
            picCerrarR.Image = Properties.Resources.icon_cerrar_negro;
            picCerrarR.Location = new Point(924, 15);
            picCerrarR.Margin = new Padding(3, 4, 3, 4);
            picCerrarR.Name = "picCerrarR";
            picCerrarR.Size = new Size(56, 49);
            picCerrarR.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrarR.TabIndex = 1;
            picCerrarR.TabStop = false;
            picCerrarR.Click += picCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(393, 54);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(447, 420);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 3;
            label1.Text = "NUEVO USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "CORREO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 94);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "TELEFONO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 226);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 7;
            label5.Text = "CONTRASEÑA:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(121, 19);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(121, 152);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(323, 27);
            txtCorreo.TabIndex = 11;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(121, 219);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(323, 27);
            txtContrasena.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(577, 66);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(188, 114);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(121, 86);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(77, 27);
            txtTelefono.TabIndex = 15;
            txtTelefono.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 194, 194);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtContrasena);
            panel1.Location = new Point(60, 508);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 272);
            panel1.TabIndex = 16;
            // 
            // NuevoRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1021, 825);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(picMinimizarR);
            Controls.Add(picCerrarR);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NuevoRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoRegistro";
            ((System.ComponentModel.ISupportInitialize)picMinimizarR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrarR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picCerrarR;
        private PictureBox picMinimizarR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Button btnRegistrar;
        private MaskedTextBox txtTelefono;
        private Panel panel1;
    }
}
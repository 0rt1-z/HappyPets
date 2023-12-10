namespace CapaPresentacion
{
    partial class RegistroMascotas
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtTipo = new TextBox();
            label8 = new Label();
            btnRegistrarMascota = new Button();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            txtColor = new TextBox();
            txtEdad = new MaskedTextBox();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(138, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 194, 194);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnRegistrarMascota);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtColor);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtRaza);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(138, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 268);
            panel1.TabIndex = 1;
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(115, 160);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(88, 23);
            txtTipo.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 160);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 14;
            label8.Text = "TIPO:";
            // 
            // btnRegistrarMascota
            // 
            btnRegistrarMascota.Cursor = Cursors.Hand;
            btnRegistrarMascota.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarMascota.Location = new Point(312, 179);
            btnRegistrarMascota.Name = "btnRegistrarMascota";
            btnRegistrarMascota.Size = new Size(161, 59);
            btnRegistrarMascota.TabIndex = 13;
            btnRegistrarMascota.Text = "GUARDAR";
            btnRegistrarMascota.UseVisualStyleBackColor = true;
            btnRegistrarMascota.Click += btnRegistrarMascota_Click;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(564, 129);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(88, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(564, 81);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(88, 23);
            txtAltura.TabIndex = 11;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(564, 32);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(88, 23);
            txtColor.TabIndex = 10;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(115, 80);
            txtEdad.Mask = "99";
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(59, 23);
            txtEdad.TabIndex = 9;
            txtEdad.ValidatingType = typeof(int);
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRaza.Location = new Point(115, 123);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(240, 23);
            txtRaza.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(115, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 23);
            txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 38);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 5;
            label6.Text = "COLOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 126);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "PESO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 80);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "ALTURA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "RAZA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "EDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(469, 349);
            label7.Name = "label7";
            label7.Size = new Size(176, 19);
            label7.TabIndex = 2;
            label7.Text = "REGISTRO MASCOTA";
            // 
            // DatosMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1079, 588);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosMascotas";
            Text = "Registro-Mascotas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private MaskedTextBox txtEdad;
        private Button btnRegistrarMascota;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private TextBox txtColor;
        private Label label7;
        private Label label8;
        private TextBox txtTipo;
    }
}
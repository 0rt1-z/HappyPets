namespace CapaPresentacion
{
    partial class Vacunacion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            calFechaVacuna = new MonthCalendar();
            label5 = new Label();
            label6 = new Label();
            txtTipoVacuna = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(56, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 132);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 184);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "RAZA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 241);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "EDAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 132);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "PESO:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(408, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 24);
            txtNombre.TabIndex = 5;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRaza.Location = new Point(408, 173);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(211, 24);
            txtRaza.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(408, 230);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(211, 24);
            txtEdad.TabIndex = 7;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(794, 126);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(211, 24);
            txtPeso.TabIndex = 8;
            // 
            // calFechaVacuna
            // 
            calFechaVacuna.Location = new Point(408, 300);
            calFechaVacuna.Margin = new Padding(8, 8, 8, 8);
            calFechaVacuna.Name = "calFechaVacuna";
            calFechaVacuna.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 300);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "FECHA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(662, 186);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "TIPO DE VACUNA:";
            // 
            // txtTipoVacuna
            // 
            txtTipoVacuna.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoVacuna.Location = new Point(794, 179);
            txtTipoVacuna.Name = "txtTipoVacuna";
            txtTipoVacuna.Size = new Size(211, 24);
            txtTipoVacuna.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(804, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 76);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // Vacunacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1079, 591);
            Controls.Add(btnGuardar);
            Controls.Add(txtTipoVacuna);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(calFechaVacuna);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vacunacion";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private MonthCalendar calFechaVacuna;
        private Label label5;
        private Label label6;
        private TextBox txtTipoVacuna;
        private Button btnGuardar;
    }
}
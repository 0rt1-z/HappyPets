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
            txtTipoVacuna = new TextBox();
            calFechaVacuna = new MonthCalendar();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(64, 128);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 176);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 246);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "RAZA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 321);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "EDAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 176);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 4;
            label4.Text = "PESO:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(466, 172);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 28);
            txtNombre.TabIndex = 5;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRaza.Location = new Point(466, 231);
            txtRaza.Margin = new Padding(3, 4, 3, 4);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(241, 28);
            txtRaza.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(466, 306);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(241, 28);
            txtEdad.TabIndex = 7;
            // 
            // txtTipoVacuna
            // 
            txtTipoVacuna.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoVacuna.Location = new Point(908, 168);
            txtTipoVacuna.Margin = new Padding(3, 4, 3, 4);
            txtTipoVacuna.Name = "txtTipoVacuna";
            txtTipoVacuna.Size = new Size(241, 28);
            txtTipoVacuna.TabIndex = 8;
            // 
            // calFechaVacuna
            // 
            calFechaVacuna.Location = new Point(466, 400);
            calFechaVacuna.Margin = new Padding(9, 11, 9, 11);
            calFechaVacuna.Name = "calFechaVacuna";
            calFechaVacuna.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 400);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "FECHA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(757, 248);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 11;
            label6.Text = "TIPO DE VACUNA:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(908, 239);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 28);
            textBox5.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(919, 500);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 102);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // Vacunacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1233, 899);
            Controls.Add(btnGuardar);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(calFechaVacuna);
            Controls.Add(txtTipoVacuna);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtTipoVacuna;
        private MonthCalendar calFechaVacuna;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button btnGuardar;
    }
}
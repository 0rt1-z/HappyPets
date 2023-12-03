namespace CapaPresentacion
{
    partial class Consulta
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEdadMascota = new TextBox();
            txtPesoMascota = new TextBox();
            label3 = new Label();
            rchComentarioConsulta = new RichTextBox();
            label4 = new Label();
            txtnombreMascota = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 306);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "EDAD:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(90, 36);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 358);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "PESO";
            // 
            // txtEdadMascota
            // 
            txtEdadMascota.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdadMascota.Location = new Point(483, 299);
            txtEdadMascota.Margin = new Padding(3, 4, 3, 4);
            txtEdadMascota.Name = "txtEdadMascota";
            txtEdadMascota.Size = new Size(185, 27);
            txtEdadMascota.TabIndex = 3;
            // 
            // txtPesoMascota
            // 
            txtPesoMascota.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesoMascota.Location = new Point(483, 350);
            txtPesoMascota.Margin = new Padding(3, 4, 3, 4);
            txtPesoMascota.Name = "txtPesoMascota";
            txtPesoMascota.Size = new Size(185, 27);
            txtPesoMascota.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 414);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 5;
            label3.Text = "MOTIVO DE CONSULTA:";
            // 
            // rchComentarioConsulta
            // 
            rchComentarioConsulta.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rchComentarioConsulta.Location = new Point(374, 414);
            rchComentarioConsulta.Margin = new Padding(3, 4, 3, 4);
            rchComentarioConsulta.Name = "rchComentarioConsulta";
            rchComentarioConsulta.Size = new Size(753, 299);
            rchComentarioConsulta.TabIndex = 6;
            rchComentarioConsulta.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 252);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 7;
            label4.Text = "NOMBRE:";
            // 
            // txtnombreMascota
            // 
            txtnombreMascota.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombreMascota.Location = new Point(483, 244);
            txtnombreMascota.Margin = new Padding(3, 4, 3, 4);
            txtnombreMascota.Name = "txtnombreMascota";
            txtnombreMascota.Size = new Size(185, 27);
            txtnombreMascota.TabIndex = 8;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(374, 761);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 82);
            button1.TabIndex = 9;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1233, 899);
            Controls.Add(button1);
            Controls.Add(txtnombreMascota);
            Controls.Add(label4);
            Controls.Add(rchComentarioConsulta);
            Controls.Add(label3);
            Controls.Add(txtPesoMascota);
            Controls.Add(txtEdadMascota);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Consulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtEdadMascota;
        private TextBox txtPesoMascota;
        private Label label3;
        private RichTextBox rchComentarioConsulta;
        private Label label4;
        private TextBox txtnombreMascota;
        private Button button1;
    }
}
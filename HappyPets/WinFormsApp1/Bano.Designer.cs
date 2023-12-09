namespace CapaPresentacion
{
    partial class Bano
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtEdad = new TextBox();
            richComentario = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radHembra = new RadioButton();
            radMacho = new RadioButton();
            groupBox2 = new GroupBox();
            radUñas = new RadioButton();
            radCorte = new RadioButton();
            radBaño = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 72);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(964, 278);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 136);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "RAZA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 222);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "EDAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(453, 299);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 5;
            label6.Text = "GENERO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 385);
            label7.Name = "label7";
            label7.Size = new Size(160, 20);
            label7.TabIndex = 6;
            label7.Text = "SERVICIO SOLICITADO:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.perro2;
            pictureBox1.Location = new Point(139, 70);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(597, 55);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(367, 28);
            txtNombre.TabIndex = 8;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRaza.Location = new Point(597, 128);
            txtRaza.Margin = new Padding(3, 4, 3, 4);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(367, 28);
            txtRaza.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(597, 205);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(367, 28);
            txtEdad.TabIndex = 10;
            // 
            // richComentario
            // 
            richComentario.Location = new Point(139, 461);
            richComentario.Margin = new Padding(3, 4, 3, 4);
            richComentario.Name = "richComentario";
            richComentario.Size = new Size(571, 168);
            richComentario.TabIndex = 16;
            richComentario.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 437);
            label2.Name = "label2";
            label2.Size = new Size(249, 20);
            label2.TabIndex = 17;
            label2.Text = "¿ALGUNA OBSERVACION ESPECIAL?";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(796, 481);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(168, 130);
            button1.TabIndex = 18;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radHembra);
            groupBox1.Controls.Add(radMacho);
            groupBox1.Location = new Point(597, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 59);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // radHembra
            // 
            radHembra.AutoSize = true;
            radHembra.Location = new Point(201, 23);
            radHembra.Name = "radHembra";
            radHembra.Size = new Size(90, 24);
            radHembra.TabIndex = 1;
            radHembra.TabStop = true;
            radHembra.Text = "HEMBRA";
            radHembra.UseVisualStyleBackColor = true;
            // 
            // radMacho
            // 
            radMacho.AutoSize = true;
            radMacho.Location = new Point(29, 22);
            radMacho.Name = "radMacho";
            radMacho.Size = new Size(84, 24);
            radMacho.TabIndex = 0;
            radMacho.TabStop = true;
            radMacho.Text = "MACHO";
            radMacho.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radUñas);
            groupBox2.Controls.Add(radCorte);
            groupBox2.Controls.Add(radBaño);
            groupBox2.Location = new Point(597, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 66);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // radUñas
            // 
            radUñas.AutoSize = true;
            radUñas.Location = new Point(223, 27);
            radUñas.Name = "radUñas";
            radUñas.Size = new Size(140, 24);
            radUñas.TabIndex = 2;
            radUñas.TabStop = true;
            radUñas.Text = "CORTE DE UÑAS";
            radUñas.UseVisualStyleBackColor = true;
            // 
            // radCorte
            // 
            radCorte.AutoSize = true;
            radCorte.Location = new Point(98, 30);
            radCorte.Name = "radCorte";
            radCorte.Size = new Size(111, 24);
            radCorte.TabIndex = 1;
            radCorte.TabStop = true;
            radCorte.Text = "CORTE PELO";
            radCorte.UseVisualStyleBackColor = true;
            // 
            // radBaño
            // 
            radBaño.AutoSize = true;
            radBaño.Location = new Point(19, 30);
            radBaño.Name = "radBaño";
            radBaño.Size = new Size(71, 24);
            radBaño.TabIndex = 0;
            radBaño.TabStop = true;
            radBaño.Text = "BAÑO";
            radBaño.UseVisualStyleBackColor = true;
            // 
            // Bano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1118, 746);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(richComentario);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bano";
            Text = "Bano";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RichTextBox richComentario;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radHembra;
        private RadioButton radMacho;
        private GroupBox groupBox2;
        private RadioButton radBaño;
        private RadioButton radCorte;
        private RadioButton radUñas;
    }
}
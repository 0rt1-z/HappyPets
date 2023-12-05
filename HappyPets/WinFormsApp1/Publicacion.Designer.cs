namespace CapaPresentacion
{
    partial class Publicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publicacion));
            picLogo = new PictureBox();
            lblPLabel = new Label();
            rtbTextoPublicacion = new RichTextBox();
            btnPublicar = new Button();
            btnAgregarImagen = new Button();
            picPublicacionImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPublicacionImage).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.perro2;
            picLogo.Location = new Point(118, 199);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(308, 378);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // lblPLabel
            // 
            lblPLabel.AutoSize = true;
            lblPLabel.Location = new Point(499, 199);
            lblPLabel.Name = "lblPLabel";
            lblPLabel.Size = new Size(179, 20);
            lblPLabel.TabIndex = 9;
            lblPLabel.Text = "¿QUE ESTAS PENSANDO?";
            lblPLabel.Click += label1_Click;
            // 
            // rtbTextoPublicacion
            // 
            rtbTextoPublicacion.Location = new Point(499, 234);
            rtbTextoPublicacion.MaxLength = 280;
            rtbTextoPublicacion.Name = "rtbTextoPublicacion";
            rtbTextoPublicacion.Size = new Size(491, 185);
            rtbTextoPublicacion.TabIndex = 14;
            rtbTextoPublicacion.Text = "";
            // 
            // btnPublicar
            // 
            btnPublicar.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublicar.Location = new Point(290, 629);
            btnPublicar.Margin = new Padding(3, 4, 3, 4);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(388, 59);
            btnPublicar.TabIndex = 19;
            btnPublicar.Text = "PUBLICAR";
            btnPublicar.UseVisualStyleBackColor = true;
            btnPublicar.Click += button1_Click;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.ForeColor = SystemColors.ControlText;
            btnAgregarImagen.Image = (Image)resources.GetObject("btnAgregarImagen.Image");
            btnAgregarImagen.ImageAlign = ContentAlignment.TopLeft;
            btnAgregarImagen.Location = new Point(499, 437);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(272, 140);
            btnAgregarImagen.TabIndex = 20;
            btnAgregarImagen.Text = "AGREGAR IMAGEN";
            btnAgregarImagen.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += button2_Click;
            // 
            // picPublicacionImage
            // 
            picPublicacionImage.Location = new Point(801, 437);
            picPublicacionImage.Name = "picPublicacionImage";
            picPublicacionImage.Size = new Size(189, 140);
            picPublicacionImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picPublicacionImage.TabIndex = 21;
            picPublicacionImage.TabStop = false;
            // 
            // Publicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1021, 825);
            Controls.Add(picPublicacionImage);
            Controls.Add(btnAgregarImagen);
            Controls.Add(btnPublicar);
            Controls.Add(rtbTextoPublicacion);
            Controls.Add(lblPLabel);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Publicacion";
            Text = "Publicacion";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPublicacionImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblPLabel;
        private RichTextBox rtbTextoPublicacion;
        private Button btnPublicar;
        private Button btnAgregarImagen;
        private PictureBox picPublicacionImage;
    }
}
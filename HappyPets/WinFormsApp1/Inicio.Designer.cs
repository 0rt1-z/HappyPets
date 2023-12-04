namespace CapaPresentacion
{
    partial class Inicio
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
            panelEscritorio = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            rEGISTROToolStripMenuItem = new ToolStripMenuItem();
            mASCOTASToolStripMenuItem = new ToolStripMenuItem();
            sERVICIOSToolStripMenuItem = new ToolStripMenuItem();
            cONSULTASToolStripMenuItem = new ToolStripMenuItem();
            vACUNACIONToolStripMenuItem = new ToolStripMenuItem();
            bAÑOSToolStripMenuItem = new ToolStripMenuItem();
            aGENDAToolStripMenuItem = new ToolStripMenuItem();
            nUEVACITAToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnCerrarApp = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelEscritorio
            // 
            panelEscritorio.BorderStyle = BorderStyle.Fixed3D;
            panelEscritorio.Location = new Point(12, 95);
            panelEscritorio.Margin = new Padding(3, 4, 3, 4);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1233, 898);
            panelEscritorio.TabIndex = 1;
            panelEscritorio.Paint += panelEscritorio_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, rEGISTROToolStripMenuItem, sERVICIOSToolStripMenuItem, aGENDAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1259, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 24);
            toolStripMenuItem1.Text = "INICIO";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // rEGISTROToolStripMenuItem
            // 
            rEGISTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mASCOTASToolStripMenuItem });
            rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            rEGISTROToolStripMenuItem.Size = new Size(90, 24);
            rEGISTROToolStripMenuItem.Text = "REGISTRO";
            // 
            // mASCOTASToolStripMenuItem
            // 
            mASCOTASToolStripMenuItem.Name = "mASCOTASToolStripMenuItem";
            mASCOTASToolStripMenuItem.Size = new Size(167, 26);
            mASCOTASToolStripMenuItem.Text = "MASCOTAS";
            mASCOTASToolStripMenuItem.Click += mASCOTASToolStripMenuItem_Click;
            // 
            // sERVICIOSToolStripMenuItem
            // 
            sERVICIOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cONSULTASToolStripMenuItem, vACUNACIONToolStripMenuItem, bAÑOSToolStripMenuItem });
            sERVICIOSToolStripMenuItem.Name = "sERVICIOSToolStripMenuItem";
            sERVICIOSToolStripMenuItem.Size = new Size(93, 24);
            sERVICIOSToolStripMenuItem.Text = "SERVICIOS";
            // 
            // cONSULTASToolStripMenuItem
            // 
            cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            cONSULTASToolStripMenuItem.Size = new Size(185, 26);
            cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            cONSULTASToolStripMenuItem.Click += cONSULTASToolStripMenuItem_Click;
            // 
            // vACUNACIONToolStripMenuItem
            // 
            vACUNACIONToolStripMenuItem.Name = "vACUNACIONToolStripMenuItem";
            vACUNACIONToolStripMenuItem.Size = new Size(185, 26);
            vACUNACIONToolStripMenuItem.Text = "VACUNACION";
            vACUNACIONToolStripMenuItem.Click += vACUNACIONToolStripMenuItem_Click;
            // 
            // bAÑOSToolStripMenuItem
            // 
            bAÑOSToolStripMenuItem.Name = "bAÑOSToolStripMenuItem";
            bAÑOSToolStripMenuItem.Size = new Size(185, 26);
            bAÑOSToolStripMenuItem.Text = "BAÑOS";
            bAÑOSToolStripMenuItem.Click += bAÑOSToolStripMenuItem_Click;
            // 
            // aGENDAToolStripMenuItem
            // 
            aGENDAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nUEVACITAToolStripMenuItem });
            aGENDAToolStripMenuItem.Name = "aGENDAToolStripMenuItem";
            aGENDAToolStripMenuItem.Size = new Size(83, 24);
            aGENDAToolStripMenuItem.Text = "AGENDA";
            // 
            // nUEVACITAToolStripMenuItem
            // 
            nUEVACITAToolStripMenuItem.Name = "nUEVACITAToolStripMenuItem";
            nUEVACITAToolStripMenuItem.Size = new Size(173, 26);
            nUEVACITAToolStripMenuItem.Text = "NUEVA CITA";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCerrarApp);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(-2, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 68);
            panel1.TabIndex = 0;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.Location = new Point(1162, 31);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(94, 29);
            btnCerrarApp.TabIndex = 1;
            btnCerrarApp.Text = "Salir";
            btnCerrarApp.UseVisualStyleBackColor = true;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 155, 247);
            ClientSize = new Size(1257, 1009);
            Controls.Add(panel1);
            Controls.Add(panelEscritorio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASCOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVICIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vACUNACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAÑOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVACITAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Button btnCerrarApp;
    }
}
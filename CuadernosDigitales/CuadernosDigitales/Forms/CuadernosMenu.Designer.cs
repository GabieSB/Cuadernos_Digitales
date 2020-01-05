namespace CuadernosDigitales
{
    partial class CuadernosInicio
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
            this.listaOpcionePanel = new System.Windows.Forms.Panel();
            this.etiquetaCambiarU = new System.Windows.Forms.Panel();
            this.etiquetaHistorial = new System.Windows.Forms.Panel();
            this.etiquetaInicio = new System.Windows.Forms.Panel();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.historialButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comprimirButton = new System.Windows.Forms.Button();
            this.inicioButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.nombreProgramaLabel = new System.Windows.Forms.Label();
            this.cabezaPanel = new System.Windows.Forms.Panel();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.cuerpoPanel = new System.Windows.Forms.Panel();
            this.listaOpcionePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.cabezaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaOpcionePanel
            // 
            this.listaOpcionePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listaOpcionePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaOpcionePanel.Controls.Add(this.etiquetaCambiarU);
            this.listaOpcionePanel.Controls.Add(this.etiquetaHistorial);
            this.listaOpcionePanel.Controls.Add(this.etiquetaInicio);
            this.listaOpcionePanel.Controls.Add(this.cerrarButton);
            this.listaOpcionePanel.Controls.Add(this.historialButton);
            this.listaOpcionePanel.Controls.Add(this.panel1);
            this.listaOpcionePanel.Controls.Add(this.inicioButton);
            this.listaOpcionePanel.Controls.Add(this.logoPanel);
            this.listaOpcionePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaOpcionePanel.Location = new System.Drawing.Point(0, 0);
            this.listaOpcionePanel.Name = "listaOpcionePanel";
            this.listaOpcionePanel.Size = new System.Drawing.Size(52, 590);
            this.listaOpcionePanel.TabIndex = 0;
            this.listaOpcionePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListaOpcionePanel_Paint);
            // 
            // etiquetaCambiarU
            // 
            this.etiquetaCambiarU.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.etiquetaCambiarU.Location = new System.Drawing.Point(3, 351);
            this.etiquetaCambiarU.Name = "etiquetaCambiarU";
            this.etiquetaCambiarU.Size = new System.Drawing.Size(10, 64);
            this.etiquetaCambiarU.TabIndex = 2;
            // 
            // etiquetaHistorial
            // 
            this.etiquetaHistorial.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.etiquetaHistorial.Location = new System.Drawing.Point(3, 282);
            this.etiquetaHistorial.Name = "etiquetaHistorial";
            this.etiquetaHistorial.Size = new System.Drawing.Size(10, 47);
            this.etiquetaHistorial.TabIndex = 1;
            // 
            // etiquetaInicio
            // 
            this.etiquetaInicio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.etiquetaInicio.Location = new System.Drawing.Point(3, 215);
            this.etiquetaInicio.Name = "etiquetaInicio";
            this.etiquetaInicio.Size = new System.Drawing.Size(10, 47);
            this.etiquetaInicio.TabIndex = 0;
            // 
            // cerrarButton
            // 
            this.cerrarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.cerrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cerrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarButton.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cerrarButton.Location = new System.Drawing.Point(16, 352);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(163, 63);
            this.cerrarButton.TabIndex = 5;
            this.cerrarButton.Text = "CAMBIAR DE USUARIO";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // historialButton
            // 
            this.historialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.historialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.historialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historialButton.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialButton.ForeColor = System.Drawing.SystemColors.Control;
            this.historialButton.Location = new System.Drawing.Point(16, 282);
            this.historialButton.Name = "historialButton";
            this.historialButton.Size = new System.Drawing.Size(163, 48);
            this.historialButton.TabIndex = 4;
            this.historialButton.Text = "HISTORIAL";
            this.historialButton.UseVisualStyleBackColor = true;
            this.historialButton.Click += new System.EventHandler(this.HistorialButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.comprimirButton);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 154);
            this.panel1.TabIndex = 3;
            // 
            // comprimirButton
            // 
            this.comprimirButton.Location = new System.Drawing.Point(12, 6);
            this.comprimirButton.Name = "comprimirButton";
            this.comprimirButton.Size = new System.Drawing.Size(32, 23);
            this.comprimirButton.TabIndex = 1;
            this.comprimirButton.Text = "-";
            this.comprimirButton.UseVisualStyleBackColor = true;
            this.comprimirButton.Click += new System.EventHandler(this.ComprimirButton_Click);
            // 
            // inicioButton
            // 
            this.inicioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.inicioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.inicioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioButton.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.inicioButton.Location = new System.Drawing.Point(16, 215);
            this.inicioButton.Name = "inicioButton";
            this.inicioButton.Size = new System.Drawing.Size(163, 48);
            this.inicioButton.TabIndex = 2;
            this.inicioButton.Text = "INICIO";
            this.inicioButton.UseVisualStyleBackColor = true;
            this.inicioButton.Click += new System.EventHandler(this.InicioButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logoPanel.Controls.Add(this.nombreProgramaLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(50, 46);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CabezaPanel_MouseDown);
            // 
            // nombreProgramaLabel
            // 
            this.nombreProgramaLabel.AutoSize = true;
            this.nombreProgramaLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProgramaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreProgramaLabel.Location = new System.Drawing.Point(8, 13);
            this.nombreProgramaLabel.Name = "nombreProgramaLabel";
            this.nombreProgramaLabel.Size = new System.Drawing.Size(171, 19);
            this.nombreProgramaLabel.TabIndex = 0;
            this.nombreProgramaLabel.Text = "CD  Cuadernos Digitales";
            // 
            // cabezaPanel
            // 
            this.cabezaPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.cabezaPanel.Controls.Add(this.tituloLabel);
            this.cabezaPanel.Controls.Add(this.closeAppButton);
            this.cabezaPanel.Location = new System.Drawing.Point(52, 1);
            this.cabezaPanel.Name = "cabezaPanel";
            this.cabezaPanel.Size = new System.Drawing.Size(799, 46);
            this.cabezaPanel.TabIndex = 1;
            this.cabezaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CabezaPanel_Paint);
            this.cabezaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CabezaPanel_MouseDown);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Dream Orphans", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.White;
            this.tituloLabel.Location = new System.Drawing.Point(19, 6);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(82, 34);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "INICIO";
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(755, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 0;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // cuerpoPanel
            // 
            this.cuerpoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.cuerpoPanel.Font = new System.Drawing.Font("NewsGoth BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuerpoPanel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cuerpoPanel.Location = new System.Drawing.Point(52, 47);
            this.cuerpoPanel.Name = "cuerpoPanel";
            this.cuerpoPanel.Size = new System.Drawing.Size(800, 545);
            this.cuerpoPanel.TabIndex = 2;
            // 
            // CuadernosInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 590);
            this.Controls.Add(this.cabezaPanel);
            this.Controls.Add(this.listaOpcionePanel);
            this.Controls.Add(this.cuerpoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "CuadernosInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadernos Digitales";
            this.Load += new System.EventHandler(this.CuadernosInicio_Load);
            this.listaOpcionePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.cabezaPanel.ResumeLayout(false);
            this.cabezaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listaOpcionePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel cabezaPanel;
        private System.Windows.Forms.Panel cuerpoPanel;
        private System.Windows.Forms.Label nombreProgramaLabel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Button comprimirButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button historialButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inicioButton;
        private System.Windows.Forms.Panel etiquetaCambiarU;
        private System.Windows.Forms.Panel etiquetaHistorial;
        private System.Windows.Forms.Panel etiquetaInicio;
        private System.Windows.Forms.Label tituloLabel;
    }
}


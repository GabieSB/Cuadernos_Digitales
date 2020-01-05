namespace CuadernosDigitales.Forms
{
    partial class NuevaNota
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
            this.components = new System.ComponentModel.Container();
            this.guardarNotaButton = new System.Windows.Forms.Button();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.propiedadesPanel = new System.Windows.Forms.Panel();
            this.controlsPropiedadesPanel = new System.Windows.Forms.Panel();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.cambiarFuenteButton = new System.Windows.Forms.Button();
            this.ocultarCheckBox = new System.Windows.Forms.CheckBox();
            this.coloresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LightGreenButton = new System.Windows.Forms.Button();
            this.LightCoralButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.CornflowerBlueButton = new System.Windows.Forms.Button();
            this.deepSkyBlueButton = new System.Windows.Forms.Button();
            this.deepPinkButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.KhakiButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.grayButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.colorNotaLabel = new System.Windows.Forms.Label();
            this.colorSeleccionadoPanel = new System.Windows.Forms.Panel();
            this.propiedadesButton = new System.Windows.Forms.Button();
            this.tituloNotaTextBox = new System.Windows.Forms.TextBox();
            this.notaYpropiedadesPanel = new System.Windows.Forms.Panel();
            this.notaPanel = new System.Windows.Forms.Panel();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.propiedadesPanel.SuspendLayout();
            this.controlsPropiedadesPanel.SuspendLayout();
            this.coloresPanel.SuspendLayout();
            this.notaYpropiedadesPanel.SuspendLayout();
            this.notaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // guardarNotaButton
            // 
            this.guardarNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardarNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guardarNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.guardarNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.guardarNotaButton.Location = new System.Drawing.Point(430, 457);
            this.guardarNotaButton.Name = "guardarNotaButton";
            this.guardarNotaButton.Size = new System.Drawing.Size(133, 34);
            this.guardarNotaButton.TabIndex = 12;
            this.guardarNotaButton.Text = "GUARDAR";
            this.guardarNotaButton.UseVisualStyleBackColor = false;
            this.guardarNotaButton.Click += new System.EventHandler(this.GuardarNotaButton_Click);
            // 
            // notaTextBox
            // 
            this.notaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaTextBox.Location = new System.Drawing.Point(12, 67);
            this.notaTextBox.MaxLength = 1000000;
            this.notaTextBox.Multiline = true;
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(552, 384);
            this.notaTextBox.TabIndex = 17;
            this.notaTextBox.Text = "NOTA";
            // 
            // propiedadesPanel
            // 
            this.propiedadesPanel.BackColor = System.Drawing.Color.Gray;
            this.propiedadesPanel.Controls.Add(this.controlsPropiedadesPanel);
            this.propiedadesPanel.Controls.Add(this.propiedadesButton);
            this.propiedadesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.propiedadesPanel.Location = new System.Drawing.Point(0, 0);
            this.propiedadesPanel.Name = "propiedadesPanel";
            this.propiedadesPanel.Size = new System.Drawing.Size(220, 543);
            this.propiedadesPanel.TabIndex = 18;
            // 
            // controlsPropiedadesPanel
            // 
            this.controlsPropiedadesPanel.Controls.Add(this.categoriaLabel);
            this.controlsPropiedadesPanel.Controls.Add(this.categoriaTextBox);
            this.controlsPropiedadesPanel.Controls.Add(this.cambiarFuenteButton);
            this.controlsPropiedadesPanel.Controls.Add(this.ocultarCheckBox);
            this.controlsPropiedadesPanel.Controls.Add(this.coloresPanel);
            this.controlsPropiedadesPanel.Controls.Add(this.colorNotaLabel);
            this.controlsPropiedadesPanel.Controls.Add(this.colorSeleccionadoPanel);
            this.controlsPropiedadesPanel.Location = new System.Drawing.Point(6, 50);
            this.controlsPropiedadesPanel.Name = "controlsPropiedadesPanel";
            this.controlsPropiedadesPanel.Size = new System.Drawing.Size(208, 368);
            this.controlsPropiedadesPanel.TabIndex = 20;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.Location = new System.Drawing.Point(52, 234);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(99, 19);
            this.categoriaLabel.TabIndex = 20;
            this.categoriaLabel.Text = "CATEGORIA:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTextBox.Location = new System.Drawing.Point(2, 256);
            this.categoriaTextBox.MaxLength = 50;
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(203, 27);
            this.categoriaTextBox.TabIndex = 19;
            // 
            // cambiarFuenteButton
            // 
            this.cambiarFuenteButton.Location = new System.Drawing.Point(33, 17);
            this.cambiarFuenteButton.Name = "cambiarFuenteButton";
            this.cambiarFuenteButton.Size = new System.Drawing.Size(141, 36);
            this.cambiarFuenteButton.TabIndex = 18;
            this.cambiarFuenteButton.Text = "CAMBIAR FUENTE";
            this.cambiarFuenteButton.UseVisualStyleBackColor = true;
            this.cambiarFuenteButton.Click += new System.EventHandler(this.CambiarFuenteButton_Click);
            // 
            // ocultarCheckBox
            // 
            this.ocultarCheckBox.AutoSize = true;
            this.ocultarCheckBox.Font = new System.Drawing.Font("NewsGoth BT", 12F);
            this.ocultarCheckBox.Location = new System.Drawing.Point(54, 298);
            this.ocultarCheckBox.Name = "ocultarCheckBox";
            this.ocultarCheckBox.Size = new System.Drawing.Size(97, 23);
            this.ocultarCheckBox.TabIndex = 18;
            this.ocultarCheckBox.Text = "OCULTAR";
            this.ocultarCheckBox.UseVisualStyleBackColor = true;
            // 
            // coloresPanel
            // 
            this.coloresPanel.BackColor = System.Drawing.Color.White;
            this.coloresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coloresPanel.Controls.Add(this.LightGreenButton);
            this.coloresPanel.Controls.Add(this.LightCoralButton);
            this.coloresPanel.Controls.Add(this.TanButton);
            this.coloresPanel.Controls.Add(this.yellowButton);
            this.coloresPanel.Controls.Add(this.CornflowerBlueButton);
            this.coloresPanel.Controls.Add(this.deepSkyBlueButton);
            this.coloresPanel.Controls.Add(this.deepPinkButton);
            this.coloresPanel.Controls.Add(this.pinkButton);
            this.coloresPanel.Controls.Add(this.KhakiButton);
            this.coloresPanel.Controls.Add(this.whiteButton);
            this.coloresPanel.Controls.Add(this.grayButton);
            this.coloresPanel.Controls.Add(this.blackButton);
            this.coloresPanel.Location = new System.Drawing.Point(27, 101);
            this.coloresPanel.Name = "coloresPanel";
            this.coloresPanel.Size = new System.Drawing.Size(148, 111);
            this.coloresPanel.TabIndex = 10;
            // 
            // LightGreenButton
            // 
            this.LightGreenButton.BackColor = System.Drawing.Color.LightGreen;
            this.LightGreenButton.Location = new System.Drawing.Point(3, 3);
            this.LightGreenButton.Name = "LightGreenButton";
            this.LightGreenButton.Size = new System.Drawing.Size(30, 30);
            this.LightGreenButton.TabIndex = 0;
            this.LightGreenButton.UseVisualStyleBackColor = false;
            this.LightGreenButton.Click += new System.EventHandler(this.LightGreen_Click);
            // 
            // LightCoralButton
            // 
            this.LightCoralButton.BackColor = System.Drawing.Color.LightCoral;
            this.LightCoralButton.ForeColor = System.Drawing.Color.Red;
            this.LightCoralButton.Location = new System.Drawing.Point(39, 3);
            this.LightCoralButton.Name = "LightCoralButton";
            this.LightCoralButton.Size = new System.Drawing.Size(30, 30);
            this.LightCoralButton.TabIndex = 1;
            this.LightCoralButton.UseVisualStyleBackColor = false;
            this.LightCoralButton.Click += new System.EventHandler(this.LightCoralButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.Color.Tan;
            this.TanButton.Location = new System.Drawing.Point(75, 3);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(30, 30);
            this.TanButton.TabIndex = 2;
            this.TanButton.UseVisualStyleBackColor = false;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(111, 3);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(30, 30);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // CornflowerBlueButton
            // 
            this.CornflowerBlueButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CornflowerBlueButton.Location = new System.Drawing.Point(3, 39);
            this.CornflowerBlueButton.Name = "CornflowerBlueButton";
            this.CornflowerBlueButton.Size = new System.Drawing.Size(30, 30);
            this.CornflowerBlueButton.TabIndex = 4;
            this.CornflowerBlueButton.UseVisualStyleBackColor = false;
            this.CornflowerBlueButton.Click += new System.EventHandler(this.CornflowerBlueButton_Click);
            // 
            // deepSkyBlueButton
            // 
            this.deepSkyBlueButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deepSkyBlueButton.Location = new System.Drawing.Point(39, 39);
            this.deepSkyBlueButton.Name = "deepSkyBlueButton";
            this.deepSkyBlueButton.Size = new System.Drawing.Size(30, 30);
            this.deepSkyBlueButton.TabIndex = 7;
            this.deepSkyBlueButton.UseVisualStyleBackColor = false;
            this.deepSkyBlueButton.Click += new System.EventHandler(this.DeepSkyBlueButton_Click);
            // 
            // deepPinkButton
            // 
            this.deepPinkButton.BackColor = System.Drawing.Color.Orchid;
            this.deepPinkButton.Location = new System.Drawing.Point(75, 39);
            this.deepPinkButton.Name = "deepPinkButton";
            this.deepPinkButton.Size = new System.Drawing.Size(30, 30);
            this.deepPinkButton.TabIndex = 10;
            this.deepPinkButton.UseVisualStyleBackColor = false;
            this.deepPinkButton.Click += new System.EventHandler(this.OrchidButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Pink;
            this.pinkButton.Location = new System.Drawing.Point(111, 39);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(30, 30);
            this.pinkButton.TabIndex = 6;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // KhakiButton
            // 
            this.KhakiButton.BackColor = System.Drawing.Color.Khaki;
            this.KhakiButton.Location = new System.Drawing.Point(3, 75);
            this.KhakiButton.Name = "KhakiButton";
            this.KhakiButton.Size = new System.Drawing.Size(30, 30);
            this.KhakiButton.TabIndex = 5;
            this.KhakiButton.UseVisualStyleBackColor = false;
            this.KhakiButton.Click += new System.EventHandler(this.KhakiButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(39, 75);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(30, 30);
            this.whiteButton.TabIndex = 8;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // grayButton
            // 
            this.grayButton.BackColor = System.Drawing.Color.Gray;
            this.grayButton.Location = new System.Drawing.Point(75, 75);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(30, 30);
            this.grayButton.TabIndex = 9;
            this.grayButton.UseVisualStyleBackColor = false;
            this.grayButton.Click += new System.EventHandler(this.GrayButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(111, 75);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(30, 30);
            this.blackButton.TabIndex = 11;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // colorNotaLabel
            // 
            this.colorNotaLabel.AutoSize = true;
            this.colorNotaLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorNotaLabel.Location = new System.Drawing.Point(52, 70);
            this.colorNotaLabel.Name = "colorNotaLabel";
            this.colorNotaLabel.Size = new System.Drawing.Size(64, 19);
            this.colorNotaLabel.TabIndex = 3;
            this.colorNotaLabel.Text = "COLOR:";
            // 
            // colorSeleccionadoPanel
            // 
            this.colorSeleccionadoPanel.BackColor = System.Drawing.Color.White;
            this.colorSeleccionadoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSeleccionadoPanel.Location = new System.Drawing.Point(118, 67);
            this.colorSeleccionadoPanel.Name = "colorSeleccionadoPanel";
            this.colorSeleccionadoPanel.Size = new System.Drawing.Size(26, 24);
            this.colorSeleccionadoPanel.TabIndex = 16;
            // 
            // propiedadesButton
            // 
            this.propiedadesButton.Location = new System.Drawing.Point(6, 5);
            this.propiedadesButton.Name = "propiedadesButton";
            this.propiedadesButton.Size = new System.Drawing.Size(38, 23);
            this.propiedadesButton.TabIndex = 19;
            this.propiedadesButton.Text = "+";
            this.propiedadesButton.UseVisualStyleBackColor = true;
            this.propiedadesButton.Click += new System.EventHandler(this.PropiedadesButton_Click);
            // 
            // tituloNotaTextBox
            // 
            this.tituloNotaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloNotaTextBox.Location = new System.Drawing.Point(12, 20);
            this.tituloNotaTextBox.MaxLength = 1000;
            this.tituloNotaTextBox.Name = "tituloNotaTextBox";
            this.tituloNotaTextBox.Size = new System.Drawing.Size(552, 27);
            this.tituloNotaTextBox.TabIndex = 0;
            this.tituloNotaTextBox.Text = "TÍTULO";
            this.tituloNotaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TituloNotaTextBox_KeyPress);
            // 
            // notaYpropiedadesPanel
            // 
            this.notaYpropiedadesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.notaYpropiedadesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notaYpropiedadesPanel.Controls.Add(this.notaPanel);
            this.notaYpropiedadesPanel.Controls.Add(this.propiedadesPanel);
            this.notaYpropiedadesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notaYpropiedadesPanel.ForeColor = System.Drawing.Color.Black;
            this.notaYpropiedadesPanel.Location = new System.Drawing.Point(0, 0);
            this.notaYpropiedadesPanel.Name = "notaYpropiedadesPanel";
            this.notaYpropiedadesPanel.Size = new System.Drawing.Size(800, 545);
            this.notaYpropiedadesPanel.TabIndex = 10;
            // 
            // notaPanel
            // 
            this.notaPanel.BackColor = System.Drawing.Color.Silver;
            this.notaPanel.Controls.Add(this.tituloNotaTextBox);
            this.notaPanel.Controls.Add(this.notaTextBox);
            this.notaPanel.Controls.Add(this.guardarNotaButton);
            this.notaPanel.Location = new System.Drawing.Point(220, 0);
            this.notaPanel.Name = "notaPanel";
            this.notaPanel.Size = new System.Drawing.Size(578, 543);
            this.notaPanel.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NuevaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.notaYpropiedadesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaNota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaNota_FormClosed);
            this.propiedadesPanel.ResumeLayout(false);
            this.controlsPropiedadesPanel.ResumeLayout(false);
            this.controlsPropiedadesPanel.PerformLayout();
            this.coloresPanel.ResumeLayout(false);
            this.notaYpropiedadesPanel.ResumeLayout(false);
            this.notaPanel.ResumeLayout(false);
            this.notaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button guardarNotaButton;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.Panel propiedadesPanel;
        private System.Windows.Forms.Panel controlsPropiedadesPanel;
        private System.Windows.Forms.CheckBox ocultarCheckBox;
        private System.Windows.Forms.FlowLayoutPanel coloresPanel;
        private System.Windows.Forms.Button LightGreenButton;
        private System.Windows.Forms.Button LightCoralButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button CornflowerBlueButton;
        private System.Windows.Forms.Button deepSkyBlueButton;
        private System.Windows.Forms.Button deepPinkButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button KhakiButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Label colorNotaLabel;
        private System.Windows.Forms.Panel colorSeleccionadoPanel;
        private System.Windows.Forms.Button propiedadesButton;
        private System.Windows.Forms.Panel notaYpropiedadesPanel;
        private System.Windows.Forms.Panel notaPanel;
        private System.Windows.Forms.TextBox tituloNotaTextBox;
        private System.Windows.Forms.Button cambiarFuenteButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
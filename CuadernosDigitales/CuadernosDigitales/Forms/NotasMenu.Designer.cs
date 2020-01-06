namespace CuadernosDigitales.Forms
{
    partial class NotasMenu
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
            this.nuevaNotaButton = new System.Windows.Forms.Button();
            this.notasMenuPanel = new System.Windows.Forms.Panel();
            this.verOcultasButton = new System.Windows.Forms.Button();
            this.regresarButton = new System.Windows.Forms.Button();
            this.notasContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.verNotasButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.notasMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuevaNotaButton
            // 
            this.nuevaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevaNotaButton.Location = new System.Drawing.Point(28, 68);
            this.nuevaNotaButton.Name = "nuevaNotaButton";
            this.nuevaNotaButton.Size = new System.Drawing.Size(133, 34);
            this.nuevaNotaButton.TabIndex = 3;
            this.nuevaNotaButton.Text = "NUEVA NOTA";
            this.nuevaNotaButton.UseVisualStyleBackColor = false;
            this.nuevaNotaButton.Click += new System.EventHandler(this.NuevaNotaButton_Click);
            // 
            // notasMenuPanel
            // 
            this.notasMenuPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.notasMenuPanel.Controls.Add(this.cancelarButton);
            this.notasMenuPanel.Controls.Add(this.verOcultasButton);
            this.notasMenuPanel.Controls.Add(this.regresarButton);
            this.notasMenuPanel.Controls.Add(this.notasContainer);
            this.notasMenuPanel.Controls.Add(this.nombreCuadernoLabel);
            this.notasMenuPanel.Controls.Add(this.buscaNotaButton);
            this.notasMenuPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.notasMenuPanel.Controls.Add(this.nuevaNotaButton);
            this.notasMenuPanel.Controls.Add(this.verNotasButton);
            this.notasMenuPanel.Controls.Add(this.eliminarButton);
            this.notasMenuPanel.ForeColor = System.Drawing.Color.Black;
            this.notasMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.notasMenuPanel.Name = "notasMenuPanel";
            this.notasMenuPanel.Size = new System.Drawing.Size(800, 545);
            this.notasMenuPanel.TabIndex = 4;
            // 
            // verOcultasButton
            // 
            this.verOcultasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verOcultasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.verOcultasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.verOcultasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verOcultasButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verOcultasButton.ForeColor = System.Drawing.Color.LightGray;
            this.verOcultasButton.Location = new System.Drawing.Point(184, 68);
            this.verOcultasButton.Name = "verOcultasButton";
            this.verOcultasButton.Size = new System.Drawing.Size(133, 34);
            this.verOcultasButton.TabIndex = 14;
            this.verOcultasButton.Text = "VER OCULTAS";
            this.verOcultasButton.UseVisualStyleBackColor = false;
            this.verOcultasButton.Click += new System.EventHandler(this.VerOcultasButton_Click);
            // 
            // regresarButton
            // 
            this.regresarButton.Image = global::CuadernosDigitales.Properties.Resources.back;
            this.regresarButton.Location = new System.Drawing.Point(28, 20);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(70, 28);
            this.regresarButton.TabIndex = 12;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // notasContainer
            // 
            this.notasContainer.AutoScroll = true;
            this.notasContainer.Location = new System.Drawing.Point(12, 137);
            this.notasContainer.Name = "notasContainer";
            this.notasContainer.Size = new System.Drawing.Size(776, 396);
            this.notasContainer.TabIndex = 11;
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(245, 19);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(332, 29);
            this.nombreCuadernoLabel.TabIndex = 8;
            this.nombreCuadernoLabel.Text = "NOMBRE DEL CUADERNO";
            this.nombreCuadernoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(681, 68);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 34);
            this.buscaNotaButton.TabIndex = 7;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            this.buscaNotaButton.Click += new System.EventHandler(this.BuscaNotaButton_Click);
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(433, 73);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(229, 27);
            this.buscarCuadernoTextBox.TabIndex = 6;
            // 
            // verNotasButton
            // 
            this.verNotasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verNotasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.verNotasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.verNotasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verNotasButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verNotasButton.ForeColor = System.Drawing.Color.LightGray;
            this.verNotasButton.Location = new System.Drawing.Point(28, 67);
            this.verNotasButton.Name = "verNotasButton";
            this.verNotasButton.Size = new System.Drawing.Size(172, 33);
            this.verNotasButton.TabIndex = 13;
            this.verNotasButton.Text = "VER TODAS LAS NOTAS";
            this.verNotasButton.UseVisualStyleBackColor = false;
            this.verNotasButton.Visible = false;
            this.verNotasButton.Click += new System.EventHandler(this.VerNotasButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarButton.Location = new System.Drawing.Point(28, 68);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(84, 34);
            this.eliminarButton.TabIndex = 15;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Visible = false;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.Color.LightGray;
            this.cancelarButton.Location = new System.Drawing.Point(152, 68);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(84, 34);
            this.cancelarButton.TabIndex = 16;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Visible = false;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // NotasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.notasMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadernoAbierto";
            this.notasMenuPanel.ResumeLayout(false);
            this.notasMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nuevaNotaButton;
        private System.Windows.Forms.Panel notasMenuPanel;
        private System.Windows.Forms.Button buscaNotaButton;
        private System.Windows.Forms.TextBox buscarCuadernoTextBox;
        private System.Windows.Forms.Label nombreCuadernoLabel;
        private System.Windows.Forms.FlowLayoutPanel notasContainer;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Button verNotasButton;
        private System.Windows.Forms.Button verOcultasButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}
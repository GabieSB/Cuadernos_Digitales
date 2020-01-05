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
            this.regresarButton = new System.Windows.Forms.Button();
            this.notasContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
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
            this.nuevaNotaButton.Location = new System.Drawing.Point(41, 68);
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
            this.notasMenuPanel.Controls.Add(this.regresarButton);
            this.notasMenuPanel.Controls.Add(this.notasContainer);
            this.notasMenuPanel.Controls.Add(this.nombreCuadernoLabel);
            this.notasMenuPanel.Controls.Add(this.buscaNotaButton);
            this.notasMenuPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.notasMenuPanel.Controls.Add(this.nuevaNotaButton);
            this.notasMenuPanel.ForeColor = System.Drawing.Color.Black;
            this.notasMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.notasMenuPanel.Name = "notasMenuPanel";
            this.notasMenuPanel.Size = new System.Drawing.Size(800, 545);
            this.notasMenuPanel.TabIndex = 4;
            // 
            // regresarButton
            // 
            this.regresarButton.Image = global::CuadernosDigitales.Properties.Resources.back;
            this.regresarButton.Location = new System.Drawing.Point(41, 12);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(70, 28);
            this.regresarButton.TabIndex = 12;
            this.regresarButton.Text = "Regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // notasContainer
            // 
            this.notasContainer.Location = new System.Drawing.Point(12, 137);
            this.notasContainer.Name = "notasContainer";
            this.notasContainer.Size = new System.Drawing.Size(776, 373);
            this.notasContainer.TabIndex = 11;
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(286, 20);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(211, 20);
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
            this.buscaNotaButton.Location = new System.Drawing.Point(633, 68);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 34);
            this.buscaNotaButton.TabIndex = 7;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("Dream Orphans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(399, 73);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(229, 25);
            this.buscarCuadernoTextBox.TabIndex = 6;
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
    }
}
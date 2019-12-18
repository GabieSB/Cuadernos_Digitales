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
            this.categoriasGridView = new System.Windows.Forms.DataGridView();
            this.nuevaNotaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeNotasCuadernoButton = new System.Windows.Forms.Button();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriasGridView
            // 
            this.categoriasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriasGridView.Location = new System.Drawing.Point(520, 106);
            this.categoriasGridView.Name = "categoriasGridView";
            this.categoriasGridView.Size = new System.Drawing.Size(137, 151);
            this.categoriasGridView.TabIndex = 0;
            // 
            // nuevaNotaButton
            // 
            this.nuevaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevaNotaButton.Location = new System.Drawing.Point(12, 62);
            this.nuevaNotaButton.Name = "nuevaNotaButton";
            this.nuevaNotaButton.Size = new System.Drawing.Size(133, 34);
            this.nuevaNotaButton.TabIndex = 3;
            this.nuevaNotaButton.Text = "NUEVA NOTA";
            this.nuevaNotaButton.UseVisualStyleBackColor = false;
            this.nuevaNotaButton.Click += new System.EventHandler(this.NuevaNotaButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nombreCuadernoLabel);
            this.panel1.Controls.Add(this.closeNotasCuadernoButton);
            this.panel1.Controls.Add(this.buscaNotaButton);
            this.panel1.Controls.Add(this.buscarCuadernoTextBox);
            this.panel1.Controls.Add(this.nuevaNotaButton);
            this.panel1.Controls.Add(this.categoriasGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 465);
            this.panel1.TabIndex = 4;
            // 
            // closeNotasCuadernoButton
            // 
            this.closeNotasCuadernoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeNotasCuadernoButton.BackColor = System.Drawing.Color.Red;
            this.closeNotasCuadernoButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeNotasCuadernoButton.FlatAppearance.BorderSize = 2;
            this.closeNotasCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNotasCuadernoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeNotasCuadernoButton.Location = new System.Drawing.Point(660, 12);
            this.closeNotasCuadernoButton.Name = "closeNotasCuadernoButton";
            this.closeNotasCuadernoButton.Size = new System.Drawing.Size(32, 23);
            this.closeNotasCuadernoButton.TabIndex = 5;
            this.closeNotasCuadernoButton.Text = "X";
            this.closeNotasCuadernoButton.UseVisualStyleBackColor = false;
            this.closeNotasCuadernoButton.Click += new System.EventHandler(this.CloseNotasCuadernoButton_Click);
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(588, 46);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 34);
            this.buscaNotaButton.TabIndex = 7;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("Dream Orphans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(423, 51);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(147, 25);
            this.buscarCuadernoTextBox.TabIndex = 6;
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(243, 15);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(211, 20);
            this.nombreCuadernoLabel.TabIndex = 8;
            this.nombreCuadernoLabel.Text = "NOMBRE DEL CUADERNO";
            this.nombreCuadernoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 465);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadernoAbierto";
            ((System.ComponentModel.ISupportInitialize)(this.categoriasGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categoriasGridView;
        private System.Windows.Forms.Button nuevaNotaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buscaNotaButton;
        private System.Windows.Forms.TextBox buscarCuadernoTextBox;
        private System.Windows.Forms.Button closeNotasCuadernoButton;
        private System.Windows.Forms.Label nombreCuadernoLabel;
    }
}
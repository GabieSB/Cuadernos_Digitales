namespace CuadernosDigitales.Forms
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
            this.nuevoCuadernoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.inicioPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cuadernosContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.inicioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuevoCuadernoButton
            // 
            this.nuevoCuadernoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevoCuadernoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevoCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoCuadernoButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevoCuadernoButton.Location = new System.Drawing.Point(22, 13);
            this.nuevoCuadernoButton.Name = "nuevoCuadernoButton";
            this.nuevoCuadernoButton.Size = new System.Drawing.Size(133, 34);
            this.nuevoCuadernoButton.TabIndex = 0;
            this.nuevoCuadernoButton.Text = "NUEVO CUADERNO";
            this.nuevoCuadernoButton.UseVisualStyleBackColor = false;
            this.nuevoCuadernoButton.Click += new System.EventHandler(this.NuevoCuadernoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dream Orphans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(816, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buscarCuadernoTextBox
            // 
            this.buscarCuadernoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarCuadernoTextBox.Font = new System.Drawing.Font("Dream Orphans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCuadernoTextBox.Location = new System.Drawing.Point(965, 18);
            this.buscarCuadernoTextBox.Name = "buscarCuadernoTextBox";
            this.buscarCuadernoTextBox.Size = new System.Drawing.Size(202, 25);
            this.buscarCuadernoTextBox.TabIndex = 4;
            // 
            // inicioPanel
            // 
            this.inicioPanel.BackColor = System.Drawing.SystemColors.Control;
            this.inicioPanel.Controls.Add(this.cuadernosContainer);
            this.inicioPanel.Controls.Add(this.buscaNotaButton);
            this.inicioPanel.Controls.Add(this.textBox1);
            this.inicioPanel.Controls.Add(this.button2);
            this.inicioPanel.Controls.Add(this.nuevoCuadernoButton);
            this.inicioPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.inicioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioPanel.Location = new System.Drawing.Point(0, 0);
            this.inicioPanel.Name = "inicioPanel";
            this.inicioPanel.Size = new System.Drawing.Size(800, 545);
            this.inicioPanel.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(1173, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(684, 17);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 34);
            this.buscaNotaButton.TabIndex = 9;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Dream Orphans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(450, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 25);
            this.textBox1.TabIndex = 8;
            // 
            // cuadernosContainer
            // 
            this.cuadernosContainer.AutoScroll = true;
            this.cuadernosContainer.Location = new System.Drawing.Point(34, 85);
            this.cuadernosContainer.Margin = new System.Windows.Forms.Padding(15);
            this.cuadernosContainer.Name = "cuadernosContainer";
            this.cuadernosContainer.Size = new System.Drawing.Size(727, 445);
            this.cuadernosContainer.TabIndex = 10;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.inicioPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.InicioForm_Load);
            this.inicioPanel.ResumeLayout(false);
            this.inicioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoCuadernoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox buscarCuadernoTextBox;
        private System.Windows.Forms.Panel inicioPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buscaNotaButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel cuadernosContainer;
    }
}
namespace CuadernosDigitales.Forms
{
    partial class NuevoCuaderno
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
            this.nombreCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.nuevoCuadernoLabel = new System.Windows.Forms.Label();
            this.nombreCuadernoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.agregarCategoriaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreCuadernoTextBox
            // 
            this.nombreCuadernoTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoTextBox.Location = new System.Drawing.Point(171, 123);
            this.nombreCuadernoTextBox.Name = "nombreCuadernoTextBox";
            this.nombreCuadernoTextBox.Size = new System.Drawing.Size(244, 27);
            this.nombreCuadernoTextBox.TabIndex = 0;
            // 
            // nuevoCuadernoLabel
            // 
            this.nuevoCuadernoLabel.AutoSize = true;
            this.nuevoCuadernoLabel.Font = new System.Drawing.Font("Dream Orphans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoLabel.Location = new System.Drawing.Point(246, 35);
            this.nuevoCuadernoLabel.Name = "nuevoCuadernoLabel";
            this.nuevoCuadernoLabel.Size = new System.Drawing.Size(205, 32);
            this.nuevoCuadernoLabel.TabIndex = 1;
            this.nuevoCuadernoLabel.Text = "NUEVO CUADERNO";
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("NewsGoth BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(82, 125);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(83, 20);
            this.nombreCuadernoLabel.TabIndex = 2;
            this.nombreCuadernoLabel.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORIAS:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(171, 167);
            this.textBox1.MaxLength = 60;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 4;
            // 
            // agregarCategoriaButton
            // 
            this.agregarCategoriaButton.Location = new System.Drawing.Point(323, 167);
            this.agregarCategoriaButton.Name = "agregarCategoriaButton";
            this.agregarCategoriaButton.Size = new System.Drawing.Size(26, 27);
            this.agregarCategoriaButton.TabIndex = 5;
            this.agregarCategoriaButton.Text = "+";
            this.agregarCategoriaButton.UseVisualStyleBackColor = true;
            this.agregarCategoriaButton.Click += new System.EventHandler(this.AgregarCategoriaButton_Click);
            // 
            // NuevoCuaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 486);
            this.Controls.Add(this.agregarCategoriaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreCuadernoLabel);
            this.Controls.Add(this.nuevoCuadernoLabel);
            this.Controls.Add(this.nombreCuadernoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCuaderno";
            this.Text = "Nuevo Cuaderno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreCuadernoTextBox;
        private System.Windows.Forms.Label nuevoCuadernoLabel;
        private System.Windows.Forms.Label nombreCuadernoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button agregarCategoriaButton;
    }
}
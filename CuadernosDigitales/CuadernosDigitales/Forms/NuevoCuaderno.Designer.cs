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
            this.agregarCategoriaButton = new System.Windows.Forms.Button();
            this.categoriasPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.deepSkyBlueButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.grayButton = new System.Windows.Forms.Button();
            this.deepPinkButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.crearCuadernoButton = new System.Windows.Forms.Button();
            this.categoriasPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreCuadernoTextBox
            // 
            this.nombreCuadernoTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoTextBox.Location = new System.Drawing.Point(177, 122);
            this.nombreCuadernoTextBox.Name = "nombreCuadernoTextBox";
            this.nombreCuadernoTextBox.Size = new System.Drawing.Size(244, 27);
            this.nombreCuadernoTextBox.TabIndex = 0;
            // 
            // nuevoCuadernoLabel
            // 
            this.nuevoCuadernoLabel.AutoSize = true;
            this.nuevoCuadernoLabel.Font = new System.Drawing.Font("Dream Orphans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoLabel.Location = new System.Drawing.Point(232, 36);
            this.nuevoCuadernoLabel.Name = "nuevoCuadernoLabel";
            this.nuevoCuadernoLabel.Size = new System.Drawing.Size(205, 32);
            this.nuevoCuadernoLabel.TabIndex = 1;
            this.nuevoCuadernoLabel.Text = "NUEVO CUADERNO";
            // 
            // nombreCuadernoLabel
            // 
            this.nombreCuadernoLabel.AutoSize = true;
            this.nombreCuadernoLabel.Font = new System.Drawing.Font("NewsGoth BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuadernoLabel.Location = new System.Drawing.Point(40, 129);
            this.nombreCuadernoLabel.Name = "nombreCuadernoLabel";
            this.nombreCuadernoLabel.Size = new System.Drawing.Size(83, 20);
            this.nombreCuadernoLabel.TabIndex = 2;
            this.nombreCuadernoLabel.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORIAS:";
            // 
            // agregarCategoriaButton
            // 
            this.agregarCategoriaButton.BackColor = System.Drawing.Color.Green;
            this.agregarCategoriaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarCategoriaButton.Location = new System.Drawing.Point(135, 172);
            this.agregarCategoriaButton.Name = "agregarCategoriaButton";
            this.agregarCategoriaButton.Size = new System.Drawing.Size(27, 27);
            this.agregarCategoriaButton.TabIndex = 5;
            this.agregarCategoriaButton.Text = "+";
            this.agregarCategoriaButton.UseVisualStyleBackColor = false;
            this.agregarCategoriaButton.Click += new System.EventHandler(this.AgregarCategoriaButton_Click);
            // 
            // categoriasPanel
            // 
            this.categoriasPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.categoriasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoriasPanel.Controls.Add(this.categoriaTextBox);
            this.categoriasPanel.Location = new System.Drawing.Point(177, 172);
            this.categoriasPanel.Name = "categoriasPanel";
            this.categoriasPanel.Size = new System.Drawing.Size(460, 87);
            this.categoriasPanel.TabIndex = 7;
            this.categoriasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoriasPanel_Paint);
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTextBox.Location = new System.Drawing.Point(3, 3);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(145, 27);
            this.categoriaTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "(max 9)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.crearCuadernoButton);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.colorLabel);
            this.panel1.Controls.Add(this.agregarCategoriaButton);
            this.panel1.Controls.Add(this.nuevoCuadernoLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombreCuadernoLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoriasPanel);
            this.panel1.Controls.Add(this.nombreCuadernoTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 543);
            this.panel1.TabIndex = 9;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(59, 293);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(64, 19);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "COLOR:";
            this.colorLabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.greenButton);
            this.flowLayoutPanel1.Controls.Add(this.redButton);
            this.flowLayoutPanel1.Controls.Add(this.orangeButton);
            this.flowLayoutPanel1.Controls.Add(this.yellowButton);
            this.flowLayoutPanel1.Controls.Add(this.blueButton);
            this.flowLayoutPanel1.Controls.Add(this.deepSkyBlueButton);
            this.flowLayoutPanel1.Controls.Add(this.deepPinkButton);
            this.flowLayoutPanel1.Controls.Add(this.pinkButton);
            this.flowLayoutPanel1.Controls.Add(this.purpleButton);
            this.flowLayoutPanel1.Controls.Add(this.whiteButton);
            this.flowLayoutPanel1.Controls.Add(this.grayButton);
            this.flowLayoutPanel1.Controls.Add(this.blackButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(177, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 111);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(3, 3);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(30, 30);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(39, 3);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(30, 30);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.Location = new System.Drawing.Point(75, 3);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(30, 30);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.UseVisualStyleBackColor = false;
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(111, 3);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(30, 30);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(3, 39);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(30, 30);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Purple;
            this.purpleButton.Location = new System.Drawing.Point(3, 75);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(30, 30);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.UseVisualStyleBackColor = false;
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.Pink;
            this.pinkButton.Location = new System.Drawing.Point(111, 39);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(30, 30);
            this.pinkButton.TabIndex = 6;
            this.pinkButton.UseVisualStyleBackColor = false;
            // 
            // deepSkyBlueButton
            // 
            this.deepSkyBlueButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deepSkyBlueButton.Location = new System.Drawing.Point(39, 39);
            this.deepSkyBlueButton.Name = "deepSkyBlueButton";
            this.deepSkyBlueButton.Size = new System.Drawing.Size(30, 30);
            this.deepSkyBlueButton.TabIndex = 7;
            this.deepSkyBlueButton.UseVisualStyleBackColor = false;
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(39, 75);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(30, 30);
            this.whiteButton.TabIndex = 8;
            this.whiteButton.UseVisualStyleBackColor = false;
            // 
            // grayButton
            // 
            this.grayButton.BackColor = System.Drawing.Color.Gray;
            this.grayButton.Location = new System.Drawing.Point(75, 75);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(30, 30);
            this.grayButton.TabIndex = 9;
            this.grayButton.UseVisualStyleBackColor = false;
            // 
            // deepPinkButton
            // 
            this.deepPinkButton.BackColor = System.Drawing.Color.DeepPink;
            this.deepPinkButton.Location = new System.Drawing.Point(75, 39);
            this.deepPinkButton.Name = "deepPinkButton";
            this.deepPinkButton.Size = new System.Drawing.Size(30, 30);
            this.deepPinkButton.TabIndex = 10;
            this.deepPinkButton.UseVisualStyleBackColor = false;
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(111, 75);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(30, 30);
            this.blackButton.TabIndex = 11;
            this.blackButton.UseVisualStyleBackColor = false;
            // 
            // crearCuadernoButton
            // 
            this.crearCuadernoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crearCuadernoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.crearCuadernoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.crearCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearCuadernoButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCuadernoButton.ForeColor = System.Drawing.Color.LightGray;
            this.crearCuadernoButton.Location = new System.Drawing.Point(539, 413);
            this.crearCuadernoButton.Name = "crearCuadernoButton";
            this.crearCuadernoButton.Size = new System.Drawing.Size(133, 34);
            this.crearCuadernoButton.TabIndex = 12;
            this.crearCuadernoButton.Text = "CREAR CUADERNO";
            this.crearCuadernoButton.UseVisualStyleBackColor = false;
            // 
            // NuevoCuaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCuaderno";
            this.Text = "Nuevo Cuaderno";
            this.categoriasPanel.ResumeLayout(false);
            this.categoriasPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombreCuadernoTextBox;
        private System.Windows.Forms.Label nuevoCuadernoLabel;
        private System.Windows.Forms.Label nombreCuadernoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button agregarCategoriaButton;
        private System.Windows.Forms.FlowLayoutPanel categoriasPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button deepSkyBlueButton;
        private System.Windows.Forms.Button deepPinkButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button grayButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button crearCuadernoButton;
    }
}
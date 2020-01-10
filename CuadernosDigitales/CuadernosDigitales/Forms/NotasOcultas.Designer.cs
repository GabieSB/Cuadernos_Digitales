namespace CuadernosDigitales.Forms
{
    partial class NotasOcultas
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
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.ErrorProviderContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(113, 166);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(98, 24);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "USUARIO:";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Enabled = false;
            this.TextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextBoxUsuario.Location = new System.Drawing.Point(50, 206);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(223, 29);
            this.TextBoxUsuario.TabIndex = 1;
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(94, 250);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(147, 24);
            this.LabelContraseña.TabIndex = 2;
            this.LabelContraseña.Text = "CONTRASEÑA:";
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TextBoxContraseña.Location = new System.Drawing.Point(50, 286);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.PasswordChar = '*';
            this.TextBoxContraseña.Size = new System.Drawing.Size(223, 29);
            this.TextBoxContraseña.TabIndex = 3;
            this.TextBoxContraseña.Leave += new System.EventHandler(this.TextBoxContraseña_Leave);
            // 
            // ingresarButton
            // 
            this.ingresarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ingresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ingresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ingresarButton.Location = new System.Drawing.Point(28, 330);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(280, 45);
            this.ingresarButton.TabIndex = 4;
            this.ingresarButton.Text = "VER NOTAS OCULTAS";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Controls.Add(this.closeAppButton);
            this.panel1.Controls.Add(this.LabelTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 147);
            this.panel1.TabIndex = 6;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Black;
            this.PictureBoxLogo.Image = global::CuadernosDigitales.Properties.Resources.azul;
            this.PictureBoxLogo.Location = new System.Drawing.Point(127, 6);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxLogo.TabIndex = 5;
            this.PictureBoxLogo.TabStop = false;
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(312, 3);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 7;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTitulo.Location = new System.Drawing.Point(33, 109);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(290, 37);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "NOTAS OCULTAS";
            // 
            // ErrorProviderContraseña
            // 
            this.ErrorProviderContraseña.ContainerControl = this;
            // 
            // NotasOcultas
            // 
            this.AcceptButton = this.ingresarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 390);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasOcultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.NotasOcultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.ErrorProvider ErrorProviderContraseña;
    }
}
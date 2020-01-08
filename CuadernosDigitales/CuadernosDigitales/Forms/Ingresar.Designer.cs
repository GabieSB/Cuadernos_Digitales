namespace CuadernosDigitales.Forms
{
    partial class Ingresar
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
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaLabel = new System.Windows.Forms.Label();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.noTieneCuentaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registrarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yaTienesCuenta = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(113, 166);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(96, 22);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "USUARIO:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("NewsGoth BT", 14.25F);
            this.usuarioTextBox.Location = new System.Drawing.Point(50, 206);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(223, 30);
            this.usuarioTextBox.TabIndex = 1;
            // 
            // contrasenaLabel
            // 
            this.contrasenaLabel.AutoSize = true;
            this.contrasenaLabel.Font = new System.Drawing.Font("NewsGoth BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaLabel.Location = new System.Drawing.Point(94, 260);
            this.contrasenaLabel.Name = "contrasenaLabel";
            this.contrasenaLabel.Size = new System.Drawing.Size(134, 22);
            this.contrasenaLabel.TabIndex = 2;
            this.contrasenaLabel.Text = "CONTRASEÑA:";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 14.25F);
            this.contrasenaTextBox.Location = new System.Drawing.Point(50, 297);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '*';
            this.contrasenaTextBox.Size = new System.Drawing.Size(223, 30);
            this.contrasenaTextBox.TabIndex = 3;
            // 
            // ingresarButton
            // 
            this.ingresarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ingresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ingresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarButton.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ingresarButton.Location = new System.Drawing.Point(98, 345);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(123, 45);
            this.ingresarButton.TabIndex = 4;
            this.ingresarButton.Text = "INGRESAR";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.closeAppButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 147);
            this.panel1.TabIndex = 6;
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(311, 3);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 7;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTEBOOKS";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // noTieneCuentaLinkLabel
            // 
            this.noTieneCuentaLinkLabel.AutoSize = true;
            this.noTieneCuentaLinkLabel.Location = new System.Drawing.Point(100, 405);
            this.noTieneCuentaLinkLabel.Name = "noTieneCuentaLinkLabel";
            this.noTieneCuentaLinkLabel.Size = new System.Drawing.Size(121, 13);
            this.noTieneCuentaLinkLabel.TabIndex = 8;
            this.noTieneCuentaLinkLabel.TabStop = true;
            this.noTieneCuentaLinkLabel.Text = "¿No tienes una cuenta?";
            this.noTieneCuentaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoTieneCuentaLinkLabel_LinkClicked);
            // 
            // registrarButton
            // 
            this.registrarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.registrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.registrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarButton.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.registrarButton.Location = new System.Drawing.Point(87, 345);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(145, 45);
            this.registrarButton.TabIndex = 9;
            this.registrarButton.Text = "REGISTRAR";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Visible = false;
            this.registrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CuadernosDigitales.Properties.Resources.azul;
            this.pictureBox1.Location = new System.Drawing.Point(111, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // yaTienesCuenta
            // 
            this.yaTienesCuenta.AutoSize = true;
            this.yaTienesCuenta.Location = new System.Drawing.Point(101, 405);
            this.yaTienesCuenta.Name = "yaTienesCuenta";
            this.yaTienesCuenta.Size = new System.Drawing.Size(120, 13);
            this.yaTienesCuenta.TabIndex = 10;
            this.yaTienesCuenta.TabStop = true;
            this.yaTienesCuenta.Text = "¿Ya tienes una cuenta?";
            this.yaTienesCuenta.Visible = false;
            this.yaTienesCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YaTienesUnaCuentaLinkLabel_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 427);
            this.panel2.TabIndex = 11;
            // 
            // Ingresar
            // 
            this.AcceptButton = this.ingresarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 427);
            this.Controls.Add(this.noTieneCuentaLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.contrasenaLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.yaTienesCuenta);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label contrasenaLabel;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.LinkLabel noTieneCuentaLinkLabel;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.LinkLabel yaTienesCuenta;
        private System.Windows.Forms.Panel panel2;
    }
}
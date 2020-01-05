namespace CuadernosDigitales.Forms
{
    partial class LoginForm
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
            this.closeAppButton = new System.Windows.Forms.Button();
            this.cabezaPanel = new System.Windows.Forms.Panel();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.ButtonIngresar = new System.Windows.Forms.Button();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.LinkLabelRegistrarce = new System.Windows.Forms.LinkLabel();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.cabezaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAppButton
            // 
            this.closeAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAppButton.BackColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeAppButton.FlatAppearance.BorderSize = 2;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeAppButton.Location = new System.Drawing.Point(556, 12);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(32, 23);
            this.closeAppButton.TabIndex = 0;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = false;
            this.closeAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // cabezaPanel
            // 
            this.cabezaPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.cabezaPanel.Controls.Add(this.LabelTitulo);
            this.cabezaPanel.Controls.Add(this.closeAppButton);
            this.cabezaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cabezaPanel.Location = new System.Drawing.Point(0, 0);
            this.cabezaPanel.Name = "cabezaPanel";
            this.cabezaPanel.Size = new System.Drawing.Size(600, 46);
            this.cabezaPanel.TabIndex = 1;
            this.cabezaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CabezaPanel_MouseDown);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTitulo.Location = new System.Drawing.Point(185, 12);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(197, 24);
            this.LabelTitulo.TabIndex = 13;
            this.LabelTitulo.Text = "Cuadernos Digitales";
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIngresar.Location = new System.Drawing.Point(478, 247);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(94, 33);
            this.ButtonIngresar.TabIndex = 9;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.ButtonIngresar_Click);
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContraseña.Location = new System.Drawing.Point(244, 157);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.PasswordChar = '*';
            this.TextBoxContraseña.Size = new System.Drawing.Size(141, 23);
            this.TextBoxContraseña.TabIndex = 8;
            this.TextBoxContraseña.Leave += new System.EventHandler(this.TextBoxContraseña_Leave);
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsuario.Location = new System.Drawing.Point(244, 94);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(141, 23);
            this.TextBoxUsuario.TabIndex = 7;
            this.TextBoxUsuario.Leave += new System.EventHandler(this.TextBoxUsuario_Leave);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(119, 157);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(96, 17);
            this.LabelContraseña.TabIndex = 6;
            this.LabelContraseña.Text = "Contraseña:";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(119, 94);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(69, 17);
            this.LabelUsuario.TabIndex = 5;
            this.LabelUsuario.Text = "Usuario:";
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelar.Location = new System.Drawing.Point(67, 247);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(94, 33);
            this.ButtonCancelar.TabIndex = 10;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // LinkLabelRegistrarce
            // 
            this.LinkLabelRegistrarce.AutoSize = true;
            this.LinkLabelRegistrarce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelRegistrarce.Location = new System.Drawing.Point(467, 208);
            this.LinkLabelRegistrarce.Name = "LinkLabelRegistrarce";
            this.LinkLabelRegistrarce.Size = new System.Drawing.Size(97, 17);
            this.LinkLabelRegistrarce.TabIndex = 11;
            this.LinkLabelRegistrarce.TabStop = true;
            this.LinkLabelRegistrarce.Text = "¿Registrarse?";
            this.LinkLabelRegistrarce.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRegistrarce_LinkClicked);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // errorProviderContraseña
            // 
            this.errorProviderContraseña.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.ButtonIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancelar;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.LinkLabelRegistrarce);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonIngresar);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.cabezaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadernos Digitales";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.cabezaPanel.ResumeLayout(false);
            this.cabezaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Panel cabezaPanel;
        private System.Windows.Forms.Button ButtonIngresar;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.LinkLabel LinkLabelRegistrarce;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.ErrorProvider errorProviderContraseña;
    }
}


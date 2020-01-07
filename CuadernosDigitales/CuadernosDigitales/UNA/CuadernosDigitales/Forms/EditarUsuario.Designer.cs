namespace CuadernosDigitales.Forms
{
    partial class EditarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorProviderContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderNuevaContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProviderRepetirNuevaContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonEditarContraseña = new System.Windows.Forms.Button();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.TextBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.LabelNuevaContraseña = new System.Windows.Forms.Label();
            this.TextBoxRepetirNuevaContraseña = new System.Windows.Forms.TextBox();
            this.LabelReperirNuevaContraseña = new System.Windows.Forms.Label();
            this.inicioPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNuevaContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRepetirNuevaContraseña)).BeginInit();
            this.inicioPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(686, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ErrorProviderContraseña
            // 
            this.ErrorProviderContraseña.ContainerControl = this;
            // 
            // ErrorProviderNuevaContraseña
            // 
            this.ErrorProviderNuevaContraseña.ContainerControl = this;
            // 
            // ErrorProviderRepetirNuevaContraseña
            // 
            this.ErrorProviderRepetirNuevaContraseña.ContainerControl = this;
            // 
            // ButtonEditarContraseña
            // 
            this.ButtonEditarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditarContraseña.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonEditarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButtonEditarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditarContraseña.ForeColor = System.Drawing.Color.LightGray;
            this.ButtonEditarContraseña.Location = new System.Drawing.Point(447, 397);
            this.ButtonEditarContraseña.Name = "ButtonEditarContraseña";
            this.ButtonEditarContraseña.Size = new System.Drawing.Size(197, 34);
            this.ButtonEditarContraseña.TabIndex = 0;
            this.ButtonEditarContraseña.Text = "Cambiar contraseña";
            this.ButtonEditarContraseña.UseVisualStyleBackColor = false;
            this.ButtonEditarContraseña.Click += new System.EventHandler(this.ButtonEditarContraseña_Click);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(240, 39);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(158, 24);
            this.LabelTitulo.TabIndex = 8;
            this.LabelTitulo.Text = "Edición Usuario";
            // 
            // TextBoxNuevaContraseña
            // 
            this.TextBoxNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNuevaContraseña.Location = new System.Drawing.Point(253, 255);
            this.TextBoxNuevaContraseña.Name = "TextBoxNuevaContraseña";
            this.TextBoxNuevaContraseña.PasswordChar = '*';
            this.TextBoxNuevaContraseña.Size = new System.Drawing.Size(147, 24);
            this.TextBoxNuevaContraseña.TabIndex = 9;
            this.TextBoxNuevaContraseña.Leave += new System.EventHandler(this.TextBoxNuevaContraseña_Leave);
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContraseña.Location = new System.Drawing.Point(253, 178);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.PasswordChar = '*';
            this.TextBoxContraseña.Size = new System.Drawing.Size(147, 24);
            this.TextBoxContraseña.TabIndex = 11;
            this.TextBoxContraseña.Leave += new System.EventHandler(this.TextBoxContraseña_Leave);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(223, 143);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(220, 17);
            this.LabelContraseña.TabIndex = 12;
            this.LabelContraseña.Text = "Ingrese la contraseña actual:";
            // 
            // LabelNuevaContraseña
            // 
            this.LabelNuevaContraseña.AutoSize = true;
            this.LabelNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNuevaContraseña.Location = new System.Drawing.Point(224, 221);
            this.LabelNuevaContraseña.Name = "LabelNuevaContraseña";
            this.LabelNuevaContraseña.Size = new System.Drawing.Size(220, 17);
            this.LabelNuevaContraseña.TabIndex = 13;
            this.LabelNuevaContraseña.Text = "Ingrese la nueva contraseña:";
            // 
            // TextBoxRepetirNuevaContraseña
            // 
            this.TextBoxRepetirNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRepetirNuevaContraseña.Location = new System.Drawing.Point(252, 336);
            this.TextBoxRepetirNuevaContraseña.Name = "TextBoxRepetirNuevaContraseña";
            this.TextBoxRepetirNuevaContraseña.PasswordChar = '*';
            this.TextBoxRepetirNuevaContraseña.Size = new System.Drawing.Size(147, 24);
            this.TextBoxRepetirNuevaContraseña.TabIndex = 14;
            this.TextBoxRepetirNuevaContraseña.Leave += new System.EventHandler(this.TextBoxRepetirNuevaContraseña_Leave);
            // 
            // LabelReperirNuevaContraseña
            // 
            this.LabelReperirNuevaContraseña.AutoSize = true;
            this.LabelReperirNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReperirNuevaContraseña.Location = new System.Drawing.Point(223, 302);
            this.LabelReperirNuevaContraseña.Name = "LabelReperirNuevaContraseña";
            this.LabelReperirNuevaContraseña.Size = new System.Drawing.Size(213, 17);
            this.LabelReperirNuevaContraseña.TabIndex = 15;
            this.LabelReperirNuevaContraseña.Text = "Repita la nueva contraseña:";
            // 
            // inicioPanel
            // 
            this.inicioPanel.BackColor = System.Drawing.SystemColors.Control;
            this.inicioPanel.Controls.Add(this.LabelReperirNuevaContraseña);
            this.inicioPanel.Controls.Add(this.TextBoxRepetirNuevaContraseña);
            this.inicioPanel.Controls.Add(this.LabelNuevaContraseña);
            this.inicioPanel.Controls.Add(this.LabelContraseña);
            this.inicioPanel.Controls.Add(this.TextBoxContraseña);
            this.inicioPanel.Controls.Add(this.TextBoxNuevaContraseña);
            this.inicioPanel.Controls.Add(this.LabelTitulo);
            this.inicioPanel.Controls.Add(this.ButtonEditarContraseña);
            this.inicioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioPanel.Location = new System.Drawing.Point(0, 0);
            this.inicioPanel.Name = "inicioPanel";
            this.inicioPanel.Size = new System.Drawing.Size(670, 443);
            this.inicioPanel.TabIndex = 5;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.inicioPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarUsuario";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderNuevaContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderRepetirNuevaContraseña)).EndInit();
            this.inicioPanel.ResumeLayout(false);
            this.inicioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider ErrorProviderContraseña;
        private System.Windows.Forms.ErrorProvider ErrorProviderNuevaContraseña;
        private System.Windows.Forms.ErrorProvider ErrorProviderRepetirNuevaContraseña;
        private System.Windows.Forms.Panel inicioPanel;
        private System.Windows.Forms.Label LabelReperirNuevaContraseña;
        private System.Windows.Forms.TextBox TextBoxRepetirNuevaContraseña;
        private System.Windows.Forms.Label LabelNuevaContraseña;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.TextBox TextBoxNuevaContraseña;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Button ButtonEditarContraseña;
    }
}
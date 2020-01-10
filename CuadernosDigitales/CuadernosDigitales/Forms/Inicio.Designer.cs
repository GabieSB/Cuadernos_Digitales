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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarCuadernoTextBox = new System.Windows.Forms.TextBox();
            this.inicioPanel = new System.Windows.Forms.Panel();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.idPantallaLabel = new System.Windows.Forms.Label();
            this.cuadernosContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buscaNotaButton = new System.Windows.Forms.Button();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoCuadernoButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.atrasButton = new System.Windows.Forms.Button();
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
            this.inicioPanel.BackColor = System.Drawing.Color.White;
            this.inicioPanel.Controls.Add(this.nuevoCuadernoButton);
            this.inicioPanel.Controls.Add(this.filtroComboBox);
            this.inicioPanel.Controls.Add(this.idPantallaLabel);
            this.inicioPanel.Controls.Add(this.cuadernosContainer);
            this.inicioPanel.Controls.Add(this.buscaNotaButton);
            this.inicioPanel.Controls.Add(this.buscarTextBox);
            this.inicioPanel.Controls.Add(this.button2);
            this.inicioPanel.Controls.Add(this.buscarCuadernoTextBox);
            this.inicioPanel.Controls.Add(this.eliminarButton);
            this.inicioPanel.Controls.Add(this.atrasButton);
            this.inicioPanel.Controls.Add(this.label2);
            this.inicioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioPanel.Location = new System.Drawing.Point(0, 0);
            this.inicioPanel.Name = "inicioPanel";
            this.inicioPanel.Size = new System.Drawing.Size(800, 545);
            this.inicioPanel.TabIndex = 5;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroComboBox.Font = new System.Drawing.Font("NewsGoth BT", 12F);
            this.filtroComboBox.Items.AddRange(new object[] {
            "NOMBRE",
            "CATEGORIA"});
            this.filtroComboBox.Location = new System.Drawing.Point(322, 21);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(132, 27);
            this.filtroComboBox.TabIndex = 25;
            // 
            // idPantallaLabel
            // 
            this.idPantallaLabel.AutoSize = true;
            this.idPantallaLabel.ForeColor = System.Drawing.Color.Black;
            this.idPantallaLabel.Location = new System.Drawing.Point(18, 518);
            this.idPantallaLabel.Name = "idPantallaLabel";
            this.idPantallaLabel.Size = new System.Drawing.Size(100, 13);
            this.idPantallaLabel.TabIndex = 22;
            this.idPantallaLabel.Text = "ID PANTALLA: 002";
            // 
            // cuadernosContainer
            // 
            this.cuadernosContainer.AutoScroll = true;
            this.cuadernosContainer.BackColor = System.Drawing.Color.White;
            this.cuadernosContainer.Location = new System.Drawing.Point(15, 69);
            this.cuadernosContainer.Margin = new System.Windows.Forms.Padding(15);
            this.cuadernosContainer.Name = "cuadernosContainer";
            this.cuadernosContainer.Size = new System.Drawing.Size(770, 441);
            this.cuadernosContainer.TabIndex = 10;
            // 
            // buscaNotaButton
            // 
            this.buscaNotaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaNotaButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buscaNotaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buscaNotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscaNotaButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaNotaButton.ForeColor = System.Drawing.Color.LightGray;
            this.buscaNotaButton.Location = new System.Drawing.Point(692, 21);
            this.buscaNotaButton.Name = "buscaNotaButton";
            this.buscaNotaButton.Size = new System.Drawing.Size(88, 30);
            this.buscaNotaButton.TabIndex = 9;
            this.buscaNotaButton.Text = "BUSCAR";
            this.buscaNotaButton.UseVisualStyleBackColor = false;
            this.buscaNotaButton.Click += new System.EventHandler(this.BuscaNotaButton_Click);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Font = new System.Drawing.Font("Dream Orphans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTextBox.Location = new System.Drawing.Point(474, 22);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(209, 25);
            this.buscarTextBox.TabIndex = 8;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "FILTRO:";
            // 
            // nuevoCuadernoButton
            // 
            this.nuevoCuadernoButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nuevoCuadernoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.nuevoCuadernoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoCuadernoButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCuadernoButton.ForeColor = System.Drawing.Color.LightGray;
            this.nuevoCuadernoButton.Image = global::CuadernosDigitales.Properties.Resources.book__1_;
            this.nuevoCuadernoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoCuadernoButton.Location = new System.Drawing.Point(15, 14);
            this.nuevoCuadernoButton.Name = "nuevoCuadernoButton";
            this.nuevoCuadernoButton.Size = new System.Drawing.Size(83, 38);
            this.nuevoCuadernoButton.TabIndex = 0;
            this.nuevoCuadernoButton.Text = "NUEVO ";
            this.nuevoCuadernoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoCuadernoButton.UseVisualStyleBackColor = false;
            this.nuevoCuadernoButton.Click += new System.EventHandler(this.NuevoCuadernoButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarButton.Image = global::CuadernosDigitales.Properties.Resources.bin;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(118, 15);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(93, 34);
            this.eliminarButton.TabIndex = 12;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Visible = false;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // atrasButton
            // 
            this.atrasButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.atrasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.atrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atrasButton.Font = new System.Drawing.Font("Dream Orphans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasButton.ForeColor = System.Drawing.Color.LightGray;
            this.atrasButton.Image = global::CuadernosDigitales.Properties.Resources.back__2_;
            this.atrasButton.Location = new System.Drawing.Point(15, 16);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(54, 34);
            this.atrasButton.TabIndex = 13;
            this.atrasButton.UseVisualStyleBackColor = false;
            this.atrasButton.Visible = false;
            this.atrasButton.Click += new System.EventHandler(this.AtrasButton_Click);
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
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.FlowLayoutPanel cuadernosContainer;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button atrasButton;
        public System.Windows.Forms.Label idPantallaLabel;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.Label label2;
    }
}
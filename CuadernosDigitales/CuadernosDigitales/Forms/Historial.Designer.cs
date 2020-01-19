namespace CuadernosDigitales.Forms
{
    partial class Historial
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
            this.historialDataGridView = new System.Windows.Forms.DataGridView();
            this.refrescarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historialDataGridView
            // 
            this.historialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialDataGridView.Location = new System.Drawing.Point(17, 22);
            this.historialDataGridView.Name = "historialDataGridView";
            this.historialDataGridView.Size = new System.Drawing.Size(760, 357);
            this.historialDataGridView.TabIndex = 0;
            // 
            // refrescarButton
            // 
            this.refrescarButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refrescarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refrescarButton.Location = new System.Drawing.Point(669, 395);
            this.refrescarButton.Name = "refrescarButton";
            this.refrescarButton.Size = new System.Drawing.Size(87, 32);
            this.refrescarButton.TabIndex = 1;
            this.refrescarButton.Text = "REFRESCAR";
            this.refrescarButton.UseVisualStyleBackColor = false;
            this.refrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.refrescarButton);
            this.Controls.Add(this.historialDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historialDataGridView;
        private System.Windows.Forms.Button refrescarButton;
    }
}
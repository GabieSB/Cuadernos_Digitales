namespace CuadernosDigitales.Forms
{
    partial class UCCuadernoDigital
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreCuaderno = new System.Windows.Forms.Label();
            this.CuadernoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CuadernoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreCuaderno
            // 
            this.nombreCuaderno.AutoSize = true;
            this.nombreCuaderno.Font = new System.Drawing.Font("NewsGoth BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCuaderno.Location = new System.Drawing.Point(71, 140);
            this.nombreCuaderno.Name = "nombreCuaderno";
            this.nombreCuaderno.Size = new System.Drawing.Size(0, 14);
            this.nombreCuaderno.TabIndex = 1;
            // 
            // CuadernoPictureBox
            // 
            this.CuadernoPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.CuadernoPictureBox.Location = new System.Drawing.Point(55, 5);
            this.CuadernoPictureBox.Name = "CuadernoPictureBox";
            this.CuadernoPictureBox.Size = new System.Drawing.Size(120, 132);
            this.CuadernoPictureBox.TabIndex = 0;
            this.CuadernoPictureBox.TabStop = false;
            this.CuadernoPictureBox.Click += new System.EventHandler(this.CuadernoPictureBox_Click);
            // 
            // UCCuadernoDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nombreCuaderno);
            this.Controls.Add(this.CuadernoPictureBox);
            this.Name = "UCCuadernoDigital";
            this.Size = new System.Drawing.Size(231, 167);
            ((System.ComponentModel.ISupportInitialize)(this.CuadernoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombreCuaderno;
        public System.Windows.Forms.PictureBox CuadernoPictureBox;
    }
}

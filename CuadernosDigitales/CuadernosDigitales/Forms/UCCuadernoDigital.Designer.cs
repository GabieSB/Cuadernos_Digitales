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
            this.nombreRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.CuadernoPictureBox.Location = new System.Drawing.Point(55, 2);
            this.CuadernoPictureBox.Name = "CuadernoPictureBox";
            this.CuadernoPictureBox.Size = new System.Drawing.Size(120, 124);
            this.CuadernoPictureBox.TabIndex = 0;
            this.CuadernoPictureBox.TabStop = false;
            this.CuadernoPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CuadernoPictureBox_MouseClick);
            // 
            // nombreRichTextBox
            // 
            this.nombreRichTextBox.BackColor = System.Drawing.Color.White;
            this.nombreRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreRichTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRichTextBox.Location = new System.Drawing.Point(3, 132);
            this.nombreRichTextBox.Name = "nombreRichTextBox";
            this.nombreRichTextBox.ReadOnly = true;
            this.nombreRichTextBox.Size = new System.Drawing.Size(225, 23);
            this.nombreRichTextBox.TabIndex = 2;
            this.nombreRichTextBox.Text = "nombre";
            this.nombreRichTextBox.Visible = false;
            // 
            // UCCuadernoDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nombreCuaderno);
            this.Controls.Add(this.CuadernoPictureBox);
            this.Controls.Add(this.nombreRichTextBox);
            this.Name = "UCCuadernoDigital";
            this.Size = new System.Drawing.Size(231, 167);
            ((System.ComponentModel.ISupportInitialize)(this.CuadernoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombreCuaderno;
        public System.Windows.Forms.PictureBox CuadernoPictureBox;
        private System.Windows.Forms.RichTextBox nombreRichTextBox;
    }
}

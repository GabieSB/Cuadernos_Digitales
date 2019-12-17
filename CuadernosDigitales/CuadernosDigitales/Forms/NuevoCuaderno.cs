using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Forms
{
    public partial class NuevoCuaderno : Form
    {
        public NuevoCuaderno()
        {
            InitializeComponent();
        }

        private void AgregarCategoriaButton_Click(object sender, EventArgs e)
        {
            TextBox categoriaTextBox = new TextBox();
            categoriaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaTextBox.Location = new System.Drawing.Point(171, 167);
            categoriaTextBox.Name = "textBox";
            categoriaTextBox.Size = new System.Drawing.Size(145, 27);
            categoriaTextBox.TabIndex = 0;
        }
    }
}

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
        private int cantidadCategorias;
        public NuevoCuaderno()
        {
            InitializeComponent();
            cantidadCategorias = 1;
        }

        private void AgregarCategoriaButton_Click(object sender, EventArgs e)
        {
            // int x = 171 + (155 * cantidadCategorias);
            // int y = 167;
            if (cantidadCategorias < 9)
            {
                TextBox categoriaTextBox = new TextBox();
                categoriaTextBox.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // categoriaTextBox.Location = new System.Drawing.Point(x, y);
                categoriaTextBox.Name = "categoriaTextBox";
                categoriaTextBox.Size = new System.Drawing.Size(145, 27);
                categoriaTextBox.TabIndex = 0;
                this.categoriasPanel.Controls.Add(categoriaTextBox);
                cantidadCategorias++;
            }
            
            

        }

        private void CategoriasPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}

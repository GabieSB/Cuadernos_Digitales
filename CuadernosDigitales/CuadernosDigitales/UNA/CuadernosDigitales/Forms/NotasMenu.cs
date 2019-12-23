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
    public partial class NotasMenu : Form
    {
       // private List<Cuaderno> cuadernos ;
        public NotasMenu()
        {
            InitializeComponent();
            nombreCuadernoLabel.Text = Inicio.CuadernoSeleccionado.Nombre;
            categoriasGridView.DataSource = Inicio.CuadernoSeleccionado.getListaDeCategorias();
        }

        private void NuevaNotaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseNotasCuadernoButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

using CuadernosDigitales.Clases;
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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            AdministradorArchivos administrador = new AdministradorArchivos();
            historialDataGridView.DataSource = administrador.getAcciones(CuadernosInicio.usuarioActual);
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            AdministradorArchivos administrador = new AdministradorArchivos();
            historialDataGridView.DataSource = administrador.getAcciones(CuadernosInicio.usuarioActual);
        }
    }
}

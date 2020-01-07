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
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        public List<Usuario> Usuarios
        {
            get;
            set;
        }
        public int IndiceUsuario
        {
            get;
            set;
        }
        public NotasMenu()
        {
            InitializeComponent();
            nombreCuadernoLabel.Text = Inicio.CuadernoSeleccionado.Nombre;
            categoriasGridView.DataSource = Inicio.CuadernoSeleccionado.getListaDeCategorias();
        }

        private void NuevaNotaButton_Click(object sender, EventArgs e)
        {
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de crear nueva nota", $"El usuario {Usuarios[IndiceUsuario].Nombre} creo una nueva nota", "Notas Menu", 0);
            CrearHistorialCreacionNota(archivoManager);
        }

        private void CloseNotasCuadernoButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void CargarInformacionActividadUsuario(ArchivoManager archivoManager, String accion, String informacionAdicional, string formulario, int objeto)
        {
            archivoManager.Historial = new Historial(DateTime.Now, Usuarios[IndiceUsuario].Nombre, accion, informacionAdicional, formulario, objeto);
        }
        private void CrearHistorialVisitaFormulario(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialVisitaFormulario(rutaPorDefecto);
            }
            catch (Exception exception)
            {

            }
        }

        private void NotasMenu_Load(object sender, EventArgs e)
        {
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar un cuaderno", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al formulario de Notas Menu", "Notas Menu", 0);
            CrearHistorialVisitaFormulario(archivoManager);
        }
        private void CrearHistorialCreacionNota(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialEdicionObjeto(rutaPorDefecto);
            }
            catch (Exception exception)
            {

            }
        }
    }
}

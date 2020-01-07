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
    public partial class EditarUsuario : Form
    {
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
        public Usuario Usuario
        {
            get;
            set;
        }
        public Boolean ContraseñaActualUsuario
        {
            get;
            set;
        }
        public Boolean NuevaContraseñaUsuario
        {
            get;
            set;
        }
        public Boolean RepetirNuevaContraseñaUsuario
        {
            get;
            set;
        }
        public EditarUsuario()
        {
            InitializeComponent();

            ContraseñaActualUsuario = false;
            NuevaContraseñaUsuario = false;
            RepetirNuevaContraseñaUsuario = false;

            Usuario = new Usuario();

            List<PictureBox> picturesBooks = new List<PictureBox>();
        }

        private void MostrarFormEnPanel(Object form)
        {
            if (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }

            Form formPanel = form as Form;
            formPanel.TopLevel =  false;
            formPanel.Dock = DockStyle.Fill;
            this.Controls.Add(formPanel);
            this.Tag = formPanel;
            formPanel.Show();
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3)
            {
                ErrorProviderContraseña.SetError(TextBoxContraseña, "Ingrese la contraseña actual del Usuario");
            }
            else
            {
                if (Usuarios[IndiceUsuario].Contraseña == TextBoxContraseña.Text)
                {
                    ContraseñaActualUsuario = true;
                }
                else
                {
                    ErrorProviderContraseña.SetError(TextBoxContraseña, "La contraseña del Usuario esta incorrecta");
                    ContraseñaActualUsuario = false;
                }
            }
        }

        private void TextBoxNuevaContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxNuevaContraseña.TextLength < 3)
            {
                ErrorProviderNuevaContraseña.SetError(TextBoxNuevaContraseña, "Ingrese la nueva contraseña del Usuario");
                NuevaContraseñaUsuario = false;
            }
            else
            {
                Usuario.Contraseña = TextBoxNuevaContraseña.Text;
                NuevaContraseñaUsuario = true;

                if (Usuario.Contraseña == TextBoxRepetirNuevaContraseña.Text)
                {
                    RepetirNuevaContraseñaUsuario = true;
                }
                else
                {
                    RepetirNuevaContraseñaUsuario = false;
                }
            }
        }

        private void TextBoxRepetirNuevaContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepetirNuevaContraseña.TextLength < 3)
            {
                ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "Repita la nueva contraseña del Usuario");
                RepetirNuevaContraseñaUsuario = false;
            }
            else
            {
                if (Usuario.Contraseña == TextBoxRepetirNuevaContraseña.Text)
                {
                    RepetirNuevaContraseñaUsuario = true;
                }
                else
                {
                    ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "La nueva contraseña del Usuario es diferente al repetirla");
                    RepetirNuevaContraseñaUsuario = false;
                }
            }
        }

        private void ButtonEditarContraseña_Click(object sender, EventArgs e)
        {
            if (ContraseñaActualUsuario && NuevaContraseñaUsuario && RepetirNuevaContraseñaUsuario)
            {
                Usuarios[IndiceUsuario].Contraseña = Usuario.Contraseña;
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Edición de usuario", $"El usuario {Usuarios[IndiceUsuario].Nombre} edito su contraseña", "Editar Usuario", IndiceUsuario);
                CrearHistorialEdicionUsuario(archivoManager);
                DialogResult dialogResult = MessageBox.Show("Se edito la contraseña correctamente");
                LimpiarTextBoxYErroProvider();
            }
            else{
                DialogResult dialogResult = MessageBox.Show("Datos incorrectos");
            }
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
        private void CrearHistorialEdicionUsuario(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialEdicionObjeto(rutaPorDefecto);
            }
            catch (Exception exception)
            {

            }
        }
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Editar Usuario", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al formulario de Editar usuario", "Editar Usuario", 0);
            CrearHistorialVisitaFormulario(archivoManager);
        }
        private void LimpiarTextBoxYErroProvider()
        {
            TextBoxContraseña.Text = "";
            TextBoxNuevaContraseña.Text = "";
            TextBoxRepetirNuevaContraseña.Text = "";

            ErrorProviderContraseña.SetError(TextBoxContraseña, "");
            ErrorProviderNuevaContraseña.SetError(TextBoxNuevaContraseña, "");
            ErrorProviderRepetirNuevaContraseña.SetError(TextBoxRepetirNuevaContraseña, "");
        }
    }
}

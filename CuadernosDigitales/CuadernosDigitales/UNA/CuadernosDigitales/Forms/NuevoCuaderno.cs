using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadernosDigitales.Forms
{
    public partial class NuevoCuaderno : Form
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

        private int cantidadCategorias;
        public static Cuaderno cuaderno;
        public DialogResult cuadernoCreado;
        private TextBox[] categoriasTexBox;
        public Bitmap colorSeleccionado;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public NuevoCuaderno()
        {
            InitializeComponent();
            cantidadCategorias = 1;
            categoriasTexBox = new TextBox[9];
            cuaderno = new Cuaderno();
            agregarTextBoxs();
            
            
        }
        public void agregarTextBoxs()
        {
            for(int i = 0; i < 9; i++)
            {
                categoriasTexBox[i] = new TextBox();
                categoriasTexBox[i].Font = new Font("NewsGoth BT", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                // categoriaTextBox.Location = new System.Drawing.Point(x, y);
                categoriasTexBox[i].Name = "categoriaTextBox";
                categoriasTexBox[i].Size = new Size(145, 27);
                categoriasTexBox[i].TabIndex = 0;
                categoriasTexBox[i].Visible = false;
                if (i == 0) categoriasTexBox[i].Visible = true;
                this.flowLayoutPanel1.Controls.Add(categoriasTexBox[i]);
            }
        }

        private void AgregarCategoriaButton_Click(object sender, EventArgs e)
        {
            if (cantidadCategorias < 9)
            {
                categoriasTexBox[cantidadCategorias].Visible = true;
                cantidadCategorias++;
            }
        }

        private void CloseNuevoCuadernoButton_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Green;
            colorSeleccionado = Properties.Resources.Green;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Red;
            colorSeleccionado = Properties.Resources.Red;
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Orange;
            colorSeleccionado = Properties.Resources.Orange;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Yellow;
            // colorSeleccionado = Properties.Resources.Yellow;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Blue;
            colorSeleccionado = Properties.Resources.Blue;
        }

        private void DeepSkyBlueButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.DeepPink;
            //colorSeleccionado = Properties.Resources.DeepSkyBlue;
        }

        private void DeepPinkButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.DeepPink;
            //colorSeleccionado = "DeepPink";

        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Pink;
           // colorSeleccionado = "Pink";
        }

        private void PurpleButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Purple;
            colorSeleccionado = Properties.Resources.Purple;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.White;
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Gray;
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            colorSeleccionadoPanel.BackColor = System.Drawing.Color.Black;
        }

        private void CrearCuadernoButton_Click(object sender, EventArgs e)
        {
            cuaderno.Nombre = nombreCuadernoTextBox.Text;
            cuaderno.Color = colorSeleccionadoPanel.BackColor;
           
            for (int i = 0; i < 9; i++)
            {
                Categoria categoria1 = new Categoria();
                categoria1.Nombre = categoriasTexBox[i].Text;
                cuaderno.agregarCategoria(categoria1);
            }
            cuadernoCreado = DialogResult.Yes;

            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de crear nuevo cuaderno", $"El usuario {Usuarios[IndiceUsuario].Nombre} creo un nuevo cuaderno", "Nuevo Cuaderno", 0);
            CrearHistorialCreacionCuaderno(archivoManager);

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

        private void NuevoCuaderno_Load(object sender, EventArgs e)
        {
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de nuevo cuaderno", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al formulario de nuevo cuaderno", "Nuevo cuaderno", 0);
            CrearHistorialVisitaFormulario(archivoManager);
        }

        private void CrearHistorialCreacionCuaderno(ArchivoManager archivoManager)
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

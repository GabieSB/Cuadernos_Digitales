using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CuadernosDigitales.Forms;

namespace CuadernosDigitales
{
    public partial class CuadernosInicio : Form
    {
        public CuadernosInicio()
        {
            InitializeComponent();
        }

    

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       private void MostrarFormEnPanel(Object form)
        {
            if (this.cuerpoPanel.Controls.Count > 0)
            {
                this.cuerpoPanel.Controls.RemoveAt(0);
            }

            Form formPanel = form as Form;
            formPanel.TopLevel = false;
            formPanel.Dock = DockStyle.Fill;
            this.cuerpoPanel.Controls.Add(formPanel);
            this.cuerpoPanel.Tag = formPanel;
            formPanel.Show();
        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = cuerpoPanel.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                cuerpoPanel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void ComprimirButton_Click(object sender, EventArgs e)
        {
            if (listaOpcionePanel.Width == 52)
            {
                //cuerpoPanel.Location = new Point(189, 46);
               // cuerpoPanel.Width = 660;
                listaOpcionePanel.Width = 188;
                listaOpcionePanel.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                //cuerpoPanel.Location = new Point(61, 46);
               // cuerpoPanel.Width = 796;
                listaOpcionePanel.Width = 52;
                listaOpcionePanel.BorderStyle = BorderStyle.None;
            }

        }

        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

       

        private void InicioButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "INICIO";
            AbrirForm<Inicio>(); 
        }
       
        private void InicioButtonAlternative_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "INICIO";
            MostrarFormEnPanel(new Inicio());
        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = true;
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "HISTORIAL";
           // AbrirForm<NuevaNota>();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = true;
           
        }

        private void CuadernosInicio_Load(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = true;
            etiquetaHistorial.Visible = false;
            etiquetaCambiarU.Visible = false;
        }

        private void CabezaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaOpcionePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

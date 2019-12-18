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
            if (listaOpcionePanel.Width == 188)
            {
                listaOpcionePanel.Width = 52;
            }
            else
            {
                listaOpcionePanel.Width = 188;
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
            MostrarFormEnPanel(new Inicio());
        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            etiquetaInicio.Visible = false;
            etiquetaHistorial.Visible = true;
            etiquetaCambiarU.Visible = false;
            tituloLabel.Text = "HISTORIAL";
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
    }
}

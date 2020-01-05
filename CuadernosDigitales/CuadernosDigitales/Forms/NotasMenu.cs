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
        private Panel panel;
        public static Nota notaNueva;
        public NotasMenu()
        {
            InitializeComponent();
            nombreCuadernoLabel.Text = Inicio.CuadernoSeleccionado.Nombre;
            cargarNotas();
            // categoriasGridView.DataSource = Inicio.CuadernoSeleccionado.getListaDeCategorias();
        }

        private void MostrarFormEnPanel(Object form)
        {
            panel = new Panel();
            panel = notasMenuPanel;

            notasMenuPanel.Visible = false;

        }
        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = notasMenuPanel.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                notasMenuPanel.Controls.Add(formulario);
                formulario.BringToFront();
                formulario.Show();


            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void NuevaNotaButton_Click(object sender, EventArgs e)
        {

            // AbrirForm<NuevaNota>();
            //  this.Close();
            NuevaNota nuevaNota = new NuevaNota(this);
            AddOwnedForm(nuevaNota);
            nuevaNota.TopLevel = false;
            nuevaNota.Dock = DockStyle.Fill;
            this.Controls.Add(nuevaNota);
            this.Tag = nuevaNota;
            nuevaNota.BringToFront();
            nuevaNota.Show();

        }
         public  void NuevaNota_itsClosed()
        {
            notaNueva = NuevaNota.nota;
            MessageBox.Show(notaNueva.Titulo);
            Inicio.CuadernoSeleccionado.agregarNota(notaNueva);
            MostrarNotaEnPantalla(notaNueva);
           
        }

        private void MostrarNotaEnPantalla(Nota nota)
        {  
            Panel panel = new Panel();
            Label nombre = new Label();
            panel.BackColor = nota.Color;
            panel.Margin = new System.Windows.Forms.Padding(15);
            panel.Size = new System.Drawing.Size(355, 45);
            panel.TabIndex = 9;
            nombre.Text = nota.Titulo;
            nombre.Location = new Point(14, 12);
            panel.Controls.Add(nombre);
            notasContainer.Controls.Add(panel);
            
        }

        private void cargarNotas()
        {
            if (Inicio.CuadernoSeleccionado.getListaDeNotas()!=null)
            {
                foreach(Nota item in Inicio.CuadernoSeleccionado.getListaDeNotas())
                {
                    MostrarNotaEnPantalla(item);
                }
            }

        }

        
        

        private void CloseNotasCuadernoButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

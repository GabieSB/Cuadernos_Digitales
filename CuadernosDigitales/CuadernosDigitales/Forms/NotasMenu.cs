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
        private Cuaderno cuadernoPadre;
        public static Nota notaNueva;
        public static Nota notaSeleccionada;
        private Panel panelSeleccionadaAux;
        private bool sePuedeEditarNota;

        public NotasMenu()
        {
            InitializeComponent();
            cuadernoPadre = Inicio.CuadernoSeleccionado;
            nombreCuadernoLabel.Text = cuadernoPadre.Nombre;
            cargarNotas(cuadernoPadre.getListaDeNotas(),false);
            panelSeleccionadaAux = new Panel();
            sePuedeEditarNota = true;

        }
      
        private void NuevaNotaButton_Click(object sender, EventArgs e)
        {

            NuevaNota nuevaNota = new NuevaNota(this, true);
            AddOwnedForm(nuevaNota);
            nuevaNota.TopLevel = false;
            nuevaNota.Dock = DockStyle.Fill;
            this.Controls.Add(nuevaNota);
            this.Tag = nuevaNota;
            nuevaNota.BringToFront();
            nuevaNota.Show();

        }
         public  void NuevaNotaGuardada()
        {
            notaNueva = NuevaNota.nota;
            Inicio.CuadernoSeleccionado.agregarNota(notaNueva);
            if(!notaNueva.Privacidad) MostrarNotaEnPantalla(notaNueva);


        }
        public void NotaEditada()
        {
            int numeroNota = Inicio.CuadernoSeleccionado.BuscarNota(notaSeleccionada.Titulo);
            
            if (numeroNota!=-1)
            {
                foreach(Control item in notasContainer.Controls)
                {

                    if(item.Name == Inicio.CuadernoSeleccionado.ObtenerNombre(numeroNota)&&item is Panel)
                    {
                        ((Panel)item).BackColor = notaNueva.Color;
                        ((Panel)item).Name = notaNueva.Titulo;
                        foreach(Control c in ((Panel)item).Controls)
                        {
                            if(c is Label)
                            {
                                ((Label)c).Name = item.Name;
                                ((Label)c).Text = item.Name;
                            }
                        }
                    }
                }

                Inicio.CuadernoSeleccionado.ModificarNota(numeroNota, notaNueva);
            }
        }

        private void MostrarNotaEnPantalla(Nota nota)
        {  
            Panel panel = new Panel();
            Label nombre = new Label();
            panel.BackColor = nota.Color;
            panel.Margin = new Padding(15);
            panel.Size = new Size(355, 45);
            panel.TabIndex = 9;
            panel.Name = nota.Titulo;
            nombre.AutoSize = true;
            nombre.Name = nota.Titulo;
            nombre.Text = nota.Titulo;
            nombre.Location = new Point(14, 12);
            nombre.Enabled = false;
            nombre.Font = new Font("NewsGoth BT", 12F, FontStyle.Bold);
            panel.Controls.Add(nombre);
            panel.MouseClick += new MouseEventHandler(this.NotaSeleccionada_MouseClick);
            notasContainer.Controls.Add(panel);
            
        }

        private void cargarNotas(List<Nota> notas, bool mostrarOcultas)
        {
            if (notas!=null)
            {
                foreach(Nota item in notas)
                {
                    if (!item.Privacidad)
                    {
                        MostrarNotaEnPantalla(item);
                    }else if(item.Privacidad && mostrarOcultas)
                    {
                        MostrarNotaEnPantalla(item);
                    }

                }
            }

        }

        private void NotaSeleccionada_MouseClick(object sender, MouseEventArgs e)
        {
            
            Panel notaSelect = sender as Panel;
            

            foreach (Nota nota in cuadernoPadre.getListaDeNotas())
            {
                if (notaSelect.Name == nota.Titulo)
                {
                    notaSeleccionada = new Nota();
                    notaSeleccionada = nota;

                }
            }
            if(e.Button == MouseButtons.Right)
            {
                int numeroNota = Inicio.CuadernoSeleccionado.BuscarNota(notaSeleccionada.Titulo);
                foreach (Control item in notasContainer.Controls)
                {
                    if (item.Name == Inicio.CuadernoSeleccionado.ObtenerNombre(numeroNota) && item is Panel)
                    {
                        if(((Panel)item)!= panelSeleccionadaAux){
                            panelSeleccionadaAux.BorderStyle = BorderStyle.None;
                            panelSeleccionadaAux = ((Panel)item);
                        }
                        ((Panel)item).BorderStyle = BorderStyle.FixedSingle;
                    }
                }

                nuevaNotaButton.Visible = false;
                verOcultasButton.Visible = false;
                eliminarButton.Visible = true;
                cancelarButton.Visible = true;
                sePuedeEditarNota = false;
               
            }
            else if(e.Button == MouseButtons.Left && sePuedeEditarNota)
            {
                NuevaNota nuevaNota = new NuevaNota(this, false);
                AddOwnedForm(nuevaNota);
                nuevaNota.TopLevel = false;
                nuevaNota.Dock = DockStyle.Fill;
                this.Controls.Add(nuevaNota);
                this.Tag = nuevaNota;
                nuevaNota.BringToFront();
                nuevaNota.Show();
            }
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscaNotaButton_Click(object sender, EventArgs e)
        {
            if (buscarCuadernoTextBox.Text.Length != 0)
            {
                Nota note = new Nota();
                note = cuadernoPadre.BuscarNota(buscarCuadernoTextBox.Text,true);
                if (note != null)
                {
                    notasContainer.Controls.Clear();
                    MostrarNotaEnPantalla(note);
                    nuevaNotaButton.Visible = false;
                    verNotasButton.Visible = false;
                    verNotasButton.Visible = true;
                }
 
            }
           
            
        }

        private void VerNotasButton_Click(object sender, EventArgs e)
        {
            notasContainer.Controls.Clear();
            verNotasButton.Visible = false;
            cancelarButton.Visible = false;
            nuevaNotaButton.Visible = true;
            verOcultasButton.Visible = true;
            buscarCuadernoTextBox.Text = "";
            cargarNotas(cuadernoPadre.getListaDeNotas(),false);
            sePuedeEditarNota = true;
        }

        private void VerOcultasButton_Click(object sender, EventArgs e)
        {
            List<Nota> notasOcultas = new List<Nota>();
            notasOcultas = cuadernoPadre.getNotasOcultas();
            if (notasOcultas != null)
            {
                notasContainer.Controls.Clear();
                nuevaNotaButton.Visible = false;
                verOcultasButton.Visible = false;
                verNotasButton.Visible = true;
                cargarNotas(notasOcultas,true);
            }
            

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            cuadernoPadre.EliminarNota(notaSeleccionada);
            VerNotasButton_Click(sender, e);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            VerNotasButton_Click(sender, e);
        }
    }
}

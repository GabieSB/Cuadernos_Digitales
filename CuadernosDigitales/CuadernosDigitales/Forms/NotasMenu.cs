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
    public partial class NotasMenu : Form

    {
        private Cuaderno cuadernoPadre;
        public static Nota notaNueva;
        public static Nota notaSeleccionada;
        private Panel panelSeleccionadaAux;
        private bool sePuedeEditarNota;
       // private List<Nota> ActualListaEnPantalla;
        private bool buscandoOcultas;
        private bool buscando;
        ErrorProvider error;

        public NotasMenu()
        {
            InitializeComponent();
            cuadernoPadre = Inicio.CuadernoSeleccionado;
            nombreCuadernoLabel.Text = cuadernoPadre.Nombre;
            cargarNotas(cuadernoPadre.getListaDeNotas(),false);
            panelSeleccionadaAux = new Panel();
            sePuedeEditarNota = true;
            error = new ErrorProvider();
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
            notaNueva.Orden = Inicio.CuadernoSeleccionado.getListaDeNotas().Count;
            Inicio.CuadernoSeleccionado.agregarNota(notaNueva);
            Accion accion = new Accion();
            accion.Objeto = "NOTA";
            accion.NombreUsuario = CuadernosInicio.usuarioActual.nombre;
            accion.Actividad = "Crear";
            accion.Fecha = DateTime.Now;
            accion.Descripcion = "Se creo una nueva nota con nombre: " + NuevaNota.nota.Titulo;
            AdministradorArchivos.GuardarAccion(accion);
            if (!notaNueva.Privacidad) MostrarNotaEnPantalla(notaNueva);


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
                            if(c is RichTextBox)
                            {
                                ((RichTextBox)c).Name = item.Name;
                                ((RichTextBox)c).Text = item.Name;
                            }
                        }
                    }
                }
                Accion accion = new Accion();
                accion.Objeto = "NOTA";
                accion.NombreUsuario = CuadernosInicio.usuarioActual.nombre;
                accion.Actividad = "Editar";
                accion.Fecha = DateTime.Now;
                accion.Descripcion = "Se creo edito nota con nombre: " + notaNueva.Titulo;
                AdministradorArchivos.GuardarAccion(accion);
                Inicio.CuadernoSeleccionado.ModificarNota(numeroNota, notaNueva);
            }
        }

        private void MostrarNotaEnPantalla(Nota nota)
        {
            Panel panel = new Panel();
            Label nombreCuaderno = new Label();
            RichTextBox nombre = new RichTextBox();
            panel.BackColor = nota.Color;
            panel.Margin = new Padding(15);
            panel.Size = new Size(355, 45);
            panel.TabIndex = 9;
            panel.Name = nota.Titulo;
            nombre.Size = new Size(335, 20);
            nombre.Name = nota.Titulo;
            nombre.Text =" " + nota.Titulo;
            nombre.Location = new Point(10, 12);
            nombre.Font = new Font("NewsGoth BT", 12F);
            nombre.ReadOnly = true;
            nombre.BorderStyle = BorderStyle.None;
            nombre.BackColor = nota.Color;
            if (buscando)
            {
                nombre.SelectionStart = nombre.Find(buscarCuadernoTextBox.Text);
                nombre.SelectionLength = (buscarCuadernoTextBox.Text).Length;
                nombre.SelectionFont = new Font("NewsGoth BT", 12F, FontStyle.Bold);
            }
            nombre.Enabled = false;
            panel.Controls.Add(nombre);
            panel.MouseClick += new MouseEventHandler(this.NotaSeleccionada_MouseClick);
            notasContainer.Controls.Add(panel);
            
        }

        private void cargarNotas(List<Nota> notas, bool mostrarOcultas)
        {
            if (notas!=null)
            {
               // ActualListaEnPantalla = notas;
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
            error.SetError(filtroComboBox, "");
            if (buscarCuadernoTextBox.Text.Length != 0 && filtroComboBox.SelectedItem!=null)
            {
                verOcultasButton.Visible = false;
                List<Nota> notasBusqueda = new List<Nota>();
                List<Nota> notasDondeBuscar = new List<Nota>();
                buscando = true;


                if (buscandoOcultas)
                {
                    notasDondeBuscar = cuadernoPadre.getNotasOcultas();
                }
                else
                {
                    notasDondeBuscar = cuadernoPadre.getListaDeNotas();
                }

                foreach (Nota nota in cuadernoPadre.getListaDeNotas())
                {
                    if (filtroComboBox.SelectedItem.ToString() == "NOMBRE")
                    {
                        if (nota.Titulo.Contains(buscarCuadernoTextBox.Text))
                        {
                            if (nota.Titulo == buscarCuadernoTextBox.Text)
                            {
                                notasBusqueda.Insert(0, nota);
                            }
                            else
                            {
                                notasBusqueda.Add(nota);
                            }
                        }
                    }
                    else if (filtroComboBox.SelectedItem.ToString() == "CATEGORIA")
                    {
                        if(nota.Categoria == buscarCuadernoTextBox.Text)
                        {
                            notasBusqueda.Add(nota);
                        }
                    }

                }
                if (notasBusqueda != null)
                {
                    notasContainer.Controls.Clear();
                    cargarNotas(notasBusqueda, buscandoOcultas);
                    nuevaNotaButton.Visible = false;
                    verNotasButton.Visible = false;
                    verNotasButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("No hay resultados de su busqueda", "Informacion");
                }
                Accion accion = new Accion();
                accion.Objeto = "NOTA";
                accion.NombreUsuario = CuadernosInicio.usuarioActual.nombre;
                accion.Actividad = "Buscar";
                accion.Fecha = DateTime.Now;
                accion.Descripcion = "Se buscaron notas con " + filtroComboBox.SelectedItem.ToString() + " " + buscarCuadernoTextBox.Text;
                AdministradorArchivos.GuardarAccion(accion);


            }
            else if (filtroComboBox.SelectedItem == null)
            {
                
                error.SetError(filtroComboBox, "Debe seleccionar un filtro");
            }
            else if (buscarCuadernoTextBox.Text.Length == 0)
            {
                
                error.SetError(filtroComboBox, "Debe ingresar lo que desea buscar");
            }


        }

        private void VerNotasButton_Click(object sender, EventArgs e)
        {
            buscandoOcultas = false;
            notasContainer.Controls.Clear();
            verNotasButton.Visible = false;
            cancelarButton.Visible = false;
            nuevaNotaButton.Visible = true;
            verOcultasButton.Visible = true;
            buscando = false;
            buscarCuadernoTextBox.Text = "";
            cargarNotas(cuadernoPadre.getListaDeNotas(),false);
            sePuedeEditarNota = true;
        }

        private void VerOcultasButton_Click(object sender, EventArgs e)
        {
            List<Nota> notasOcultas = new List<Nota>();
            buscandoOcultas = true;
            notasOcultas = cuadernoPadre.getNotasOcultas();

            if (notasOcultas != null)
            {
                Ingresar ingresar = new Ingresar();
                ingresar.usuarioActual = CuadernosInicio.usuarioActual;
                ingresar.ShowDialog();
                if (ingresar.resultado == DialogResult.Yes)
                {
                    notasContainer.Controls.Clear();
                    nuevaNotaButton.Visible = false;
                    verOcultasButton.Visible = false;
                    verNotasButton.Visible = true;
                    cargarNotas(notasOcultas, true);
                    Accion accion = new Accion();
                    accion.Objeto = "CUADERNO";
                    accion.NombreUsuario = CuadernosInicio.usuarioActual.nombre;
                    accion.Actividad = "Ver Notas Ocultas";
                    accion.Fecha = DateTime.Now;
                    accion.Descripcion = "Se vieron las notas ocultas del cuaderno " + cuadernoPadre.Nombre;
                    AdministradorArchivos.GuardarAccion(accion);

                }
                
            }

            

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            cuadernoPadre.EliminarNota(notaSeleccionada);
            Accion accion = new Accion();
            accion.Objeto = "NOTA";
            accion.NombreUsuario = CuadernosInicio.usuarioActual.nombre;
            accion.Actividad = "Eliminar";
            accion.Fecha = DateTime.Now;
            accion.Descripcion = "Se creo elimino nota con nombre: " + notaSeleccionada.Titulo;
            AdministradorArchivos.GuardarAccion(accion);
            VerNotasButton_Click(sender, e);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            VerNotasButton_Click(sender, e);
        }

        private void NotasMenu_Load(object sender, EventArgs e)
        {

            foreach (Categoria c in cuadernoPadre.getListaDeCategorias())
            {
                Label categoriaLabel = new Label();
                categoriaLabel.AutoSize = true;
                categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                categoriaLabel.Location = new System.Drawing.Point(10, 10);
                categoriaLabel.Margin = new System.Windows.Forms.Padding(10);
                categoriaLabel.Name = "ejemploLabel";
                categoriaLabel.Size = new System.Drawing.Size(29, 20);
                categoriaLabel.TabIndex = 0;
                categoriaLabel.ForeColor = Color.White;
                categoriaLabel.BackColor = Color.Green;
                categoriaLabel.Text = "#"+c.Nombre;
                categoriasPanel.Controls.Add(categoriaLabel);
            }
        }
    }
}

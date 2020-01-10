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
    public partial class Inicio : Form
    {
        public List <Cuaderno> cuadernos;
        public static Cuaderno CuadernoSeleccionado;
        private PictureBox picSelected;
        private PictureBox picSelectedAux;
        private bool sePuedenVerNotas;
        private bool buscando;
        ErrorProvider error ;

        public Inicio()
        {
            InitializeComponent();
            cuadernos = new List<Cuaderno>();
            picSelectedAux = new PictureBox();
            sePuedenVerNotas = true;
            error = new ErrorProvider();
        }

        public void CuadernoPictureBox_Click(object sender, EventArgs e)
        {
            getPicYCuadernoSeleccionado(sender, e);
            if(picSelected!= picSelectedAux)
            {
                picSelectedAux.BorderStyle = BorderStyle.None;
            }
            picSelected.BorderStyle = BorderStyle.FixedSingle;
            picSelected.BackColor = Color.DeepSkyBlue;
            picSelectedAux = picSelected;
            nuevoCuadernoButton.Visible = false;
            eliminarButton.Visible = true;
            atrasButton.Visible = true;
            sePuedenVerNotas = false;
        }
        private void getPicYCuadernoSeleccionado(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            picSelected = new PictureBox();
            picSelected = pic;
            foreach (Cuaderno cuaderno in cuadernos)
            {
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
                }
            }
        }
        public void CuadernoPicture_DoubleClick(object sender, EventArgs e)
        {
            if (sePuedenVerNotas)
            {
                getPicYCuadernoSeleccionado(sender, e);
                AbrirForm<NotasMenu>();
            }

        }

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = inicioPanel.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                inicioPanel.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void NuevoCuadernoButton_Click(object sender, EventArgs e)
        {

            NuevoCuaderno nuevoCuaderno = new NuevoCuaderno();
            nuevoCuaderno.ShowDialog();

            if (nuevoCuaderno.cuadernoCreado == DialogResult.Yes)
            {
                MostrarCuadernoEnPantalla(NuevoCuaderno.cuaderno);
                NuevoCuaderno.cuaderno.Orden = CuadernosInicio.usuarioActual.cuadernos.Count;
                cuadernos.Add(NuevoCuaderno.cuaderno);
                CuadernosInicio.usuarioActual.AgregarCuaderno(NuevoCuaderno.cuaderno);
            }
           
        }

        private void MostrarCuadernoEnPantalla(Cuaderno cuaderno)
        {
            UCCuadernoDigital cuadernoDigital = new UCCuadernoDigital(this);
          //  cuadernoDigital.nombreDeCuaderno = cuaderno.Nombre;
            cuadernoDigital.picture = cuaderno.Imagen;
            cuadernoDigital.namePicture = cuaderno.Nombre;
            cuadernoDigital.nombreCuadernoRich.Text = cuaderno.Nombre;
            cuadernoDigital.nombreCuadernoRich.SelectionAlignment = HorizontalAlignment.Center;
            cuadernoDigital.nombreCuadernoRich.Visible = true;
            if (buscando)
            {
                cuadernoDigital.nombreCuadernoRich.SelectionStart = cuadernoDigital.nombreCuadernoRich.Find(buscarTextBox.Text);
                cuadernoDigital.nombreCuadernoRich.SelectionLength = (buscarTextBox.Text).Length;
                cuadernoDigital.nombreCuadernoRich.SelectionFont = new Font("NewsGoth BT", 12F, FontStyle.Bold);
            }
            cuadernosContainer.Controls.Add(cuadernoDigital);
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            if (buscando)
            {
                buscarTextBox.Text = "";
                nuevoCuadernoButton.Visible = true;
                eliminarButton.Visible = false;
                atrasButton.Visible = false;
                buscando = false;
                cuadernosContainer.Controls.Clear();
                cargarCuadernos(cuadernos);
            }
            else
            {
                picSelected.BorderStyle = BorderStyle.None;
                picSelected.BackColor = Color.White;
                nuevoCuadernoButton.Visible = true;
                eliminarButton.Visible = false;
                atrasButton.Visible = false;
                picSelected = null;
                sePuedenVerNotas = true;
            }
        }

        private void cargarCuadernos(List<Cuaderno> listCuadernos)
        {
            foreach(Cuaderno item in listCuadernos)
            {
                MostrarCuadernoEnPantalla(item);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            DialogResult resultado =  MessageBox.Show("¿Esta seguro de querer eliminar el cuaderno: "+CuadernoSeleccionado.Nombre+"?", "Alerta",MessageBoxButtons.YesNoCancel);
            if(resultado == DialogResult.Yes)
            {
                cuadernos.Remove(CuadernoSeleccionado);
                cuadernosContainer.Controls.Clear();
                cargarCuadernos(cuadernos);
                AtrasButton_Click(sender, e);
            }
        }

        private void BuscaNotaButton_Click(object sender, EventArgs e)
        {
            error.SetError(filtroComboBox, "");
            if (buscarTextBox.Text.Length != 0 && !(filtroComboBox.SelectedItem==null))
            {
                buscando = true;
                List<Cuaderno> cuadernos1 = new List<Cuaderno>();
                foreach (Cuaderno c in cuadernos)
                {
                    if (c.Nombre.Contains(buscarTextBox.Text) && filtroComboBox.SelectedItem.ToString() == "NOMBRE")
                    {
                        if (c.Nombre == buscarTextBox.Text)
                        {
                            cuadernos1.Insert(0, c);
                        }
                        else
                        {
                            cuadernos1.Add(c);
                        }
                    }
                    else if (filtroComboBox.SelectedItem.ToString() == "CATEGORIA")
                    {
                        foreach (Categoria categoria in c.getListaDeCategorias())
                        {
                            if (categoria.Nombre == buscarTextBox.Text)
                            {
                                cuadernos1.Add(c);
                            }
                        }
                    }

                }

                if (cuadernos1.Count!=0)
                {
                    cuadernosContainer.Controls.Clear();
                    cargarCuadernos(cuadernos1);
                    nuevoCuadernoButton.Visible = false;
                    atrasButton.Visible = true;
                }
                else 
                {
                    MessageBox.Show("No hay resultados de su busqueda", "Informacion");
                }
            }
            else if(filtroComboBox.SelectedItem == null)
            {
                error.SetError(filtroComboBox, "Debe seleccionar un filtro");
            }else if (buscarCuadernoTextBox.Text.Length == 0)
            {
                error.SetError(filtroComboBox, "Debe ingresar lo que desea buscar");
            }
               
        }

    }
}

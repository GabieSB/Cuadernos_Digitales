﻿using System;
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
    public partial class Cuadernos : Form
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
        public int IndiceCuaderno
        {
            get;
            set;
        }

        public List <Cuaderno> cuadernos;
        public static Cuaderno CuadernoSeleccionado;
        private PictureBox picSelected;
        private PictureBox picSelectedAux;
        private bool sePuedenVerNotas;
        private bool buscando;

        public Cuadernos()
        {
            InitializeComponent();
            cuadernos = new List<Cuaderno>();
            picSelectedAux = new PictureBox();
            sePuedenVerNotas = true;
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
            for (int i = 0; i < cuadernos.Count; i++)
            {
                Cuaderno cuaderno = cuadernos[i];
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
                    IndiceCuaderno = i;
                }
            }
/*            foreach (Cuaderno cuaderno in cuadernos)
            {
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
                }
            }*/
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
            nuevoCuaderno.Usuarios = Usuarios;
            nuevoCuaderno.IndiceUsuario = IndiceUsuario;

            nuevoCuaderno.ShowDialog();

            if (nuevoCuaderno.cuadernoCreado == DialogResult.Yes)
            {
                MostrarCuadernoEnPantalla(NuevoCuaderno.cuaderno);
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de crear nuevo cuaderno", $"El usuario {Usuarios[IndiceUsuario].Nombre} creo un nuevo cuaderno", "Nuevo Cuaderno", cuadernos.Count);
                CrearHistorialCreacionCuaderno(archivoManager);

                cuadernos.Add(NuevoCuaderno.cuaderno);
            }
           
        }

        private void MostrarCuadernoEnPantalla(Cuaderno cuaderno)
        {
            UCCuadernoDigital cuadernoDigital = new UCCuadernoDigital(this);
            cuadernoDigital.nombreDeCuaderno = cuaderno.Nombre;
            cuadernoDigital.picture = cuaderno.Imagen;
            cuadernoDigital.namePicture = cuaderno.Nombre;
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
                ArchivoManager archivoManager = new ArchivoManager();
                CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Eliminar Cuaderno", $"El usuario {Usuarios[IndiceUsuario].Nombre} elimino un cuaderno.", "Cuaderno", IndiceCuaderno);
                CrearHistorialVisitaFormulario(archivoManager);

                cuadernos.Remove(CuadernoSeleccionado);
                cuadernosContainer.Controls.Clear();
                cargarCuadernos(cuadernos);
                AtrasButton_Click(sender, e);
            }
        }

        private void BuscaNotaButton_Click(object sender, EventArgs e)
        {
            buscando = true;
            foreach(Cuaderno c in cuadernos)
            {
                if(c.Nombre == buscarTextBox.Text)
                {
                    cuadernosContainer.Controls.Clear();
                    MostrarCuadernoEnPantalla(c);
                    nuevoCuadernoButton.Visible = false;
                    atrasButton.Visible=true;
                }
            }
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Se hizo una búsqueda", $"El usuario {Usuarios[IndiceUsuario].Nombre} hizo una búsqueda de una o varias notas.", "Inicio", 0);
            CrearHistorialBusqueda(archivoManager);
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CrearHistorialBusqueda(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearHistorialBusquedaObjeto(rutaPorDefecto);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se produjo el siguiente error: {exception}");
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
                MessageBox.Show($"Se produjo el siguiente error: {exception}");
            }
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
        private void Cuadernos_Load(object sender, EventArgs e)
        {
            ArchivoManager archivoManager = new ArchivoManager();
            CargarInformacionActividadUsuario(archivoManager, "Presionar el boton de Inicio", $"El usuario {Usuarios[IndiceUsuario].Nombre} ingreso al formulario de Inicio", "Inicio", 0);
            CrearHistorialVisitaFormulario(archivoManager);
        }
    }
}
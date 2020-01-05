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
        int columasCont ;
        int filasCont;
        
        public Inicio()
        {
            InitializeComponent();
            columasCont = 0;
            List<PictureBox> picturesBooks = new List<PictureBox>();
            cuadernos = new List<Cuaderno>();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        public void CuadernoPicture_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            foreach(Cuaderno cuaderno in cuadernos)
            {
                if (pic.Name == cuaderno.Nombre)
                {
                    CuadernoSeleccionado = new Cuaderno();
                    CuadernoSeleccionado = cuaderno;
                }
            }
            AbrirForm<NotasMenu>();
           
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
                cuadernos.Add(NuevoCuaderno.cuaderno);
            }
           
        }

        private void MostrarCuadernoEnPantalla(Cuaderno cuaderno)
        {
            UCCuadernoDigital cuadernoDigital = new UCCuadernoDigital(this);
            cuadernoDigital.nombreDeCuaderno = cuaderno.Nombre;
            cuadernoDigital.picture = NuevoCuaderno.colorSeleccionado; 
            cuadernoDigital.namePicture = cuaderno.Nombre;
            cuadernosContainer.Controls.Add(cuadernoDigital);
        }
       
    }
}

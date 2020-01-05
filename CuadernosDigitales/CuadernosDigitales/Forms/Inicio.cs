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
          //  nuevoCuaderno.TopLevel = false;
           // nuevoCuaderno.AutoScroll = true;
           // panel.Controls.Add(nuevoCuaderno);
            nuevoCuaderno.ShowDialog();

            if (nuevoCuaderno.cuadernoCreado == DialogResult.Yes)
            {
                //poner imagenes en 
                //if (columasCont == 4)
                //{
                //    filasCont++;
                //    columasCont = 0;
                //}
                //int x = 40 + (columasCont * 100 + columasCont * 60);
                //int y = 100 + 100 * filasCont + filasCont * 60;

                //PictureBox pictureBox = new PictureBox();
                //pictureBox.Image = NuevoCuaderno.colorSeleccionado;
                //pictureBox.Location = new Point(x, y);
                //pictureBox.Name = NuevoCuaderno.cuaderno.Nombre;
                //pictureBox.Size = new System.Drawing.Size(100, 110);
                //pictureBox.Click += new EventHandler(this.CuadernoPicture_Click);
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

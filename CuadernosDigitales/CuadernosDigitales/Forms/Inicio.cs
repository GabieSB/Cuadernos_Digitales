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
        List <PictureBox> picturesBooks;
        int columasCont ;
        int filasCont;
        
        public Inicio()
        {
            InitializeComponent();
            columasCont = 0;
            List<PictureBox> picturesBooks = new List<PictureBox>();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void NuevoCuadernoButton_Click(object sender, EventArgs e)
        {
            if (columasCont == 4)
            {
                filasCont++;
                columasCont = 0;
            }
            int x = 40 + (columasCont * 100 + columasCont * 60);
            int y = 100 + 100 * filasCont + filasCont*60;
            

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = global::CuadernosDigitales.Properties.Resources.azul;
            pictureBox.Location = new Point(x, y);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(100, 110);
            inicioPaneL.Controls.Add(pictureBox);
            columasCont++;

        }
    }
}

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
    public partial class NotasOcultas : Form
    {
        public Usuario Usuario
        {
            get;
            set;
        }
        public NotasOcultas()
        {
            InitializeComponent();
            Usuario = new Usuario();
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3)
            {
                ErrorProviderContraseña.SetError(TextBoxContraseña, "Ingrese la contraseña del usuario");
            }
            else
            {
                Usuario.Contraseña = TextBoxContraseña.Text;
            }
        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            if (CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Contraseña == Usuario.Contraseña)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ErrorProviderContraseña.SetError(TextBoxContraseña, "La contraseña del usuario esta incorrecta");
            }
        }

        private void NotasOcultas_Load(object sender, EventArgs e)
        {
            TextBoxUsuario.Text = CuadernosInicio.UsuariosEstaticos[CuadernosInicio.IndiceUsuarioEstatico].Nombre;
        }
    }
}

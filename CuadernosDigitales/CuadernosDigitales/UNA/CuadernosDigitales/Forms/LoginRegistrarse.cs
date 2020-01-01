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

namespace CuadernosDigitales.Forms
{
    public partial class LoginRegistrarse : Form
    {
        public List<Usuario> Usuarios
        {
            get;
            set;
        }
        public Usuario Usuario
        {
            get;
            set;
        }
        public LoginRegistrarse()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
            Usuario = new Usuario();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            this.Close();  
        }


        private void CabezaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            if(Usuario.Nombre.Length > 2)
            {
                Usuarios.Add(Usuario);
                DialogResult dialogResult = MessageBox.Show("Se registro el nuevo usuario exitosamente");
                this.Close();
            }
        }

        private void TextBoxUsuario_Leave(object sender, EventArgs e)
        {
            Boolean sinErrores = true;
            if (TextBoxUsuario.TextLength < 3)
            {
                errorProviderLogin.SetError(TextBoxUsuario, "Ingrese el nombre del usuario");
            }
            else
            {
                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if(Usuarios[i].Nombre == TextBoxUsuario.Text)
                    {
                        errorProviderLogin.SetError(TextBoxUsuario, "El nombre de usuario ya existe, escoja otro");
                        sinErrores = false;
                    }
                }
                if (sinErrores)
                {
                    Usuario.Nombre = TextBoxUsuario.Text;
                }
            }
        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxContraseña.TextLength < 3)
            {
                errorProviderContraseña.SetError(TextBoxContraseña, "Ingrese la nueva contraseña del Usuario");
            }
            else
            {
                Usuario.Contraseña = TextBoxContraseña.Text;
            }
        }

        private void TextBoxRepetirContraseña_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepetirContraseña.TextLength < 3)
            {
                errorProviderRepetirContraseña.SetError(TextBoxRepetirContraseña, "Repita la nueva contraseña del Usuario");
            }
            else
            {
                if(Usuario.Contraseña == TextBoxRepetirContraseña.Text)
                {
                    Usuario.Identificador = Usuarios.Count;
                }
            }
        }
    }
}

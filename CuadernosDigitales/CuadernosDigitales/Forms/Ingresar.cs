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
    public partial class Ingresar : Form
    {
        private readonly string userPassword = "El20Examen20Estaba20Faci20";
        public static string nombreUser;
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        private AdministradorArchivos administrador;
        public  Usuario usuarioActual;
        public  DialogResult resultado;
        public Ingresar()
        {
            InitializeComponent();
            administrador = new AdministradorArchivos();

           
           
        }
        
        private void ComprobarUsuario()
        {
            yaTienesCuenta.Visible = false;
            noTieneCuentaLinkLabel.Visible = false;
            usuarioTextBox.Text = usuarioActual.nombre;
            usuarioTextBox.Enabled = false;
        }
        private void IngresarButton_Click(object sender, EventArgs e)
        {
            bool usuarioEncontrado = false ;
            errorProvider.SetError(usuarioTextBox, "");
            errorProvider.SetError(contrasenaTextBox, "");

            if (usuarioActual != null)
            {
               // passDecencriptada = Encriptacion.DesencriptarString(usuarioActual.contrasena, userPassword);
                if (contrasenaTextBox.Text == usuarioActual.contrasena && usuarioTextBox.Text == usuarioActual.nombre)
                {
                    resultado = new DialogResult();
                    resultado = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(contrasenaTextBox, "Contraseña Incorrecta");
                }
            }
            else
            {
                foreach (Usuario usuario in administrador.getUsuariosRegistrados())
                {
                   // passDecencriptada = Encriptacion.DesencriptarString(usuario.contrasena, userPassword);
                    if (contrasenaTextBox.Text == usuario.contrasena && usuarioTextBox.Text == usuario.nombre)
                    {
                        CuadernosInicio.usuarioActual = new Usuario();
                        CuadernosInicio.usuarioActual = usuario;
                        this.Close();
                        usuarioEncontrado = true;

                    }
                    else if (usuarioTextBox.Text == usuario.nombre && contrasenaTextBox.Text != usuario.contrasena)
                    {
                        usuarioEncontrado = true;
                        errorProvider.SetError(contrasenaTextBox, "Contraseña Incorrecta");
                    }

                }

                if (!usuarioEncontrado)
                {
                    errorProvider.SetError(usuarioTextBox, "Usuario no registrado");
                }

            }
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoTieneCuentaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ingresarButton.Visible = false;
            registrarButton.Visible = true;
            yaTienesCuenta.Visible = true;
            noTieneCuentaLinkLabel.Visible = false;
            errorProvider.SetError(usuarioTextBox, "");
            errorProvider.SetError(contrasenaTextBox, "");

        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(usuarioTextBox, "");
           
            bool registrar = true;
            
            foreach(Usuario usuario1 in administrador.getUsuariosRegistrados())
            {
                if(usuario1.nombre == usuarioTextBox.Text)
                {
                    errorProvider.SetError(usuarioTextBox, "Usuario Registrado");
                    registrar = false;
                    
                }
            }

            if (registrar){
                Usuario usuario = new Usuario();
                usuario.nombre = usuarioTextBox.Text;
                string passEncriptada = Encriptacion.EncriptarString(contrasenaTextBox.Text, userPassword);
                usuario.contrasena = passEncriptada;
                try
                {
                    administrador.GuardarUsuario(rutaPorDefecto, usuario);
                    MessageBox.Show($"El usuario {usuarioTextBox.Text} se registro satisfactoriamente. Inicie sesion para comenzar", "Excelente!", MessageBoxButtons.OK);
                    registrarButton.Visible = false;
                    noTieneCuentaLinkLabel.Visible = true;
                    ingresarButton.Visible = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Se ha presentado el siguiente inconveniente al escribir el archivo: {exception.Message}", "Atención", MessageBoxButtons.OK);
                }
            }
            
        }

        private void YaTienesUnaCuentaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ingresarButton.Visible = true;
            registrarButton.Visible = false;
            noTieneCuentaLinkLabel.Visible = true;
            yaTienesCuenta.Visible = false;
            errorProvider.SetError(usuarioTextBox, "");
            errorProvider.SetError(contrasenaTextBox, "");
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                ComprobarUsuario();
            }
        }
    }
}

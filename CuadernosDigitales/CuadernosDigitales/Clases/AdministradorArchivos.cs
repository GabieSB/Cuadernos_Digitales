using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadernosDigitales.Clases
{
    class AdministradorArchivos
    {
        public List<Usuario> usuarios { get; set; }
        public List<Accion> acciones { get; set; }
        string pathUsuarios;
        private readonly string userPassword = "El20Examen20Estaba20Faci20";
        public AdministradorArchivos()
        {
            usuarios = new List<Usuario>();
            acciones = new List<Accion>();
            pathUsuarios = "usuarios.csv";
        }
        public void GuardarUsuario(string rutaBase, Usuario usuario)
        {
            StreamWriter writer = File.AppendText(@pathUsuarios);
            var line = $"{usuario.nombre},{usuario.contrasena}";
            writer.WriteLine(line);
            writer.Close();
        }
        public static void GuardarAccion(Accion accion)
        {
            StreamWriter writer = File.AppendText(accion.NombreUsuario + ".csv");
            var line = $"{accion.NombreUsuario},{accion.Objeto},{accion.Actividad}, {accion.Fecha}, {accion.Descripcion}";
            writer.WriteLine(line);
            writer.Close();
        }
        public List<Usuario> getUsuariosRegistrados()
        {
            List<string[]> listUserString = new List<string[]>();
            using (StreamReader reader = new StreamReader(pathUsuarios))
            {
                string line;
                string[] row;

                while((line = reader.ReadLine()) != null)
                {
                    row = line.Split(',');
                    listUserString.Add(row);
                }
            }

            foreach(string[] user in listUserString)
            {
                Usuario usuario = new Usuario();
                usuario.nombre = user[0];
                usuario.contrasena = Encriptacion.DesencriptarString(user[1], userPassword) ;
                usuarios.Add(usuario);
            }
            return usuarios;
        }
        public  List<Accion> getAcciones(Usuario user)
        {
            List<string[]> listAccionesString = new List<string[]>();
            using (StreamReader reader = new StreamReader(user.nombre+".csv"))
            {
                string line;
                string[] row;

                while((line = reader.ReadLine()) != null)
                {
                    row = line.Split(',');
                    listAccionesString.Add(row);
                }
            }

            foreach (string[] acc in listAccionesString)
            {
                Accion accion = new Accion();
                accion.NombreUsuario = acc[0];
                accion.Objeto = acc[1];
                accion.Actividad = acc[2];
                accion.Fecha = Convert.ToDateTime(acc[3]);
                accion.Descripcion = acc[4];
                acciones.Add(accion);
            }
            return acciones;
        }
    }
}

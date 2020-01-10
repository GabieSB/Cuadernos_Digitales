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
        public string PathUsuarios
        {
            get;
            set;
        }
        public AdministradorArchivos()
        {
            PathUsuarios = "Usuarios.csv";
        }
        public void GuardarUsuario(Usuario usuario)
        {
           
            StreamWriter writer = File.AppendText(@PathUsuarios);
            var line = $"{usuario.Nombre},{usuario.Contraseña},{usuario.Identificador}";
            writer.WriteLine(line);
            writer.Close();


            //using (StreamWriter streamWriter = new StreamWriter(pathUsuarios))
            //{
            //    var line = $"{usuario.nombre},{usuario.contrasena}";
            //    streamWriter.WriteLine(line);
            //    streamWriter.Flush();
            //    return pathUsuarios;
            //}
        }
        public List<Usuario> getUsuariosRegistrados()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string path = "Usuarios.csv";

            using (StreamReader readerFile = new StreamReader(path))
            {
                string linea;
                string[] renglon;

                while ((linea = readerFile.ReadLine()) != null)
                {
                    renglon = linea.Split(',');

                    //try
                    //{
                    Usuario usuarioRecuperado = new Usuario
                    {
                        Nombre = renglon[0],
                        Contraseña = renglon[1],
                        Identificador = Convert.ToInt32(renglon[2])
                    };
                    usuarios.Add(usuarioRecuperado);
                    //}
                    //catch(Exception)
                    //{

                    //}
                }
            }
            /*    List<string[]> listUserString = new List<string[]>();
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
                    usuario.Nombre = user[0];
                    usuario.Contraseña = user[1];
                    usuario.Identificador = Convert.ToInt32(user[2]);
                    usuarios.Add(usuario);
                }*/
            return usuarios;
        }

        public void EditarUsuarios(List<Usuario> UsuariosSistema, string rutaBase)
        {
            string path = "Usuarios.csv";
            path = path.Replace("/", "_");
            path = path.Replace(":", "_");
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (Usuario usuarioActual in UsuariosSistema)
                {
                    var line = $"{usuarioActual.Nombre},{usuarioActual.Contraseña},{usuarioActual.Identificador}";
                    streamWriter.WriteLine(line);
                }
                streamWriter.Flush();
            }
        }
    }
}

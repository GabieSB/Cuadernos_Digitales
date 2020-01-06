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
        string pathUsuarios;
        public AdministradorArchivos()
        {
            usuarios = new List<Usuario>();
            pathUsuarios = "usuarios.csv";
        }
        public void GuardarUsuario(string rutaBase, Usuario usuario)
        {
           
            StreamWriter writer = File.AppendText(@pathUsuarios);
            var line = $"{usuario.nombre},{usuario.contrasena}";
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
                usuario.contrasena = user[1];
                usuarios.Add(usuario);
            }
            return usuarios;
        }
    }
}

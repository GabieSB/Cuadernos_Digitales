using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Usuario
    {
        public string nombre
        {
            get ;
            set;
          
        }

        public Usuario()
        {
            cuadernos = new List<Cuaderno>();
        }

        public string contrasena
        {
            get;
            set;
           
        }

        public List<Cuaderno> cuadernos
        {
            get;
            set;
        }
        public void AgregarCuaderno (Cuaderno cuaderno)
        {
            cuadernos.Add(cuaderno);
        }
    }
}
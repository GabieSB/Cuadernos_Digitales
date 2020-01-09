using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Usuario
    {
        public Usuario()
        {
            cuadernos = new List<Cuaderno>();
        }

        public string Nombre
        {
            get;
            set;
        }

        public string Contraseña
        {
            get;
            set;
        }

        public int Identificador
        {
            get;
            set;
        }
        public List<Cuaderno> cuadernos
        {
            get;
            set;
        }
        public void AgregarCuaderno(Cuaderno cuaderno)
        {
            cuadernos.Add(cuaderno);
        }
    }
}
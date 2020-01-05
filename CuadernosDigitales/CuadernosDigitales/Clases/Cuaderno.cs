using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Cuaderno
    {
        private List<Nota> notas;
        private List<Categoria> categorias;

        public Cuaderno()
        {
            notas = new List<Nota>();
            categorias = new List<Categoria>();
        }

        public string Nombre
        {
            get;
            set;
        }

        public Color Color
        {
            get;
            set;
        }

        public int Orden
        {
            get;
            set;
        }

        public void agregarCategoria(Categoria cat)
        {
            categorias.Add(cat);
        }

        public void agregarNota(Nota not)
        {
            notas.Add(not);
        }

        public List<Categoria> getListaDeCategorias()
        {
            return categorias;
        }
        public List<Nota> getListaDeNotas()
        {
            return notas;
        }
    }
}
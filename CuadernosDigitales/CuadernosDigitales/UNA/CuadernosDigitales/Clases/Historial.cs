using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CuadernosDigitales
{
    public class Historial
    {
        public Historial()
        {

        }

        public Historial(DateTime fechaYHora, String usuario, String accion, String informacionAdicional, string formulario, int objeto)
        {
            FechaYHora = fechaYHora;
            Usuario = usuario;
            Accion = accion;
            InformacionAdicional = informacionAdicional;
            Objeto = objeto;
            Formulario = formulario;
        }
        public DateTime FechaYHora
        {
            get;
            set;
        }

        public string Usuario
        {
            get;
            set;
        }

        public string Accion
        {
            get;
            set;
        }

        public int Objeto
        {
            get;
            set;
        }

        public String InformacionAdicional
        {
            get;
            set;
        }
        public String Formulario
        {
            get;
            set;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca;
namespace BibliotecaControlador
{
    public class DaoPersona
    {
        static List<Persona> listado;
        public DaoPersona()
        {
            if (listado==null)
            {
                listado = new List<Persona>();
            }
            
        }
        public bool Grabar(Persona p) {
            listado.Add(p);
            return true;
        }
    }
}

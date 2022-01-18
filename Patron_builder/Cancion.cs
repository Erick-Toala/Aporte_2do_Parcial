using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_builder
{
    public class Cancion
    {
        private String nombreCancion;
        private int duracionSegundos;

        public Cancion(String nombreCancion, int duracionSegundos)
        {
            this.nombreCancion = nombreCancion;
            this.duracionSegundos = duracionSegundos;
        }

        public String NombreCancion
        {
            get { return nombreCancion; }
            set { nombreCancion = value; }
        }

        public int DuracionSegundos
        {
            get { return duracionSegundos; }
            set { duracionSegundos = value; }
        }

    }
}

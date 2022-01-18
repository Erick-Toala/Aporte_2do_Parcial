using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_builder
{
    public class Genero
    {
        private String descripcionGenero;

        public Genero(String descripcionGenero)
        {
            this.descripcionGenero = descripcionGenero;
        }

        public String DescripcionGenero
        {
            get { return descripcionGenero; }
            set { descripcionGenero = value; }
        }
    }
}
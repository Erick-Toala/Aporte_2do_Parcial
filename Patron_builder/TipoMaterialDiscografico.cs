using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_builder
{
    public class TipoMaterialDiscografico
    {
        private String nombreTipoMaterialDiscografico;

        public TipoMaterialDiscografico(String nombreTipoMaterialDiscografico)
        {
            this.nombreTipoMaterialDiscografico = nombreTipoMaterialDiscografico;
        }

        public String NombreTipoMaterialDiscografico
        {
            get { return nombreTipoMaterialDiscografico; }
            set { nombreTipoMaterialDiscografico = value; }
        }
    }
}
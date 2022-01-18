using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_builder
{
    public interface IMaterialDiscograficoBuilder
    {
        MaterialDiscograficoBuilder ConNombre(String nombre);
        MaterialDiscograficoBuilder TienePrecio(Double precio);
        MaterialDiscograficoBuilder EnStock(int stock);

        MaterialDiscograficoBuilder ComoGenero(Genero genero);
        MaterialDiscograficoBuilder ComoAutor(Autor autor);
        MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico);
        MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones);
    }
}
using System;
using System.Collections.Generic;

namespace Patron_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //MENÚ
            Console.Clear();
            Console.WriteLine("                 ULEAM ECUADOR");
            Console.WriteLine("        Facultad de Ciencias Informaticas");
            Console.WriteLine("        Discografica de la Universidad");
            Console.WriteLine("            Manta - Manabí - Ecuador\n");
            Console.WriteLine("          Fecha: " + DateTime.Now+ "\n");
            int numeroDeCancion = 1;

            // MATERIAL DISCOGRAFICO
            String nombre;
            Double precio;
            int stock;

            // AUTOR
            Autor autor;
            String nombreArtista;
            String descripcionArtista;

            // GENERO
            Genero genero;
            String descripcionGenero;

            // TIPO MATERIAL DISCOGRAFICO
            TipoMaterialDiscografico tipoMaterialDiscografico;
            String nombreMaterialDiscografico;

            // CANCIONES
            List<Cancion> canciones = new List<Cancion>();
            Cancion cancion;
            String nombreCancion;
            int duracionSegundos;

            char respuesta;

            // MATERIAL DISCOGRAFICO
            Console.Write("Ingrese el nombre del nuevo material: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del nuevo material: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el stock del nuevo material: ");
            stock = Convert.ToInt32(Console.ReadLine());

            // AUTOR
            Console.Write("Ingrese el nombre del artista: ");
            nombreArtista = Console.ReadLine();
            Console.Write("Ingrese descripcion del artista: ");
            descripcionArtista = Console.ReadLine();
            autor = new Autor(nombreArtista, descripcionArtista);

            // GENERO
            Console.Write("Ingrese el nombre del genero: ");
            descripcionGenero = Console.ReadLine();
            genero = new Genero(descripcionGenero);

            // TIPO MATERIAL DISCOGRAFICO
            Console.Write("Ingrese el nombre del tipo de material discografico: ");
            nombreMaterialDiscografico = Console.ReadLine();
            tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);

            //AGREGAMOS TODAS LAS CANCIONES EN UNA LISTA
            do
            {
                // CANCIONES
                Console.WriteLine("\nCancion " + numeroDeCancion.ToString());
                Console.Write("Ingrese el nombre de la canción: ");
                nombreCancion = Console.ReadLine();
                Console.Write("Ingrese la duracion de la cancion en segundos: ");
                duracionSegundos = Convert.ToInt32(Console.ReadLine());

                cancion = new Cancion(nombreCancion, duracionSegundos);
                canciones.Add(cancion);

                numeroDeCancion++;

                Console.Write("Desea seguir agregando canciones? (S/N): ");
                respuesta = Console.ReadKey().KeyChar;
                Console.ReadKey();

            } while (respuesta == 'S');

            Console.Clear();

            //INSTANCIAMOS LOS DATOS BUILDER DEL MATERIAL DISCOGRAFICO DONDE PASAMOS LOS ATRIBUTOS ANTERIORES
            MaterialDiscograficoBuilder builderMaterialDiscografico = new MaterialDiscograficoBuilder();
            MaterialDiscografico materialDiscografico = builderMaterialDiscografico
                .ConNombre(nombre)
                .TienePrecio(precio)
                .EnStock(stock)
                .ComoAutor(autor)
                .ComoCanciones(canciones)
                .ComoGenero(genero)
                .ComoTipoMaterialDiscografico(tipoMaterialDiscografico)
                //ESTE METODO NOS RETORNA LA INSTANCIA DEL OBJETO MATERIAL DISCOGRAFICO COMO LO PODEMOS VER EN LA IMPLEMENTACION DE LA INTERFAZ
                .BuildMaterialDiscografico();

            // REPORTAR
            Console.Write(materialDiscografico.reportarDatos());

            Console.ReadKey();
        }
    }
}
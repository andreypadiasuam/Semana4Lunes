using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    // Clase Inventario
    public class Inventario
    {
        private List<Libro> libros;

        public Inventario()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario de Libros:");
            foreach (Libro libro in libros)
            {
                libro.MostrarInformacion();
                Console.WriteLine("--------------------");
            }
        }

        public void RealizarVenta(Libro libro)
        {
            try
            {
                if (libros.Contains(libro))
                {
                    libro.MostrarInformacion();
                    Console.WriteLine("Venta realizada con éxito.");
                    libros.Remove(libro);
                }
                else
                {
                    throw new Exception("El libro no está en el inventario.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public Libro BuscarLibro(string tituloVenta) 
        { 
            return libros.Find(libro => libro.Titulo == tituloVenta);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    // Clase LibroImpreso heredando de Libro
    public class LibroImpreso : Libro
    {
        public int CantidadPaginas { get; set; }

        public override decimal CalcularPrecioVenta()
        {
            return Precio + (Precio * 0.13m); // 13% de impuesto
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Precio: $" + Precio);
            Console.WriteLine("Cantidad de Páginas: " + CantidadPaginas);
        }
    }
}

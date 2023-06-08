using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    // Clase LibroDigital heredando de Libro
    public class LibroDigital : Libro
    {
        public string Formato { get; set; }

        public override decimal CalcularPrecioVenta()
        {
            return Precio + (Precio * 0.05m); // 5% de recargo
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Precio: $" + Precio);
            Console.WriteLine("Formato: " + Formato);
        }
    }
}

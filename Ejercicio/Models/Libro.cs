using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Models
{
    // Clase abstracta Libro
    public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Precio { get; set; }

        public abstract decimal CalcularPrecioVenta();
        public abstract void MostrarInformacion();
    }
}

// See https://aka.ms/new-console-template for more information
using Ejercicio.Models;

Inventario inventario = new Inventario();
bool salir = false;

        while (!salir)
        {
            try
            {
                Console.WriteLine("---- Menú ----");
                Console.WriteLine("1. Agregar libro al inventario");
                Console.WriteLine("2. Mostrar inventario");
                Console.WriteLine("3. Vender libro");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                Console.WriteLine();
                 switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("---- Agregar Libro al Inventario ----");
                            Console.Write("Ingrese el título del libro: ");
                            string titulo = Console.ReadLine();
                            Console.Write("Ingrese el autor del libro: ");
                            string autor = Console.ReadLine();
                            Console.Write("Ingrese el precio del libro: ");
                            decimal precio = decimal.Parse(Console.ReadLine());
                            Console.Write("Ingrese la cantidad de páginas del libro (solo para libros impresos): ");
                            int cantidadPaginas = int.Parse(Console.ReadLine());

                            LibroImpreso nuevoLibroImpreso = new LibroImpreso()
                            {
                                Titulo = titulo,
                                Autor = autor,
                                Precio = precio,
                                CantidadPaginas = cantidadPaginas
                            };

                            inventario.AgregarLibro(nuevoLibroImpreso);
                            Console.WriteLine("Libro agregado al inventario.");
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.WriteLine("---- Inventario de Libros ----");
                            inventario.MostrarInventario();
                            Console.WriteLine();
                            break;

                        case "3":
                            Console.WriteLine("---- Vender Libro ----");
                            Console.Write("Ingrese el título del libro a vender: ");
                            string tituloVenta = Console.ReadLine();
                            Libro libroVenta = inventario.BuscarLibro(tituloVenta);

                            if (libroVenta != null)
                            {
                                inventario.RealizarVenta(libroVenta);
                            }
                            else
                            {
                                Console.WriteLine("El libro no está en el inventario.");
                            }

                            Console.WriteLine();
                            break;

                        case "4":
                            salir = true;
                            Console.WriteLine("¡Hasta luego!");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida del menú.");
                            Console.WriteLine();
                            break;
                    }
            }       
            catch (Exception e)
            {

                Console.WriteLine("Error! \n Error: {0}",  e.Message);
            }
           

            
        }


Console.ReadLine();
    

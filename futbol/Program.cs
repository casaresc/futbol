using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
namespace ControlVentasEntradas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantEntradasSol = 0, cantEntradasSombra = 0, cantEntradasPreferencial = 0;
            double acumDineroSol = 0, acumDineroSombra = 0, acumDineroPreferencial = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el número de factura (0 para terminar): ");
                string numFactura = Console.ReadLine();

                if (numFactura == "0")
                    break;

                Console.WriteLine("Ingrese la cédula del comprador: ");
                string cedula = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del comprador: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la localidad (1-Sol Norte/Sur, 2-Sombra Este/Oeste, 3-Preferencial): ");
                int localidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de entradas (máximo 4 por cliente): ");
                int cantidadEntradas = Convert.ToInt32(Console.ReadLine());

                // Validar cantidad de entradas
                if (cantidadEntradas < 1 || cantidadEntradas > 4)
                {
                    Console.WriteLine("Error: La cantidad de entradas debe ser entre 1 y 4.");
                    continue;
                }

                double precioEntrada = 0;
                string nombreLocalidad = "";

                switch (localidad)
                {
                    case 1:
                        precioEntrada = 10500;
                        nombreLocalidad = "Sol Norte/Sur";
                        cantEntradasSol += cantidadEntradas;
                        acumDineroSol += cantidadEntradas * precioEntrada;
                        break;
                    case 2:
                        precioEntrada = 20500;
                        nombreLocalidad = "Sombra Este/Oeste";
                        cantEntradasSombra += cantidadEntradas;
                        acumDineroSombra += cantidadEntradas * precioEntrada;
                        break;
                    case 3:
                        precioEntrada = 25500;
                        nombreLocalidad = "Preferencial";
                        cantEntradasPreferencial += cantidadEntradas;
                        acumDineroPreferencial += cantidadEntradas * precioEntrada;
                        break;
                    default:
                        Console.WriteLine("Localidad no válida. Por favor, ingrese 1, 2 o 3.");
                        continue;
                }

                double subtotal = cantidadEntradas * precioEntrada;
                double cargosServicios = cantidadEntradas * 1000;
                double totalPagar = subtotal + cargosServicios;

                Console.WriteLine("\nNúmero de Factura: " + numFactura);
                Console.WriteLine("Cédula: " + cedula);
                Console.WriteLine("Nombre comprador: " + nombre);
                Console.WriteLine("Localidad: " + nombreLocalidad);
                Console.WriteLine("Cantidad de Entradas: " + cantidadEntradas);
                Console.WriteLine("Subtotal: " + subtotal);
                Console.WriteLine("Cargos por Servicios: " + cargosServicios);
                Console.WriteLine("Total a pagar: " + totalPagar);
            }

            Console.WriteLine("\nEstadísticas:");
            Console.WriteLine("Cantidad Entradas Localidad Sol Norte/Sur: " + cantEntradasSol);
            Console.WriteLine("Acumulado Dinero Localidad Sol Norte/Sur: " + acumDineroSol);
            Console.WriteLine("Cantidad Entradas Localidad Sombra Este/Oeste: " + cantEntradasSombra);
            Console.WriteLine("Acumulado Dinero Localidad Sombra Este/Oeste: " + acumDineroSombra);
            Console.WriteLine("Cantidad Entradas Localidad Preferencial: " + cantEntradasPreferencial);
            Console.WriteLine("Acumulado Dinero Localidad Preferencial: " + acumDineroPreferencial);
        }
    }
}

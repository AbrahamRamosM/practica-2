using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarcion de variables

            int a = 10;
            int b = 10;
            int c = 7;

            // Operaciones

            int perimetro = a + b + c;

            // Imprimir perimetro

            System.Console.WriteLine("El perimetro del triangulo es: " + perimetro);
            System.Console.WriteLine("\n## Presiona cualquier tecla para continuar ##");
            System.Console.ReadKey();
        }
    }
}

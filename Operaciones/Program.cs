using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se pide y se declaran las variables para los 2 numeros

            Console.WriteLine("Favor de escribir el primer numero:");
            String x = Console.ReadLine();
            Console.WriteLine("Favor de escribir el segundo numero:");
            String y = Console.ReadLine();

            // Se convierten las variables y se hacen las operaciones

            Double a = Convert.ToDouble(x);
            Double b = Convert.ToDouble(y);
            Double result;

            // Se muestran los resultados con las operaciones

            Console.Clear();

            Console.WriteLine("Numero 1: " + x + "\nNumero 2: " + y + "\n");
            Console.WriteLine("- La suma es: {0}", result = a + b);
            Console.WriteLine("- La resta es: {0}", result = a - b);
            Console.WriteLine("- La multiplicacion es: {0}", result = a * b);
            Console.WriteLine("- La division es: {0}", result = a / b);
            Console.WriteLine("- El residuo es: {0}", result = a % b);

            Console.WriteLine("\n## Presione cualquier tecla para continuar ##");
            System.Console.ReadKey();
        }
    }
}

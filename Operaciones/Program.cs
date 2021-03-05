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
            Double add = a + b;
            Double minus = a - b;
            Double multiply = a * b;
            Double divide = a / b;
            Double residue = a % b;

            // Se muestran los resultados

            Console.Clear();

            Console.WriteLine("Numero 1: " + x + "\nNumero 2: " + y + "\n");
            Console.WriteLine("- La suma es: " + add);
            Console.WriteLine("- La resta es: " + minus);
            Console.WriteLine("- La multiplicacion es: " + multiply);
            Console.WriteLine("- La division es: " + divide);
            Console.WriteLine("- El residuo es: " + residue);

            Console.WriteLine("\n## Presione cualquier tecla para continuar ##");
            System.Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variables

            String nombre;
            int edad;

            // Pedir datos

            Console.WriteLine("Favor de escribir tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("\nFavor de escribir tu edad:");
            string años = Console.ReadLine();
            
            // Mostrar datos

            Console.Clear();
            
            if (int.TryParse(años, out edad)) {
                Console.WriteLine("\nTe llamas " + nombre + " y tienes " + edad + " años.");
            } else {
                Console.WriteLine("\nTe llamas " + nombre + " y tienes " + años + " años.");
            }

            System.Console.ReadKey();
        }
    }
}

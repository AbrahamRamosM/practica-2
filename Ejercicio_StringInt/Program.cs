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
            String edad;
            // Pedir datos

            Console.WriteLine("Favor de escribir tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("\nFavor de escribir tu edad:");
            edad = Console.ReadLine();
            
            // Mostrar datos

            Console.Clear();
            Console.WriteLine("\nTe llamas " + nombre + " y tienes " + Convert.ToInt32(edad) + " años.");

            System.Console.ReadKey();
        }
    }
}

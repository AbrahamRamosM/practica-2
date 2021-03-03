using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1. Pedir por consola el nombre de una persona

            String nombre;
            String ciudad;

            // #2. Pedir el nombre de una ciudad

            Console.WriteLine("Favor de escribir tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("\nEscribe tu ciudad");
            ciudad = Console.ReadLine();

            // #3. Mostrar nombre de ciudad en pantalla
            System.Console.Clear();
            System.Console.WriteLine("\nHola " + nombre + ", bienvenido a " + ciudad + ".");
            System.Console.ReadKey();
        }
    }
}

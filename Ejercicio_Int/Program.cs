using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1. Declarar 3 variables de tipo INT y asignarles valores estaticos;

            int a = 5;
            int b = 10;
            int c = 20;

            // #2. Crear una variable de tipo INT la cual guardara la suma de las 3 variables.

            int suma = a + b + c;

            // #3. Mostrar en pantalla el valor de SUMA "El valor de la suma es: " 
            
            System.Console.WriteLine("El valor de la suma es: " + suma);
            System.Console.WriteLine("\n## Presiona cualquier tecla para continuar ##");
            System.Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se piden los datos
             
            Console.WriteLine("################# BURGUER ###############\n");

            Console.WriteLine("Favor de escribir la cantidad de hamburguesas:");
            String hamburger = Console.ReadLine();

            Console.WriteLine("Favor de escribir la cantidad de papas:");
            String fries = Console.ReadLine();

            Console.WriteLine("Favor de escribir la cantidad de bebidas:");
            String drink = Console.ReadLine();

            // Se convierten los datos

            int a = Convert.ToInt32(hamburger);
            int b = Convert.ToInt32(fries);
            int c = Convert.ToInt32(drink);

            Double x;
            Double y;
            Double z;

            // Se muestran los datos

            Console.Clear();

            Console.WriteLine("############ RECIBO BURGUER ##########\n");

            Console.WriteLine("Cantidad de hamburguesas: {0} ---- $ {1}", a, x = a * 45);
            Console.WriteLine("Cantidad de papas:        {0} ---- $ {1}", b, y = b * 20);
            Console.WriteLine("Cantidad de bebidas:      {0} ---- $ {1}", c, z = c * 15);

            Console.WriteLine("\n############### TOTAL ################");

            Console.WriteLine("Cantidad de productos:    {0} ---- $ {1}", a + b + c, x + y + z);
            Console.WriteLine("\n## Presione cualquier tecla para continuar ##");

            System.Console.ReadKey();
        }
    }
}

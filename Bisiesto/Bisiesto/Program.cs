using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca un año");

            int año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && año % 100 != 0)
            {
                Console.WriteLine("El año " + año + " es un año bisiesto");

            }
            else if (año % 4 == 0 && año % 100 != 0 && año % 400 == 0)
            {
                Console.WriteLine("El año " + año + " es un año bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " NO es un año bisiesto");
            }


        Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el primer número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int sumaCubos = (n1 + n2) * (n1 * n1 - n1 * n2 + n2 * n2);
            int diferenciaCubos = (n1 - n2) * (n1 * n1 + n1 * n2 + n2 * n2);

            Console.WriteLine("El resultado de la suma de cubos es: " + sumaCubos);
            Console.WriteLine("El resultado de la diferencia de cubos es: " + diferenciaCubos);
            Console.ReadKey();

        }
    }
}

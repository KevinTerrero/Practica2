using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MCMMCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mcd = 0;
            int mcm = 0;
            Console.WriteLine("Introduzca el primer número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            int n2 = int.Parse(Console.ReadLine());

            int mayor = Math.Max(n1, n2);
            int menor = Math.Min(n1, n2);

            while (menor != 0)
            {
                mcd = menor;
                menor = mayor % menor;
                mayor = mcd;
            }

            mcm = (n1 * n2) / mcd;

            Console.WriteLine("El máximo común divisor es " + mcd);
            Console.WriteLine("El minimo común múltiplo es " + mcm);

            Console.ReadKey();

        }
    }
}

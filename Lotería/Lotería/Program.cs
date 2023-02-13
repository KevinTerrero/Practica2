using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotería
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();

            Console.WriteLine("Los tres numeros ganadores son:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(rnd.Next(0, 99));
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int limite = int.Parse(Console.ReadLine());
            int num = 0;
            int x;
            Console.WriteLine();
            while (limite > 0)
            {
                num++;
                x = 1;
                int count = 0;

                while (x <=num )
                {
                    if (num % x == 0)
                    {
                        count++;
                    }
                    x++;

                }
                if (count ==2)
                {
                    Console.WriteLine(num);
                    limite--;
                }

            }
            Console.ReadKey();
        }
    }
}

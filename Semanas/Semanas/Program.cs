using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semanas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca la primera fecha");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la segunda fecha");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan tSpan = fecha2 - fecha1;

            int semanas = tSpan.Days / 7;

            Console.WriteLine("El total de semanas es " + semanas);

            Console.ReadKey();
        }
    }
}

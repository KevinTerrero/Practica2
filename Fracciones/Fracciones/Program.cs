using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el cociente de la fracción");
            double cociente = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numerador de la fracción");
            double numerador = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el denominador de la fracción");
            double denominador = double.Parse(Console.ReadLine());

            double resultado = (cociente * denominador + numerador);
            Console.WriteLine("La fracción es: " + resultado + "/" + denominador);

            Console.ReadKey();

        }
    } 
}

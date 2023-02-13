using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] numeros = new int[10];
            int[] numeros2 = new int[10];
            string listaNumeros = string.Empty;
            string descendente = string.Empty;
            string ascendente = string.Empty;
            Console.WriteLine("Sin ordenar:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0,99);
                listaNumeros = String.Join(",", numeros);
            }
           numeros.CopyTo(numeros2, 0);

            Console.WriteLine(listaNumeros+ "\n");

            Console.WriteLine("Ordenados de forma ascendente:");

            int t;
            for (int i = 1; i < numeros.Length; i++)
            {
                for (int j = numeros.Length-1; j >= i; j--)
                {
                    if (numeros[j-1] > numeros[j])
                    {
                        t = numeros[j - 1];
                        numeros[j-1] = numeros[j];
                        numeros[j] = t;
                        ascendente = string.Join(",", numeros);
                    }
                }
            }
            Console.WriteLine(ascendente + "\n");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un texto o frase");
            string texto = Console.ReadLine();

            if (texto != null)
            {
                texto = texto.ToLower();
                texto = texto.Replace(" ", "");
                int cont = 0;
                bool flag = true;

                for (int i = texto.Length -1; i >= 0; i--)
                {
                    if (texto[i] != texto[cont])
                    {
                        flag = false;
                        break;
                    }
                    cont++;
                }
                if (flag == true)
                {
                    Console.WriteLine("El input es palíndromo");
                }
                else
                {
                    Console.WriteLine("El input no es palíndromo");
                }
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirSentido
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba una frase o palabra para invertirle el sentido");
            string palabra = Console.ReadLine();
            
            StringBuilder sb = new StringBuilder();
            for (int i = palabra.Length -1; i >=0 ; i--)
            {
                sb.Append(palabra[i]);
            }
            Console.WriteLine(sb.ToString());

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor. 
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, aux=0;
            Console.Write("Introduceti a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti b:");
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine(a+" "+b);
            Console.ReadKey();
        }
    }
}

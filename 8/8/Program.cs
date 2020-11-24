using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Introduceti a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti b:");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a+" "+b);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {    
        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, e;
            Console.WriteLine("Ecuatie de gradul 1:  ax+b=0 ");
            Console.Write("Introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti b=");
            b = int.Parse(Console.ReadLine());
            e = (-b) / a;
            Console.WriteLine();
            Console.WriteLine($"{a} x + {b} = 0");
            Console.WriteLine($"x = {e}");
            Console.ReadKey();
        }
    }
}

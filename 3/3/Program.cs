using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Introduceti un nr.  n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un nr.  k = ");
            k= int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} NU se divide cu {k}");
            Console.ReadKey();
        }
    }
}

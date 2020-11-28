using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        /// <summary>
        /// Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, a, b, nrintregi=0;
            Console.Write("Introduceti n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti intervalul [a,b]");
            Console.Write(" a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" b = ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)                              //toate numerele din interval
            {
                if (i % n == 0)                                       //verifica daca sunt divizibile cu n
                    nrintregi += 1;                                   //numara cate au fost divizibile
            }
            Console.WriteLine($"In intervalul [{a},{b}] se afla {nrintregi} numere divizibile cu {n}.");
            Console.ReadKey();
        }
    }
}

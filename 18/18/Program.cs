using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, div = 2, exp=0;
            Console.Write("Introduceti numarul : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Descompunerea in factori primi este :");
            while (n != 0)
            {
                while (n % div == 0)
                {                    
                    n = n / div;
                    exp++;
                }
                if (exp != 0)
                    Console.Write($"{div}^{exp} x ");
                div++;
                exp = 0;
            }            
            Console.ReadKey();
        }
    }
}

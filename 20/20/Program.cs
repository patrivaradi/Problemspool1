using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        /// <summary>
        /// Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
        /// </summary>
        static void Main(string[] args)
        {
            int m, n, intraga,zecimal;
            Console.Write("Introduceti  m = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti  n = ");
            n = int.Parse(Console.ReadLine());
            intraga = m / n;
            zecimal = m % n;
            Console.WriteLine($"{m}/{n} = {intraga}.{zecimal}");
            Console.ReadKey();
        }
    }
}

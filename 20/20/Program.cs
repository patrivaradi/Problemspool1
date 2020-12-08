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
            int m, n,intreaga,zecimal;
            Console.Write("Introduceti  m = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti  n = ");
            n = int.Parse(Console.ReadLine());
            intreaga = m / n;
            zecimal = m % n;
            Console.Write($"{intreaga},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(zecimal);
            bool periodic = false;
            do
            {
                cifra = zecimal * 10 / n;
                cifre.Add(cifra);
                rest = zecimal * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }                
                zecimal = rest;
            } while (zecimal != 0);
            if(!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else 
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                        Console.Write("(");
                    Console.Write(cifre[i]);
                }
                Console.Write(")");
            }

            Console.ReadKey();
        }
    }
}

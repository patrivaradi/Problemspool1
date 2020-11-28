using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>
        static void Main(string[] args)
        {
            int n, aux, og=0;
            Console.WriteLine("Introduceti numarul pentru verificare : ");
            n = int.Parse(Console.ReadLine());
            aux = n;
            while(n!=0)
            {
                og = og * 10 + n % 10;
                n /= 10;
            }
            n = aux;
            if (n == og)
                Console.WriteLine($"Numarul {n} este palindrom!");
            else
                Console.WriteLine($"Numarul {n} NU este palindrom!");
            Console.ReadKey();
        }
    }
}

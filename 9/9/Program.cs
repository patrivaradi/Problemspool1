using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>

        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii lui {n} sunt:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i+" ");                
            }
            Console.ReadKey();
        }
    }
}

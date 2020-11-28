using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n. 
        /// </summary>
        static void Main(string[] args)
        {
            int n,m;
            Console.Write("Introduceti  n = ");
            n = int.Parse(Console.ReadLine());
            m = n;
            while (m != 0) 
            {
                Console.Write(m % 10);
                m /= 10;
            }            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti  n = ");
            n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
                Console.WriteLine($"{n} nu este prim.");
            else
            {
                for (int i = 2; i <=n/2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine($"{n} nu este prim.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{n} este prim.");
                        break;
                    }
                }
                
            }
            Console.ReadKey();
            
        }
    }
}

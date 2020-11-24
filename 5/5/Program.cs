using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>        
        static void Main(string[] args)
        {
            int n,k,c;
            n = 64240721;
            Console.WriteLine($" {n}");                
            Console.Write("Introduceti k =");
            k = int.Parse(Console.ReadLine());
            c = 0;
            if (k == 1)
                c = n % 10;
            else if (k == 2)
                c = (n / 10) % 10;
            else if (k == 3)
                c = (n / 100) % 10;
            else if (k == 4)
                c = (n / 1000) % 10;
            else if (k == 5)
                c = (n / 10000) % 10;
            else if (k == 6)
                c = (n / 100000) % 10;
            else if (k == 7)
                c = (n / 1000000) % 10;
            else if (k == 8)
                c = n / 1000000;
            else
                Console.WriteLine("k este invalid.");
            Console.WriteLine($"A {k}-a cifra de la sfarsitul nr-lui este: {c}");
            Console.ReadKey();
        }
    }
}

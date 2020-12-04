using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
        /// </summary>
        static void Main(string[] args)
        {
            int n,x;
            Random rnd = new Random();
            x = rnd.Next(1, 1024);
            Console.WriteLine("Introduceti un numar intre 1 si 1024 pentru a ghici x=?");
            do
            {                
                Console.ForegroundColor = ConsoleColor.White;
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > 1024)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numarul trebuie sa fie intre [1,1024]. Incercati din nou.");
                }                
                else if (n > x)
                    Console.WriteLine("Incercati mai mic.");
                else if (n < x)
                    Console.WriteLine("Incercati mai mare.");
            }
            while (n != x);
            Console.WriteLine($"Ati castigat! x = {x}");
            Console.ReadKey();
        }
    }
}

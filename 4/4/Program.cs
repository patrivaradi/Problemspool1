using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        /// <summary>
        /// Detreminati daca un an y este an bisect. 
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Introduceti anul : ");
            int y = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(y))
                Console.WriteLine($"Anul {y} este an bisect.");
            else
                Console.WriteLine($"Anul {y} NU este an bisect.");
            Console.ReadKey();
        }
    }
}

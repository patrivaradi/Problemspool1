using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        /// <summary>
        /// Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        static void Main(string[] args)
        {
            int a, b, c, m=0;
            Console.WriteLine("Introduceti lungimile laturilor ");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("Nu poate fi triunghi.");
            else if(a > b && a > c)
            {
                if (a == b + c)
                    Console.WriteLine("Nu poate fi triunghi.");
                else
                    Console.WriteLine("Poate fi triunghi.");
            }
            else if (b > a && b > c)
            {
                if (b == a + c)
                    Console.WriteLine("Nu poate fi triunghi.");
                else
                    Console.WriteLine("Poate fi triunghi.");
            }
            else if (c > a && c > b)
            {
                if (c == a + b)
                    Console.WriteLine("Nu poate fi triunghi.");
                else
                    Console.WriteLine("Poate fi triunghi.");
            }
            Console.ReadKey();
        }
    }
}

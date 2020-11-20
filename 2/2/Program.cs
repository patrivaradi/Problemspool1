using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, 
        /// unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        /// </summary>
        static void Main(string[] args)
        {
            double a, b, c, e1, e2;
            Console.WriteLine("Ecuatie de gradul 2:  ax^2+bx+c=0 ");
            Console.Write("Introduceti a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti c=");
            c = int.Parse(Console.ReadLine());
            e1 = (-b + (Math.Sqrt((b * b) - 4 * a * c))) / (2 * a);
            e2 = (-b - (Math.Sqrt((b * b) - 4 * a * c))) / (2 * a);
            Console.WriteLine();
            Console.WriteLine($"{a} x ^ 2 + {b} x + c = 0");
            Console.WriteLine($"x1 = {e1}       x2 = {e2}");
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        static void Main(string[] args)
        {
            int n1, n2, n3,aux;
            Console.WriteLine("Introduceti trei numere:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            if(n2>n3)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            if (n1>n2)
            {
                aux = n2;
                n2 = n1;
                n1 = aux;
            }
            Console.WriteLine(n1+" "+n2+" "+n3);
            Console.ReadKey();
        }
    }
}

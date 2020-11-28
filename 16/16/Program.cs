using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5,aux;
            Console.WriteLine("Introduceti 5 numere : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            if (n2 > n3)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            if (n3 > n4)
            {
                aux = n4;
                n4 = n3;
                n3 = aux;
            }
            if (n4 > n5)
            {
                aux = n4;
                n4 = n5;
                n5 = aux;
            }
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            if (n2 > n3)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            if (n3 > n4)
            {
                aux = n3;
                n3 = n4;
                n4 = aux;
            }
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            if (n2 > n3)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            
            Console.WriteLine(n1+" "+n2+" "+n3+" "+n4+" "+n5);
            
            Console.ReadKey();
        }
    }
}

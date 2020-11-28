using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>
        static void Main(string[] args)
        {
            int n1, n2,aux1,aux2,aux3,aux4;
            Console.WriteLine("Introduceti numerele : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            aux1 =aux3= n1; 
            aux2=aux4 = n2;
            while (aux1 != aux2)
            {
                if (aux1 > aux2)
                    aux1 -= aux2;
                else
                    aux2 -= aux1;
            }
            Console.WriteLine($"Cel mai mare divizor comun este : {aux1}");            
            while(aux3!=aux4)
            {
                if (aux3 < aux4)
                    aux3 += n1;
                else
                    aux4 += n2;
            }
            Console.WriteLine($"Cel mai mic multiplu comun este : {aux3}");
            Console.ReadKey();
        }
    }
}

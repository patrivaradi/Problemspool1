using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>
        static void Main(string[] args)
        {
            int n,cifra1=-1,cifra2=-1;
            Console.Write("Introduceti numarul : ");
            n = int.Parse(Console.ReadLine());
            int aux = n;
            if (aux < 100)
                Console.WriteLine("Numarul este format din doua cifre.");
            
            while(aux!=0)
            {
                if (cifra1==-1)
                {
                    cifra1 = aux % 10;
                }
                else
                {
                    if (aux % 10 != cifra1)
                        if (cifra2 == -1)
                        {
                            cifra2 = aux % 10;
                        }
                        else if (aux % 10 != cifra2)
                        {
                            Console.WriteLine("Numarul NU este format din doar 2 cifre.");
                            break;
                        }
                }
                aux /= 10;
            }
            Console.WriteLine("Numarul este format din 2 cifre."); 

            Console.ReadKey();
        }
    }
}

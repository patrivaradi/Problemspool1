using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        static void Main(string[] args)
        {
            int y1, y2, nrbisect=0;
            Console.WriteLine("Introduceti anii intre care vreti sa aflati cati ani bisect sunt [y1,y2].");
            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());
            for (int i = y1; i <= y2; i++)
            {
                if (DateTime.IsLeapYear(i))
                    nrbisect += 1;
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nrbisect} ani bisect.");
            Console.ReadKey();

        }
    }
}

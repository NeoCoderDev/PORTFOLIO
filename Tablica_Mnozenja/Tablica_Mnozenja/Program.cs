using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_Mnozenja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mojniz = new int[10];
            for (int i = 1; i <= mojniz.Length; i++)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}\t", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", i * j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

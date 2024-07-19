using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogadjanje_Brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int b = rnd.Next(1, 10);
            int pokusaj = 0;

            Console.WriteLine("Zamislio sam broj " + b);

            Console.Write("Pogodi broj koji sam zamislio:\n");

            for (int i = 0; i < 100; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                

                if (b == c)
                {
                    pokusaj++;
                    Console.WriteLine("");
                    Console.WriteLine("Bravo, pogodio/la si broj\n");
                    Console.WriteLine("Broj pokusaja: {0}\n", pokusaj);
                    Console.WriteLine("Upisite bilo koji broj da izadjete iz programa");
                    int exit = int.Parse(Console.ReadLine());
                    Environment.Exit(1);
                }
                else if (b < c)
                {
                    Console.WriteLine("Ne, ja sam zamislio manji broj");
                    pokusaj++;
                }
                else if (b > c)
                {
                    Console.WriteLine("Ne, ja sam zamislio veci broj ");
                    pokusaj++;
                }
            }
        }
    }
}

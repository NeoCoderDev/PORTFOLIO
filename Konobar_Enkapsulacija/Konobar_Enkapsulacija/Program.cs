using Domaci_Konobar_Enkapsulacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_Enkapsulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            ineligible:
            Osobe osobe = new Osobe();

            osobe.Marko = "Marko Jovanovic";
            osobe.Srba = "Srba Petrovic";
            osobe.broj = 10;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\t KAFANA KOD SRBE PETROVICA");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------\n");
            Console.WriteLine("Molimo vas upisite broj osoba za porudzbinu\n");
            Console.WriteLine("Unesite broj osoba: ");
            int brojGostiju = int.Parse(Console.ReadLine());
            if (brojGostiju >= osobe.broj)
            {
                Console.WriteLine("Za {0} osoba je zaduzen iskusni kuvar gazda {1}", brojGostiju, osobe.Srba);
            }
            if (brojGostiju < osobe.broj)
            {
                Console.WriteLine("Za {0} osoba je zaduzen novi kuvar {1}", brojGostiju, osobe.Marko);
            }
            Console.Read();
        }
          goto ineligible;  
        }
    }
}

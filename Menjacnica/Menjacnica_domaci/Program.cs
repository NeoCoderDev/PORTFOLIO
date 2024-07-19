using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjacnica_domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menjacnica - Exchange\n");
            Console.WriteLine("Kursna lista:\n1 DIN = 0,008474576 EUR\n1 EUR = 118 DIN\n\n");
            Console.WriteLine("Da biste razmenili dinare u evre ukucajte broj 1\n");
            Console.WriteLine("Ili ako želite da razmenite evre u dinare ukucajte broj 2\n");
            Console.WriteLine("Izaberite vrstu razmene:\n");
            Console.WriteLine("1.Dinar u Evro\n");
            Console.WriteLine("2.Evro u Dinar\n");

            int tabela = int.Parse(Console.ReadLine());
            switch(tabela)
            {
              
                case 1:
                Console.WriteLine("Unesite dinarsku sumu: ");
                int Din = int.Parse(Console.ReadLine());
                if (Din < 1)
                {
                    Console.WriteLine("Unesena suma za razmenu nije odgovarajuća, molimo vas upišite vecu sumu od 0");
                    Console.Read();
                }
                float Euro = 118;
                Console.WriteLine("Vasa razmenjena suma iz dinara u evre iznosi: {2} EUR", Din, Euro, Din / Euro);
                Console.WriteLine("Dovidjenja!");
                Console.Read();
                break;
           
                case 2:   
                Console.WriteLine("Unesite sumu u evrima: ");
                int EuroE = int.Parse(Console.ReadLine());
                if (EuroE < 0)
                {
                    Console.WriteLine("Unesena suma za razmenu nije odgovarajuća, molimo vas upišite vecu sumu od 0");
                    Console.Read();
                }
                float DinE = 118;
                Console.WriteLine("Vasa razmenjena suma iz evra u dinare iznosi: {2} DIN", EuroE, DinE, EuroE * DinE);
                Console.WriteLine("Dovidjenja!");
                Console.Read();
                break;
            }
        }
    }
}

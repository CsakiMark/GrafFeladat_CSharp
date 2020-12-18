using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void feher()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void zold()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void Main(string[] args)
        {
         
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            zold();
            Console.WriteLine("Szélességi bejárás 0 kezdőpontból:");
            feher();
            graf.szelessegiBejar(0);
            zold();
            Console.WriteLine("\nMélységi bejárás 0 kezdőpontból:");
            feher();
            graf.melysegiBejar(0);

            zold();
            Console.WriteLine("A gráf összefüggősége: " + graf.Osszefuggo());
            feher();

            zold();
            Console.WriteLine("\nA mohó algoritmus színezései:");
            feher();
            foreach (int kulcs in graf.mohoSzinezes().Keys)
            {
                Console.WriteLine("csúcs: " + kulcs + ", szín: " + graf.mohoSzinezes()[kulcs]);
            }
            Console.ReadKey();
        }
    }

}

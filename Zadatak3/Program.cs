using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak3
{
    class Program
    {
        //  U metodi BacanjaKocke složiti petlju koja će ispisivati bačeniBroj od 1 do 6
        // (koji se dobiva pozivom metode Random.Next) sve dok je taj broj različit od 6. Kada broj postane 
        // 6, treba prekinuti ponavljanje petlje i ispisati poruku: 
        // "Šestica je bačena u <N>. pokušaju", gdje je N redni broj bacanja u kojem se pojavio broj 6.
        // Npr. za niz 3, 5, 6, metoda bi trebala ispisati:
        //  3
        //  5
        //  "Šestica je bačena u 3. pokušaju".

        // Funkcionalnost metode možete provjeriti preko donjih poziva u metodi Main.

        public static void BacanjaKocke(int klica)
        {
            
            var generatorSlučajnih = new Random(klica);

            int brojBacanja = 0;
            int bačeniBroj = 0;
            
            for (bačeniBroj = 0; bačeniBroj <= 6; ++bačeniBroj)
            {
                if (bačeniBroj<=6)
                {
                    Console.WriteLine(bačeniBroj);
                }
                else
                {
                    Console.WriteLine("Šestica je bačena u <N>. pokušaju");
                }
            }
            bačeniBroj = generatorSlučajnih.Next(1, 7);
            Console.WriteLine(bačeniBroj);

            Console.WriteLine($"Šestica je bačena u {brojBacanja}. pokušaju");
        }

        public static void Main()
        {
            BacanjaKocke(2); // metoda bi morala ispisati brojeve 5, 3 i 1 te "Šestica je bačena u 4. pokušaju"

            BacanjaKocke(5); // metoda bi morala ispisati brojeve 3, 2, 2, 4 i 3 te "Šestica je bačena u 6. pokušaju"
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak2
{
    class Program
    {
        // TODO: Zadatak 2: Napisati metodu KlasificirajBrojeve koja kao argument dobiva kolekciju cijelih brojeva IEnumerable<int>.
        // Metoda treba izbrojati i ispisati koliko je brojeva u zadanoj kolekciji većih od nule, manjih od nule i jednakih nuli.
        // Ispis treba sadržavati samo brojeve, bez ikakvog teksta.
        // Nakon što definirate metodu, njenu funkcionalnost provjerite tako da odkomentirate oba poziva metode u donjoj metodi Main.

        public static void Main()
        {
            Console.WriteLine("Niz brojeva");

            var nizBrojeva = new int[] { 10, 20, 3, -4, 0, -5 };
            //KlasificirajBrojeve(nizBrojeva); // metoda bi trebala ispisati brojeve 3, 2 i 1

            Console.WriteLine("Lista brojeva");

            var listaBrojeva = new List<int>{ 0, -5, 24, 0, 32, 0 };
            //KlasificirajBrojeve(listaBrojeva); // metoda bi trebala ispisati brojeve 2, 1 i 3
        }
    }
}

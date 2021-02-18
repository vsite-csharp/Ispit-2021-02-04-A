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

        public static void Main(string[] args)
        {
            var nizBrojeva = new int[] { 2, 1, -3, 3 };
            KlasificirajBrojeve(nizBrojeva);
            var listaBrojeva = new List<int> { 2, -3, 0 };
            KlasificirajBrojeve(listaBrojeva);
        }

        private static void KlasificirajBrojeve(IEnumerable<int> nizBrojeva)
        {
            int brojac1 = 0;
            int brojac2 = 0;
            int brojac3 = 0;
            foreach (var item in nizBrojeva)
            { 
                if (item < 0)
                {
                    brojac1++;
                }
                else if(item < 0)
                {
                    brojac2++;
                }
                else 
                {
                    brojac3++;
                }
            
            }
            Console.WriteLine(brojac1 + "    " + brojac2 + "    " + brojac3);
        }

        

        

        
    }
}

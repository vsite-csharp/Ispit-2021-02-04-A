using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak1
{
    class Program
    {
    
        public static void Main()
        {
            // TODO: Zadatak 1: Napisati program koji će ispisati tablicu s trećinama brojeva od 1 do 30.
            // Tablica mora u lijevom stupcu prikazati broj a u desnom stupcu taj broj podijeljen s 3. Npr.
            // 1    0,3333333
            // 2    0,6666666
            // 3    1
            // ....
            double broj = 0;
               for(int i = 1;i <= 30;i++){
                        broj = i;
                    Console.WriteLine(i + " " + broj/3);
                    
            }

        }
    }
}

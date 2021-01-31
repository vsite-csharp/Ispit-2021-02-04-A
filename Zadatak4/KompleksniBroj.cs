using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak4
{
    // TODO: Zadatak 4: Strukturu KompleksniBroj dopuniti tako da ispis tog objekta u metodi Console.WriteLine
    // ispiše taj broj u uobičajenom matematičkom formatu: <realniDio> + <imaginarniDio>i
    // Npr.
    //     Console.WriteLine(new KompleksniBroj(5, 4);
    // bi trebao dati ispis:
    //     5 + 4i
    // Sve moguće kombinacije koje treba podržati navedene su u metodi Main.

    struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni = 0.0)
        {
            Realni = realni;
            Imaginarni = imaginarni;
        }

        public readonly double Realni;
        public readonly double Imaginarni;
    }
}

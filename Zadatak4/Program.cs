using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new KompleksniBroj(1, 2)); // trebalo bi ispisati: 1 + 2i
            Console.WriteLine(new KompleksniBroj(5)); // trebalo bi ispisati: 5
            Console.WriteLine(new KompleksniBroj(1, -3)); // trebalo bi ispisati: 1 - 3i
            Console.WriteLine(new KompleksniBroj(4, 1)); // trebalo bi ispisati: 4 + i
            Console.WriteLine(new KompleksniBroj(7, -1)); // trebalo bi ispisati: 7 - i
            Console.WriteLine(new KompleksniBroj(0, 1)); // trebalo bi ispisati: i
            Console.WriteLine(new KompleksniBroj(0, -1)); // trebalo bi ispisati: -i
        }
    }
}

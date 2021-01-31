using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak6
{
    class Program
    {
        static void Predstavljanje(object obj)
        {
            var o = (Osoba)obj;
            //o.PredstaviSe();
        }

        static void Main(string[] args)
        {
            Osoba o = new Osoba("Pero");
            Predstavljanje(o); // treba ispisati "Pero"

            var s = new Student("Hrvoje", 2);
            Predstavljanje(s); // treba ispisati "Hrvoje, student 2. godine"
        }
    }
}

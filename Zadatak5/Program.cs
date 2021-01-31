using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak5
{
    class Program
    {
        public static void UsporedbaVektora(Vektor v1, Vektor v2)
        {
            var vektor1 = (IComparable<Vektor>)v1;
            int usporedba = vektor1.CompareTo(v2);
            if (usporedba < 0)
                Console.WriteLine($"Vektor ({v1.X}, {v1.Y}) je kraći od vektora ({v2.X}, {v2.Y})");
            else if (usporedba > 0)
                Console.WriteLine($"Vektor ({v1.X}, {v1.Y}) je dulji od vektora ({v2.X}, {v2.Y})");
            else
                Console.WriteLine($"Vektor ({v1.X}, {v1.Y}) ima jednaku duljinu kao vektor ({v2.X}, {v2.Y})");
        }

        public static void IspisDuljineVektora(Vektor v)
        {
            // Console.WriteLine($"Duljina vektora ({v.X}, {v.Y}) je {v.Modul()}");
        }

        static void Main(string[] args)
        {
            IspisDuljineVektora(new Vektor(3, 4)); // trebalo bi ispisati: "Duljina vektora (3, 4) je 5"
            IspisDuljineVektora(new Vektor(2, 3)); // trebalo bi ispisati: "Duljina vektora (2, 3) je 3.605551..."

            UsporedbaVektora(new Vektor(1, 2), new Vektor(2, 2)); // trebalo bi ispisati "Vektor (1, 2) je kraći od vektora (2, 2)"
            UsporedbaVektora(new Vektor(3, 2), new Vektor(2, 2)); // trebalo bi ispisati "Vektor (2, 2) je dulji od vektora (2, 2)"
            UsporedbaVektora(new Vektor(3, 2), new Vektor(2, 3)); // trebalo bi ispisati "Vektor (3, 2) ima jednaku duljinu kao vektor (2, 3)"
        }
    }
}

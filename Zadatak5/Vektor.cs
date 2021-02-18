using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak5
{
    // TODO: Zadatak 5: U klasi Vektor definirati javnu metodu Modul koja će vraćati duljinu vektora. Npr. za vektor 
    // zadan konstruktorom:
    //   var v1 = new Vektor(2, 4);
    // poziv:
    //   var duljina = v1.Modul();
    // mora varijabli duljina pridijeliti vrijednost Math.Sqrt(2 * 2 + 4 * 4) = 4.4721...
    // (Implementaciju provjeriti tako da se otkomentira naredba u metodi IspisDuljineVektora i pokrene program)
    // Potom definirati da klasa Vektor implementira sučelje IComparable<T> koje će omogućiti međusobnu usporedbu dva 
    // vektora prema njihovim duljinama.
    // Neke moguće kombinacije koje treba podržati navedene su u metodi Main.

    class Vektor : IComparable<Vektor>
    {
        public double Modul() {

            return Math.Sqrt(X * X + Y * Y);
        }

        public int CompareTo(Vektor other) {
            //var vektor1 = (IComparable<Vektor>)v1;
            //int usporedba = vektor1.CompareTo(other);
            throw new NotImplementedException();
        }

        public Vektor(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
    }
}

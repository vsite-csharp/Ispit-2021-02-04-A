using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak6
{
    //  Klasu Student proglasiti izvedenom iz klase Osoba te u konstruktoru klase Student proslijediti
    // ime konstruktoru klase Osoba.
    // U klasu Osoba dodati virtualnu metodu PredstaviSe koja treba samo ispisati ime osobe.
    // U klasi Student implementirati metodu PredstaviSe tako da umjesto samo imena osobe ispiše "<Ime>, student <N>. godine".
    // Otkomentirajte naredbu u metodi Predstavljanje i provjeriti moguće kombinacije koje treba podržati u metodi Main.

    class Osoba

    {
         
        public Osoba(string ime)
        {
            Ime = ime;
        }

        public string Ime { get; private set; }
        public virtual void PredstaviSe()
        {
            Console.WriteLine(Ime);
        }
    }

    class Student : Osoba
    {
        public Student(string ime, int godina): base(ime)
        {
            Godina = godina;
        }

        public int Godina { get; private set; }
        public override void  PredstaviSe()
        {
            Console.WriteLine(Ime+", student"+" " +Godina+ ". godine");
        }
    }
}

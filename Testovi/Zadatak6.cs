using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Vsite.CSharp.Ispit.Zadatak6;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak6 : ConsoleTest
    {
        [TestMethod]
        public void PredstaviSeZaOsobuIspisujeNjenoIme()
        {
            var mojeMetode = typeof(Osoba).GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "PredstaviSe");
            Assert.AreEqual(1, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.ElementAt(0).IsVirtual);

            mojeMetode.ElementAt(0).Invoke(new Osoba("Ime"), new object[] { });

            Assert.AreEqual("Ime", cw.GetString());
        }

        [TestMethod]
        public void PredstaviSeZaStudentaIspisujeImeIGodinuStudija()
        {
            var mojeMetode = typeof(Student).GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).Where(mi => mi.Name == "PredstaviSe");
            Assert.AreEqual(1, mojeMetode.Count());
            Assert.IsTrue(mojeMetode.ElementAt(0).IsVirtual);

            var constructors = typeof(Student).GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            Assert.AreEqual(1, constructors.Length);
            Osoba o = constructors[0].Invoke(new object[] { "Student", 3 }) as Osoba;
            
            mojeMetode.ElementAt(0).Invoke(o, new object[] { });

            Assert.AreEqual("Student, student 3. godine", cw.GetString());
        }
    }
}

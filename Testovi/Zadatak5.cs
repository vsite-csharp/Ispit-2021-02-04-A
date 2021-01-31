using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Vsite.CSharp.Ispit.Zadatak5;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak5 : ConsoleTest
    {
        [TestMethod]
        public void ModulVektora_3_0_MoraBiti_3()
        {
            Program.IspisDuljineVektora(new Vektor(3, 0));
            var line = cw.GetString();
            Assert.IsTrue(line.StartsWith("Duljina vektora ("));

            var components = line.Split(new string[] { "je" }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(3, double.Parse(components[1]), 1e-5);
        }

        [TestMethod]
        public void ModulVektora_0_4_MoraBiti_4()
        {
            Program.IspisDuljineVektora(new Vektor(0, 4));
            var line = cw.GetString();
            Assert.IsTrue(line.StartsWith("Duljina vektora ("));

            var components = line.Split(new string[] { "je" }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(4, double.Parse(components[1]), 1e-5);
        }

        [TestMethod]
        public void ModulVektora_3_4_MoraBiti_5()
        {
            Program.IspisDuljineVektora(new Vektor(3, 4));
            var line = cw.GetString();
            Assert.IsTrue(line.StartsWith("Duljina vektora ("));

            var components = line.Split(new string[] { "je" }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(5, double.Parse(components[1]), 1e-5);
        }

        [TestMethod]
        public void ModulVektora_2_3_MoraBiti_3dot605551()
        {
            Program.IspisDuljineVektora(new Vektor(2, 3));
            var line = cw.GetString();
            Assert.IsTrue(line.StartsWith("Duljina vektora ("));

            var components = line.Split(new string[] { "je" }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(3.605551, double.Parse(components[1]), 1e-5);
        }

        [TestMethod]
        public void AkoJeVektorSKojimSeUspoređujeDuljiCompareToVraćaBrojManjiOdNule()
        {
            var v1 = (IComparable<Vektor>)(new Vektor(1, 2));
            Assert.IsTrue(v1.CompareTo(new Vektor(2, 2)) < 0);
        }

        [TestMethod]
        public void AkoJeVektorSKojimSeUspoređujeKraćiCompareToVraćaBrojVećiOdNule()
        {
            var v1 = (IComparable<Vektor>)(new Vektor(2, 2));
            Assert.IsTrue(v1.CompareTo(new Vektor(2, 1)) > 0);
        }

        [TestMethod]
        public void AkoJeVektorSKojimSeUspoređujeJednakeDuljineCompareToVraćaNulu()
        {
            var v1 = (IComparable<Vektor>)(new Vektor(3, 2));
            Assert.IsTrue(v1.CompareTo(new Vektor(2, 3)) == 0);
        }
    }
}

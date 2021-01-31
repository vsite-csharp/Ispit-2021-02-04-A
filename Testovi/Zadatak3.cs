using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak3 : ConsoleTest
    {
        [TestMethod]
        public void TestZaKlicu0()
        {
            Ispit.Zadatak3.Program.BacanjaKocke(0);

            Assert.AreEqual(7, cw.Length);

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(4, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(4, cw.GetInt());
            Assert.AreEqual("Šestica je bačena u 7. pokušaju", cw.GetString());
        }

        [TestMethod]
        public void TestZaKlicu1()
        {
            Ispit.Zadatak3.Program.BacanjaKocke(1);

            Assert.AreEqual(8, cw.Length);

            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(4, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual("Šestica je bačena u 8. pokušaju", cw.GetString());
        }

        [TestMethod]
        public void TestZaKlicu2()
        {
            Ispit.Zadatak3.Program.BacanjaKocke(2);

            Assert.AreEqual(4, cw.Length);

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual("Šestica je bačena u 4. pokušaju", cw.GetString());
        }
    }
}

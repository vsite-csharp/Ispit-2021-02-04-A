using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

using Vsite.CSharp.Ispit.Zadatak4;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak4
    {
        [TestMethod]
        public void PozitvniRealniDioPozitivniImaginarniDio()
        {
            var kb = new KompleksniBroj(1, 2);
            Assert.AreEqual("1+2i", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void PozitvniRealniDioImaginarniDioNula()
        {
            var kb = new KompleksniBroj(5);
            Assert.AreEqual("5", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void PozitvniRealniDioNegativniImaginarniDio()
        {
            var kb = new KompleksniBroj(1, -3);
            Assert.AreEqual("1-3i", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void PozitivniRealniDioImaginarniDioJedan()
        {
            var kb = new KompleksniBroj(4, 1);
            Assert.AreEqual("4+i", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void PozitivniRealniDioImaginarniDioMinusJedan()
        {
            var kb = new KompleksniBroj(4, -1);
            Assert.AreEqual("4-i", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void RealniDioNulaPozitivniImaginarniDio()
        {
            var kb = new KompleksniBroj(0, 1);
            Assert.AreEqual("i", kb.ToString().RemoveWhitespace());
        }

        [TestMethod]
        public void RealniDioNulaNegativniImaginarniDio()
        {
            var kb = new KompleksniBroj(0, -1);
            Assert.AreEqual("-i", kb.ToString().RemoveWhitespace());
        }
    }
}

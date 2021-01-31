using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Vsite.CSharp.Ispit.Zadatak1;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak1 : ConsoleTest
    {
        [TestMethod]
        public void Test()
        {
            Program.Main();

            Assert.IsFalse(cw.IsEmpty);
            Assert.AreEqual(30, cw.Length);
            for (int i = 1; i <= cw.Length; ++i)
            {
                string line = cw.GetString();
                var values = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(2, values.Length);
                Assert.AreEqual(i, double.Parse(values[0]), 1e-5);
                Assert.AreEqual((double)i/3, double.Parse(values[1]), 1e-5);
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Vsite.CSharp.Ispit.Zadatak2;

namespace Vsite.CSharp.Ispit.Testovi
{
    [TestClass]
    public class Zadatak2 : ConsoleTest
    {
        [TestMethod]
        public void Test()
        {
            Program.Main();

            Assert.IsFalse(cw.IsEmpty);
            if (cw.Length == 8)
            {
                Assert.AreEqual("Niz brojeva", cw.GetString());
                Assert.AreEqual(3, cw.GetInt());
                Assert.AreEqual(2, cw.GetInt());
                Assert.AreEqual(1, cw.GetInt());

                Assert.AreEqual("Lista brojeva", cw.GetString());
                Assert.AreEqual(2, cw.GetInt());
                Assert.AreEqual(1, cw.GetInt());
                Assert.AreEqual(3, cw.GetInt());
            }
            else if (cw.Length == 4)
            {
                Assert.AreEqual("Niz brojeva", cw.GetString());

                string line = cw.GetString();
                var values = line.Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(3, values.Length);
                Assert.AreEqual(3, int.Parse(values[0]));
                Assert.AreEqual(2, int.Parse(values[1]));
                Assert.AreEqual(1, int.Parse(values[2]));

                Assert.AreEqual("Lista brojeva", cw.GetString());

                line = cw.GetString();
                values = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(3, values.Length);
                Assert.AreEqual(2, int.Parse(values[0]));
                Assert.AreEqual(1, int.Parse(values[1]));
                Assert.AreEqual(3, int.Parse(values[2]));
            }
            else
                Assert.Fail();
        }
    }
}

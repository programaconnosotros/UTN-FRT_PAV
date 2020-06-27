using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test4A()
        {
            LibTests.RunTest4A(Problema4.Reemplazar);
        }

        [TestMethod]
        public void Test4B()
        {
            LibTests.RunTest4B(Problema4.Reemplazar);
        }

        [TestMethod]
        public void Test4C()
        {
            LibTests.RunTest4C(Problema4.Reemplazar);
        }

        [TestMethod]
        public void Test4D()
        {
            LibTests.RunTest4D(Problema4.Reemplazar);
        }
    }
}

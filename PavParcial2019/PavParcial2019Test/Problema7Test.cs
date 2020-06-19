using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test18()
        {
            LibTests.RunTest18<Flota, Transporte, Tipo>();
        }

        [TestMethod]
        public void Test19()
        {
            LibTests.RunTest19<Flota, Transporte, Tipo>();
        }
    }
}

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
        public void Test10()
        {
            LibTests.RunTest10(Problema4.EncontrarImpares);
        }

        [TestMethod]
        public void Test11()
        {
            LibTests.RunTest11(Problema4.EncontrarImpares);
        }
    }
}

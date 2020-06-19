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
        public void Test3()
        {
            LibTests.RunTest3(Problema2.CalcularPrecioFinal);
        }

        [TestMethod]
        public void Test4()
        {
            LibTests.RunTest4(Problema2.CalcularPrecioFinal);
        }
    }
}

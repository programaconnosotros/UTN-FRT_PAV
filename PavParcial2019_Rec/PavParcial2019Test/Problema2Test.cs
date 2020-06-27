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
        public void Test2A()
        {
            LibTests.RunTest2A(Problema2.CalcularPrecioFinal);
        }

        [TestMethod]
        public void Test2B()
        {
            LibTests.RunTest2B(Problema2.CalcularPrecioFinal);
        }

        [TestMethod]
        public void Test2C()
        {
            LibTests.RunTest2C(Problema2.CalcularPrecioFinal);
        }

        [TestMethod]
        public void Test2D()
        {
            LibTests.RunTest2D(Problema2.CalcularPrecioFinal);
        }
    }
}

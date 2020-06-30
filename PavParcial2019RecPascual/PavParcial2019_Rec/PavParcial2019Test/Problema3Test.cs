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
        public void Test3A()
        {
            LibTests.RunTest3A(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test3B()
        {
            LibTests.RunTest3B(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test3C()
        {
            LibTests.RunTest3C(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test3D()
        {
            LibTests.RunTest3D(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test3E()
        {
            LibTests.RunTest3E(Problema3.CalcularYMostrar);
        }
    }
}

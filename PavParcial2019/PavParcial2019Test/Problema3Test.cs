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
        public void Test5()
        {
            LibTests.RunTest5(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test6()
        {
            LibTests.RunTest6(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test7()
        {
            LibTests.RunTest7(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test8()
        {
            LibTests.RunTest8(Problema3.CalcularYMostrar);
        }

        [TestMethod]
        public void Test9()
        {
            LibTests.RunTest9(Problema3.CalcularYMostrar);
        }
    }
}

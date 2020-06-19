using System;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test1()
        {
            LibTests.RunTest1(Problema1.Calcular);
        }

        [TestMethod]
        public void Test2()
        {
            LibTests.RunTest2(Problema1.Calcular);
        }
    }
}

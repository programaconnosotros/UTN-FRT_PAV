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
        public void Test12()
        {
            LibTests.RunTest12<Empleado>(Problema5.Evaluador);
        }

        [TestMethod]
        public void Test13()
        {
            LibTests.RunTest13<Empleado>(Problema5.Evaluador);
        }

        [TestMethod]
        public void Test14()
        {
            LibTests.RunTest14<Empleado>(Problema5.Evaluador);
        }
    }
}

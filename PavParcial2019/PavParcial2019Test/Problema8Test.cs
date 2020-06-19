using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test20()
        {
            LibTests.RunTest20<Operacion, Suma, Resta, Multiplicacion>();
        }
    }
}

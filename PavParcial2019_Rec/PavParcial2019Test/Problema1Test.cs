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
        public void Test1A()
        {
            LibTests.RunTest1A<Figura>(Problema1.CalcularArea);
        }

        [TestMethod]
        public void Test1B()
        {
            LibTests.RunTest1B<Figura>(Problema1.CalcularArea);
        }

        [TestMethod]
        public void Test1C()
        {
            LibTests.RunTest1C<Figura>(Problema1.CalcularArea);
        }

        [TestMethod]
        public void Test1D()
        {
            LibTests.RunTest1D<Figura>(Problema1.CalcularArea);
        }
    }
}

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
        public void Test5A()
        {
            LibTests.RunTest5A<Empleado>(Problema5.Buscar);
        }

        [TestMethod]
        public void Test5B()
        {
            LibTests.RunTest5B<Empleado>(Problema5.Buscar);
        }

        [TestMethod]
        public void Test5C()
        {
            LibTests.RunTest5C<Empleado>(Problema5.MejoresPagos);
        }

        [TestMethod]
        public void Test5D()
        {
            LibTests.RunTest5D<Empleado>(Problema5.PeoresPagos);
        }
    }
}

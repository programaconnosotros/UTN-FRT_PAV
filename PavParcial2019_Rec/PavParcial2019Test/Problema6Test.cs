using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test6A()
        {
            LibTests.RunTest6A<EntradaTexto>();
        }

        [TestMethod]
        public void Test6B()
        {
            LibTests.RunTest6B<EntradaNumero>();
        }

        [TestMethod]
        public void Test6C()
        {
            LibTests.RunTest6C<EntradaNumero>();
        }

        [TestMethod]
        public void Test6D()
        {
            LibTests.RunTest6D<EntradaTexto>();
        }
    }
}

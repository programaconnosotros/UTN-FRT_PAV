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
        public void Test15()
        {
            LibTests.RunTest15(Assembly.LoadFrom("PavParcial2019.exe"));
        }

        [TestMethod]
        public void Test16()
        {
            LibTests.RunTest16(Assembly.LoadFrom("PavParcial2019.exe"));
        }

        [TestMethod]
        public void Test17()
        {
            LibTests.RunTest17(Assembly.LoadFrom("PavParcial2019.exe"));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavParcial2019Test
{
    [TestClass]
    public partial class ProblemasTest
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            LibTests.Inicializar(Datos.Legajo, Datos.Apellidos, Datos.Nombres);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            MessageBox.Show(LibTests.Resultado());
        }

        [TestMethod]
        public void Inicial()
        {
            Assert.IsTrue(true);
        }
    }
}

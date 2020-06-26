using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PavParcial2019;
using PavParcial2019Lib;

namespace PavParcial2019Test
{
    public partial class ProblemasTest
    {
        [TestMethod]
        public void Test7A()
        {
            LibTests.RunTest7A<EnteRecaudador, PersonaFisica, PersonaJuridica, Inmueble, Organizacion, Impuesto, Tasa, Contribucion, Tributo>();
        }
    }
}

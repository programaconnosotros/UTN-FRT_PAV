using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosyFuncionesLambda
{
    public class Empaquetador : Maquina
    {
        public Empaquetador() : base()
        {

        }

        public override void IniciarMaquinaria()
        {
            Console.WriteLine("Inicie el Empaquetador");
        }
    }
}

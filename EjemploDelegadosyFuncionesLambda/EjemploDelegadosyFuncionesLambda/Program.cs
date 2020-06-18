using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosyFuncionesLambda
{
    class Program
    {

        static void Main(string[] args)
        {
            //Instanciamos la fabrica de pastas
            var fabricaPastas = new FabricaPastas();
            var cortadorFideos = new CortadorFideos();
            var empaquetador = new Empaquetador();
            var empleado = new Empleado();

            //Agregar las maquinas  a la fabrica de pastas

            fabricaPastas.AgregarMaquina(cortadorFideos);
            fabricaPastas.AgregarMaquina(empaquetador);
            fabricaPastas.AgregarEmpleado(empleado);

            fabricaPastas.ComenzarFabricacion();

            Console.ReadKey();
        }
    }
}

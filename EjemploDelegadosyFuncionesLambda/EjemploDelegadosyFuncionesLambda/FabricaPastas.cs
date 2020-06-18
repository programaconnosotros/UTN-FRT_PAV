using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void delegado_fabrica();

namespace EjemploDelegadosyFuncionesLambda
{
    public class FabricaPastas
    {
        //definicion del delegado
       

        public  delegado_fabrica IniciadorMaquinas; 
        

        public FabricaPastas()
        {
           
        }

        public void ComenzarFabricacion()
        {
            IniciadorMaquinas();
        }
        public void AgregarMaquina(Maquina maquina)
        {
            IniciadorMaquinas += maquina.IniciarMaquinaria;
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            IniciadorMaquinas += empleado.EmpezarATrabajar;
        }
       
        

    }
}

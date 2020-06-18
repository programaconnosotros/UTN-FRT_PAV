using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncionesLambda
{
    public class Estudiante
    {
        public String  Nombre { get; set; }
        public double Promedio { get; set; }

        public Estudiante(String nombre , double promedio)
        {
            this.Nombre = nombre;
            this.Promedio = promedio;
        }
    }
}

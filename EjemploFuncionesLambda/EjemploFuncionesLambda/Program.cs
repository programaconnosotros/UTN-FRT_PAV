using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            estudiantes.Add(new Estudiante("Mauro", 8));
            estudiantes.Add(new Estudiante("Ian", 7));
            estudiantes.Add(new Estudiante("Tamara", 10));
            estudiantes.Add(new Estudiante("Franco", 10));
            estudiantes.Add(new Estudiante("Luciano", 6));
            estudiantes.Add(new Estudiante("Chelo", 3));
            estudiantes.Add(new Estudiante("Mauricio", -1));

            //Mostrar estudiantes que tiene promedio >  5
            Console.WriteLine("Estudiantes con promedio mayor a 5");

            var estudiantesConPromedioMayorA5 = estudiantes.Where(estudiante => estudiante.Promedio > 5).OrderBy(estudiante => estudiante.Nombre);

            foreach (Estudiante e in estudiantesConPromedioMayorA5) Console.WriteLine(e.Nombre);

            //Buscar un Estudiante por su nombre

            Console.WriteLine("Ahora voy a buscar un estudiante por su nombre");
            String nombreABuscar = Console.ReadLine().ToString();

            var estudianteBuscado = estudiantes.Find(e => {
                return e.Nombre.Equals(nombreABuscar);

            });

            Console.WriteLine("Nombre del estudiante: " + estudianteBuscado.Nombre);
            Console.WriteLine("Promedio del estudiante: " + estudianteBuscado.Promedio.ToString());



            Console.ReadKey();
        }
    }
}

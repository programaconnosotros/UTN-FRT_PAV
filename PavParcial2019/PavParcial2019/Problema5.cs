using System;
using System.Collections.Generic;
using System.Linq;

namespace PavParcial2019
{
    /*
     * Problema N° 5
     * Puntuación: 1.5
     * Cantidad de Pruebas: 3 (cada una 0.5)
     * Crear la clase Empleado con los siguientes atributos:
     * - Nombre (string)
     * - Legajo (int)
     * - Sueldo (double)
     * Crear un método estático "Evaluador" que reciba una lista de personas y devuelva un array con valores
     * La lista que se envíe al método puede ser de cualquiera de los tipos enumerables que posee el framework
     * El método debe obtener los siguientes datos:
     * - El monto máximo que se paga a un empleado
     * - El monto mínimo que se paga a un empleado
     * - El promedio de los sueldos
     * - La suma de todos los sueldos
     * El orden de los valores en el array resultante debe responder a la secuencia anterior.
     * Restricción: 
     * -La clase Empleado debe tener un constructor que reciba tres parámetros, uno por cada propiedad
     * Tiempo estimado: 15m
     */
    public class Empleado
    {
        public String Nombre { get; set; }
        public int Legajo { get; set; }
        public double Sueldo { get; set; }

        public Empleado(String nombre, int legajo, double sueldo)
        {
            Nombre = nombre;
            Legajo = legajo;
            Sueldo = sueldo;
        }

    }

    public class Problema5
    {
        public static double[] Evaluador(System.Collections.Generic.IEnumerable<Empleado> lista)
        {
            if(lista == null)
            {
                return null;
            }

            List<double> resultados = new List<double>();
            resultados.Add(lista.Max(e => e.Sueldo));
            resultados.Add(lista.Min(e => e.Sueldo));
            resultados.Add(lista.Average(e => e.Sueldo));
            resultados.Add(lista.Sum(e => e.Sueldo));

            return resultados.ToArray();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PavParcial2019
{
    /*
     * Problema N° 5
     * Puntuación: 1
     * Cantidad de Pruebas: 4 (cada una 0.25)
     * Crear la clase Empleado con los siguientes atributos:
     * - Nombre (string)
     * - Legajo (int)
     * - Sueldo (double)
     * Crear los siguientes métodos estáticos:
     * - "Buscar": recibe un legajo y retorna el empleado que coincide con ese número
     * - "MejoresPagos": devuelve los empleados con el sueldo superior a la media
     * - "PeoresPagos": devuelve los empleados con el sueldo en la media o inferior a la media
     * En todos los casos, el método recibe cualquiera de los tipos enumerables que posee el framework.
     * Restricción: 
     * -La clase Empleado debe tener un constructor que reciba tres parámetros, uno por cada propiedad
     * Tiempo estimado: 15m
     */
    public class Problema5
    {
        public static Empleado Buscar(IEnumerable<Empleado> lista, int? leg)
        {

            foreach (Empleado emp in lista)
            {
                if (emp.Legajo == leg)
                {
                    return emp;

                }

            }
            return null;
        }
        public static List<Empleado> MejoresPagos(IEnumerable<Empleado> lista)
        {
            double media = lista.Average(p => p.Sueldo);
    
             List<Empleado> listaNueva = new List<Empleado>();
              foreach(Empleado emp in lista)
            {
                if (emp.Sueldo > media) listaNueva.Add(emp);
            }

            return listaNueva;
        } 
        public static List<Empleado> PeoresPagos(IEnumerable<Empleado> lista)
        {
            double media = lista.Average(p => p.Sueldo);

            List<Empleado> listaNueva = new List<Empleado>();
            foreach (Empleado emp in lista)
            {
                if (emp.Sueldo <= media) listaNueva.Add(emp);
            }

            return listaNueva;
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        public double Sueldo { get; set; }

        public Empleado(string nombre, int legajo, double sueldo)
        {
            Nombre = nombre;
            Legajo = legajo;
            Sueldo = sueldo;
        }


    }
}

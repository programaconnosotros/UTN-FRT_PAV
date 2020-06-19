using System;
using System.Collections.Generic;

namespace PavParcial2019
{
    /*
     * Problema N° 7
     * Puntuación: 2.5
     * Cantidad de Pruebas: 2 (cada una 1.25)
     * Dadas las siguientes clases, realizar los cambios necesarios para cumplir con el objetivo de que
     * la lista en la clase Flota puedan ser ordenada
     * Restricciones:
     * - El método Ordenar no se puede modificar
     * - No se pueden agregar métodos a la clase Flota
     * - La propiedad Lista de flota nunca es nula
     * - Los transportes se ordenan primero según el Tipo (de forma alfabética ascendente) y luego por la Antigüedad (ascendente)
     *   por ej: dada la lista [{Omnibus,5} {Avion,8} {Avion,3}] ordenada es: [{Avion,3} {Avion,8} {Omnibus,5}]
     * Tiempo estimado: 20m
     */

    public class Flota
    {
        public List<Transporte> Lista { get; }

        public Flota(IEnumerable<Transporte> transportes)
        {
            
        }

        //Este método no se puede modificar
        public void Ordenar()
        {
            Lista.Sort();
        }
    }

    public class Transporte
    {
        public Transporte(Tipo tipo, int antiguedad)
        {
            Tipo = tipo;
            Antiguedad = antiguedad;
        }

        public Tipo Tipo { get; set; }
        public int Antiguedad { get; set; }
    }

    public enum Tipo
    {
        Omnibus = 1,
        Avion
    }
}

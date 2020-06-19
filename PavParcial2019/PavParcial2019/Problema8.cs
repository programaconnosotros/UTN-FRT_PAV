using System;

namespace PavParcial2019
{
    /*
    * Problema N° 8
    * Puntuación: 1
    * Cantidad de Pruebas: 1 
    * Dadas las siguientes clases, realizar los cambios necesarios para cumplir con el objetivo de que
    * el valor enviado al método Ejecutar resuelte en las operaciones de suma, resta y multiplicación
    * Cada operación se realizará utilizando el valor a operar (ValorAOperar) en cada clase.
    * Ejemplo:
    * La clase Suma se inicializa con 10, la clase Resta se inicializa con 5, la clase Multiplicacion se inicializa con 8
    * Si se invoca al método Ejecutar con el valor 3, entonces el resultado debería ser 64 ((3 + 10 - 5) * 8)
    * Restricciones:
    * - Resolver utilizando delegados
    * Tiempo estimado: 12m
    */

    public class Operacion
    {
        public delegate void OperacionDelegado(ref int numero);

        public Operacion(Suma suma, 
            Resta resta, 
            Multiplicacion multiplicacion)
        {
        
        }

        public int Ejecutar(int valor)
        {
            return valor;
        }
    }

    public abstract class Operador
    {
        protected int ValorAOperar { get; set; }

        public Operador(int valorAOperar)
        {
            ValorAOperar = valorAOperar;
        }
    }

    public class Suma: Operador
    {
        public Suma(int n):base(n)
        {
            
        }
    }

    public class Resta: Operador
    {
        public Resta(int n) : base(n)
        {

        }
    }

    public class Multiplicacion: Operador
    {
        public Multiplicacion(int n) : base(n)
        {

        }
    }
}

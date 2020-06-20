using System;
using System.Collections.Generic;

namespace PavParcial2019
{
    /*
     * Problema N° 6
     * Puntuación: 1.5
     * Cantidad de Pruebas: 3 (cada una 0.5)
     * Crear una clase llamada Pila que permita generar una lista de elementos de cualquier tipo
     * donde el último en ingresar sea el primero en salir (LIFO).
     * La clase debe contar con los siguientes métodos:
     * - Apilar, para agregar nuevos elementos a la pila
     * - Apilar, sobrecargado, parar agregar un array de elementos a la pila
     * - Retirar, para extraer el elemento en el tope de la pila
     * Si la pila se encuentra vacía se debe retornar el valor por defecto correspondiente al tipo.
     * Tiempo estimado: 15m
     */

    public class Pila<Etiqueta>{

        public Stack<Etiqueta> Stack{ get; set; }

        public Pila()
        {
            this.Stack = new Stack<Etiqueta>();
        }

        public void Apilar(Etiqueta objeto)
        {
            Stack.Push(objeto);
        }
        public void Apilar(Etiqueta[] objetos)
        {
            foreach (Etiqueta objeto in objetos) Stack.Push(objeto);
        }
        public Etiqueta Retirar()
        {
            try
            {
                return Stack.Pop();
            }
            catch(Exception e)
            {
                return default(Etiqueta);
            }
            
        }



    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV_Practica_9_Julio
{
    /* Problema N° 3 
    * Puntuación: 1 
    * Cantidad de Pruebas: 5 (cada una 0.2) 
    * Mínimo de pruebas requeridas: 4 
    *
    * Crear un método de extensión llamado Jugar para el tipo List<>
    * según se requiera en este caso. 
    * El método debe poder recibir como argumento el método Competir definido en el
    * problema. 
    *
    * El método Competir debe contener la lógica para resolver el juego
    * Piedra, Papel o Tijera entre dos jugadores. 
    *
    * El método de extensión debe contener la lógica para determinar cuál de todos
    * los jugadores en la lista es el ganador.Para esto se debe hacer jugar los dos 
    * primeros de la lista, el ganador de esos juega con el siguiente de la lista y
    * así sucesivamente hasta llegar al final. 
    *
    * En caso que los competidores elijan la misma opción gana el que se encuentre primero
    * en la lista. 
    *
    * Aclaración: la clase Jugador tiene un número que lo identifica y su opción 
    * (piedra, papel o tijera). 
    * Los valores están definidos en la enumeración Opciones.
    * La clase Jugador, la enumeración y el delegado se encuentran en la librería.
    * El método de extensión debe estar en la clase Extension
    * Tiempo estimado: 15m 
    */
    public class Problema_3
    {
        public delegate Jugador Delegado(Jugador jugador1, Jugador jugador2);
        public static Jugador Jugar(List<Jugador> jugadores, Delegado delegado)
        {
            Jugador jugadorGanador = jugadores.ElementAt(0);

            for(int i = 1; i<jugadores.Count; i++)
            {
                jugadorGanador = delegado(jugadorGanador, jugadores.ElementAt(i));
            }

            return jugadorGanador;
        }

        public Jugador Competir(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1.Opcion == Opcion.PIEDRA && jugador2.Opcion == Opcion.PAPEL)
            {
                return jugador2;
            }
            else if(jugador1.Opcion == Opcion.TIJERA && jugador2.Opcion == Opcion.PIEDRA)
            {
                return jugador2;
            }
            else if(jugador1.Opcion == Opcion.PAPEL && jugador2.Opcion == Opcion.TIJERA)
            {
                return jugador2;
            }
            else if(jugador1.Opcion == Opcion.PAPEL && jugador2.Opcion == Opcion.PIEDRA)
            {
                return jugador1;
            }
            else if(jugador1.Opcion == Opcion.PIEDRA && jugador2.Opcion == Opcion.TIJERA)
            {
                return jugador1;
            }
            else if(jugador1.Opcion == Opcion.TIJERA && jugador2.Opcion == Opcion.PAPEL)
            {
                return jugador1;
            }

            return jugador1;
        }
    }

    public class Jugador
    {
        public Jugador(int Id, Opcion Opcion)
        {
            this.Id = Id;
            this.Opcion = Opcion;
        }
        public int Id { get; set; }
        public Opcion Opcion { get; set; }
    }

    public enum Opcion
    {
        PIEDRA,
        PAPEL,
        TIJERA
    }

}

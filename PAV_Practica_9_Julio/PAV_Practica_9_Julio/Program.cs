using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV_Practica_9_Julio
{
    class Program
    {
        static void Main(string[] args)
        {
            Problema_3 problema = new Problema_3();

            Jugador jugadorGanador = Problema_3.Jugar(new List<Jugador>() { new Jugador(1, Opcion.PAPEL), new Jugador(2, Opcion.PIEDRA)
            , new Jugador(3, Opcion.TIJERA), new Jugador(4, Opcion.PAPEL), new Jugador(5, Opcion.PIEDRA)},
            problema.Competir);

            Console.WriteLine(jugadorGanador.Id.ToString());
            Console.ReadKey();
        }
    }
}

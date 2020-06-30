using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ParcialPAV
{
    /*
    * Problema N° 5
     * Puntuación: 2
     * Cantidad de Pruebas: 5 (cada una 0.4)
     * Mínimo de Pruebas Requeridas: 4
     *
     * En un hotel hay un ascensor y una fila de personas que esperan en la planta baja(piso 0)
     * para subirse a él.
     * Cada persona tiene un peso determinado y el piso al que quiere ir.
     * Las personas suben por orden de llegada.
     * El ascensor tiene un límite de personas por cantidad y por peso.
     * Calcular la cantidad de paradas que tendrá que hacer el ascensor en total
     * teniendo en cuenta que luego de vaciarse el ascensor siempre vuelve a planta baja y esto 
     * cuenta como una parada.
     *
     * Crear un método "CalcularParadasAscensor" que reciba una lista de personas,
     * un doble representando el límtite de paso y un entero representando el límite de personas
     * y además que retorne un entero representando la cantidad de paradas.
     *
     * Aclaración: clase persona definida en PavParcial.Library.Data
     * Tiempo estimado: 35m
     * 
     * INTERPRETO QUE CUANDO SE SUPERA EL LIMITE DE PESO O PERSONAS, ESAS PERSONAS NO SUBEN AL ASCENSOR Y NO SE
     * INCLUYEN PARA LO QUE RESTA DEL EJERCICIO.
     * 
     * No lo probé, pero va por ahí la cosa
     */
    public class Ejercicio5
    {
        public int CalcularParadasAcensor(List<Persona> listaPersonas, double limitePeso, int limitePersonas)
        {
            List<Persona> personasEnElAscensor = new List<Persona>();
            double pesoAscensor = 0;
            int contadorPersonas = 0;
            int cantidadParadas = 1;
            int ultimoPisoVisitado = 0;

            try
            {
                foreach (var persona in listaPersonas)
                {
                    if (contadorPersonas <= limitePersonas)
                    {
                        if (pesoAscensor <= (limitePeso + persona.Peso))
                        {
                            pesoAscensor += persona.Peso;
                            personasEnElAscensor.Add(persona);
                            contadorPersonas++;
                        }

                    }
                }

                personasEnElAscensor = personasEnElAscensor.OrderBy(x => x.PisoDeseado).ToList();

                foreach (var persona in personasEnElAscensor)
                {
                    if (ultimoPisoVisitado == persona.PisoDeseado)
                    {

                    }
                    else
                    {
                        ultimoPisoVisitado = persona.PisoDeseado;
                        cantidadParadas++;
                    }
                }

                return cantidadParadas;
            }
            catch(Exception)
            {
                return 0;
            }
        }
    }

    public class Persona
        {
        public Persona(double peso, int pisoDeseado)
        {
            this.Peso = peso;
            this.PisoDeseado = pisoDeseado;
        }
        public double Peso { get; set; }
        public int PisoDeseado { get; set; }
    }
}

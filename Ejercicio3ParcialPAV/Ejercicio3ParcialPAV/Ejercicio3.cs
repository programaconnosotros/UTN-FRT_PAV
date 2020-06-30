using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ParcialPAV
{
    /*Problema N° 3
     * Puntuación: 1
     * Cantidad de Pruebas: 4 (cada una 0.25)
     * Mínimo de Pruebas Requeridas: 3
     *
     * Una brecha binaria dentro de un entero positivo N es cualquier secuencia máxima de ceros
     * consecutivos que está rodeada por unos en ambos extremos en la representación binaria de N.
     * Por ejemplo, el número 9 tiene representación binaria 1001 y contiene un espacio binario de 
     * longitud 2. El número 529 tiene representación binaria 1000010001 y contiene dos espacios 
     * binarios: uno de longitud 4 y uno de longitud 3. El número 20 tiene representación binaria
     * 10100 y contiene un espacio binario de longitud 1. El número 15 tiene una representación
     * binaria 1111 y no tiene espacios binarios.El número 32 tiene una representación binaria 
     * de 100000 y no tiene huecos binarios.
     *
     * Crear un método eficiente "EncontrarBrechaMaxima" que reciba un entero (N) y devuelva la longitud
     * de su brecha binaria más larga.El método debe devolver 0 si N no contiene un espacio binario.
     * Por ejemplo, dado N = 1041, la función debería devolver 5, porque N tiene representación 
     * binaria 10000010001 y, por lo tanto, su espacio binario más largo es de longitud 5. 
     * Dado N = 32, la función debería devolver 0, porque N tiene representación binaria '100000' y,
     * por lo tanto, sin huecos binarios.
     *
     * Tiempo estimado: 20m
     */

    public class Ejercicio3
    {

        public int EncontrarBrechaMaxima(int numero)
        {
            char[] vectorBinario = Convert.ToString(numero, 2).ToCharArray();
            int longitudBrechaMasLarga = 0;
            int longitudBrechaActual = 0;

            for(int i = 0; i<vectorBinario.Length; i++)
            {
                if(vectorBinario.GetValue(i).Equals('0'))
                {
                    longitudBrechaActual++;
                }
                else if (vectorBinario.GetValue(i).Equals('1'))
                {
                    if(longitudBrechaActual > longitudBrechaMasLarga)
                    {
                        longitudBrechaMasLarga = longitudBrechaActual;
                        longitudBrechaActual = 0;
                    }
                }
            }

            return longitudBrechaMasLarga ;
        }

    }
}

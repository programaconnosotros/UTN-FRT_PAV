using System;

namespace PavParcial2019
{
    /*
     * Problema N° 1
     * Puntuación: 0.5
     * Cantidad de Pruebas: 2 (cada una 0.25)
     * Crear un método "Calcular" que reciba 3 parametros y retorna un resultado
     * Los dos primeros son números (obligatorios), el tercero es texto y representa el operador (opcional) si no se proporciona se asume que es una suma 
     * El método puede realizar sumas, restas, multiplicaciones y divisiones (si no se reconoce el operador retorna la suma)
     * El método no debe generar excepciones por división en 0 y usar un tipo de dato de 64 bits.
     * Tiempo estimado: 5m
     */
    public class Problema1
    {
        public static double Calcular(double numero1, double numero2, String operador="+")
        {
             if(operador == "-")
            {
                return numero1 - numero2;
            }
            else if (operador == "/")
            {
                try
                {
                    return numero1 / numero2;
                }
                catch(Exception e)
                {
                    return 0;
                }
            }
            else if(operador == "*")
            {
                return numero1* numero2;
            }
            else
            {
               return numero1 + numero2;
            }
        }
        
    }
}

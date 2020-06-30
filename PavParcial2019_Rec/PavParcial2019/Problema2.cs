using System;

namespace PavParcial2019
{
    /*
     * Problema N° 2
     * Puntuación: 1
     * Cantidad de Pruebas: 4 (cada una 0.25)
     * Crear un método estático "CalcularPrecioFinal" que reciba 3 parametros dobles
     * Los parámetros son precio neto, impuesto y precio final.
     * El precio neto y el precio final son nuleables.
     * Si se proporciona el precio neto, entonces se debe calcular el precio final (y retornar sobre éste).
     * Si se proporciona el precio final, entonces se debe calcular el precio neto (y retornar sobre éste).
     * Si se proporcionan los dos, igual se calcula el precio final.
     * Aclaración: el valor del impuesto corresponde a un porcentaje.
     * Tiempo estimado: 10m
     */
    public class Problema2
    {
        public static void CalcularPrecioFinal(ref double? neto, double impuesto,ref double? final)
        {
            
            if (neto !=null && final==null){
                final = neto + (neto * impuesto / 100);
            }
            else if (final != null && neto == null)
            {
                neto = final / (1 + impuesto / 100);
            }
            else 
            {
                final = neto + (neto * impuesto / 100);
                
            }
        }
    }
}

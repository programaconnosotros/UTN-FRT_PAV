using System;

namespace PavParcial2019
{
    /*
     * Problema N° 1
     * Puntuación: 1
     * Cantidad de Pruebas: 4 (cada una 0.25)
     * Crear un método estático "CalcularArea" que reciba 3 parametros y retorna un resultado (el área)
     * El primer número es obligatorio, el segúndo también es número pero opcional y nuleable, el tercero es del tipo Enum y también es opcional.
     * El tercer parámetro debe ser nuleable y si toma el valor null, el resultado del cálculo también es null.
     * El método debe calcular el área de las figuras representadas en la enumeración.
     * El método no debe generar excepciones y usar un tipo de dato punto flotante de 128 bits.
     * Ayuda: Enum es el tipo base que da origen a las enumeraciones
     * Tiempo estimado: 10m
     */
    public class Problema1
    {
        public static decimal? CalcularArea(decimal a, decimal? b, Enum c)
        {
            decimal resultado = 0;
            if (c == null)
            {
                return null;
            }
            else
            {
                if ((Figura)c == Figura.Circulo)
                {
                    decimal resultadoc = (decimal)Math.PI * a * a;
                    resultado = resultadoc;
                }
                else if ((Figura)c == Figura.Rectangulo)
                {
                    decimal resultador = (decimal)b * a;
                    resultado = resultador;
                }
                else if ((Figura)c == Figura.Triangulo)
                {
                    decimal resultadot = (decimal)b * a / 2;
                    resultado = resultadot;
                }
            }
            return resultado;

        }
    }

}

    //La enumeración no se puede modificar
    public enum Figura
    {
        Circulo = 1,
        Triangulo,
        Rectangulo
    }


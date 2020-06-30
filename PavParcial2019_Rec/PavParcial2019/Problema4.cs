using System;
using System.Linq;
namespace PavParcial2019
{
    /*
     * Problema N° 4
     * Puntuación: 1.5
     * Cantidad de Pruebas: 5 (cada una 0.30)
     * Crear un método estático "Reemplazar" que reciba una cadena y un número variable de objetos.
     * La cadena recibida funciona como una máscara, donde el caracter # debe reemplazarse por los objetos enviados.
     * El método debe retornar la cadena con los valores reemplazados.
     * Si no hay coincidencia entre los caracteres a reemplazar y los objetos recibidos se debe retornar null.
     * Tiempo estimado: 15m
     */
    public class Problema4
    {
        public static string Reemplazar(string a, params object[] b)
        {
            string resultado = a;
            int ban = 0;
            foreach(object objeto in b)
            {
                if (a.Contains('#'))
                {
                    resultado = a.Insert(a.IndexOf('#'), objeto.ToString());
                    ban = 1;
                }
            }
            if (ban == 0)
            {
                return null;
            }
            else
            {
                return resultado;
            }
        }
    }
}

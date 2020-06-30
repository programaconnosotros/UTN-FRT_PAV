using System;

namespace PavParcial2019
{
    /*
     * Problema N° 3
     * Puntuación: 1
     * Cantidad de Pruebas: 5 (cada una 0.20)
     * Crear un método estático "CalcularYMostrar" que reciba 3 cadenas y 1 decimal, y retorna una cadena 
     * El primer parámetro, aunque es una cadena, representa a un número
     * El segundo parámetro, aunque es una cadnea, representa a un número
     * El tercer parámetro representa a un operador (solo se permiten +, -, * y /)
     * El método debe evaluar el tipo de operación y calcular la operación correspondiente.
     * El resultado, en decimal, de la operación se debe retornar en el parámetro del mismo tipo.
     * El método retorna una cadena con la representación de la operación, por ejemplo: "10+20=30" (sin espacios)
     * Se deben contemplar situaciones que puedan generar errores en las operaciones o situaciones con operadores no soportados
     * En cualquiera de las situaciones anómalas el método debe retornar el texto "Operacion no valida" (sin acentos)
     * Tiempo estimado: 15m
     */
    public class Problema3
    {
        public static string CalcularYMostrar(string nro1, string nro2, string op, ref decimal res)
        {
            try
            {
                var a = nro1.Replace('.', ',');
                var numero1 = decimal.Parse(a);
                var numero2 = decimal.Parse(nro2);

                switch (op)
                {
                    case ("+"):
                        res = numero1 + numero2;
                        break;

                    case ("-"):
                        res = numero1 - numero2;
                        break;

                    case ("*"):
                        res = numero1 * numero2;
                        break;

                    case ("/"):

                        res = numero1 / numero2;
                        break;
                    default:
                        return "Operacion no valida";

                }
                return $"{numero1}{op}{numero2}={res}";
            }
            catch
            {
                return "Operacion no valida";
            }
        }
    }
}

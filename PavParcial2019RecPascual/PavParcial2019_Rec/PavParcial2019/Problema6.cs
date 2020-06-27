using System;

namespace PavParcial2019
{
    /*
    * Problema N° 6
    * Puntuación: 1
    * Cantidad de Pruebas: 4 (cada una 0.25)
    * Una solución se implementará con dos clases: EntradaTexto (que acepta todos los caracteres) y 
    * EntradaNumero (que solo acepta numeros).
    * La clase EntradaTexto que tiene:
    *      -Un método publico void Add(string c) -> va acumulando las cadenas ingresadas
    *      -Un método publico string GetValue() -> retorna la cadena acumulada
    * La classe EntradaNumero que:
    *      -Hereda de EntradaTexto
    *      -Sobreescribe el método Add para descartar lo que no sea numero
    * Especial: si se agrega una cadena nula, entonces el resultado será nulo, sin importar lo que se agregue después
    * Ejemplo 1: 
    *      var entrada = new EntradaNumero();
           entrada.Add("05");
           entrada.Add("AA");
           entrada.Add("2018");
    *      Resultado: "052018"
    * Ejemplo 2: 
    *      var entrada = new EntradaNumero();
           entrada.Add("05");
           entrada.Add(null);
           entrada.Add("2018");
    *      Resultado: null
    * Tiempo estimado: 15m
    */
    public class EntradaTexto
    {
        public bool match = true;
        public string lista = null;

        public virtual void Add(string c)
        {

            if (match)
            {
                if (c == null)
                {
                    match = false;
                    lista = null;
                }
                else
                {
                    lista += c;
                }
            }
        }
    
        public virtual string GetValue()
        {
            return lista;
        }
    }

    public class EntradaNumero : EntradaTexto
    {
        //public bool match = true;

        public override void Add(string c)
        {

            if (match)
            {
                if (c == null)
                {
                    match = false;
                    lista = null;
                }
                else
                {
                    try
                    {
                        int numero = int.Parse(c);
                        lista += c;
                    }
                    catch
                    {

                    }

                }
            }    
        }
    }
}

    


using System;
using System.Collections.Generic;

namespace PavParcial2019
{
    /*
    * Problema N° 7
    * Puntuación: 2.5
    * Cantidad de Pruebas: 1 
    * Dadas las siguientes clases, realizar los cambios necesarios para cumplir con el objetivo de que:
    * El Ente Recaudador sea el encargado de liquidar los tributos de diferentes entidades:
    *  -Personas Físicias
    *  -Personas Jurídicas
    *  -Inmuebles
    *  -Organizaciones
    * A cada una de las entidades les corresponden diferentes tributos:
    *  -Personas Físicias tributan Impuestos
    *  -Personas Jurídicas tributan Impuestos y Tasas
    *  -Inmuebles tributan Tasas
    *  -Organizaciones tributan Contribuciones
    * Cada entidad es la encargada de generar los tributos que le corresponden
    * El Ente Recaudador realiza la liquidación de los tributos cuando se invoca al método LiquidarTributos
    * Tiempo estimado: 20m
    */

    public delegate void LiquidadorDelegado(Action<Func<Tributo>> tributo);

    public interface ICalculador<T>
        where T: Tributo
    {
        void GenerarTributo(Action<Func<T>> generar);
    }

    public class EnteRecaudador
    {
        private LiquidadorDelegado _liquidador;
        private List<Tributo> _tributos = new List<Tributo>();

        public List<Tributo> Tributos => _tributos;

        //Completar, no se puede modificar la firma
        public void SetContribuyente<T>(ICalculador<T> contribuyente)
            where T: Tributo
        {
            
        }

        //Completar, no se puede modificar la firma
        public void LiquidarTributos()
        {

        }

        //Completar, no se puede modificar la firma
        private void AcumularTributosGenerados(Func<Tributo> acumular)
        {
            
        }
    }

    //Completar
    public class PersonaFisica : Contribuyente
    {
        public PersonaFisica(long cuit, double ingresos)
        {
            Cuit = cuit;
            Ingresos = ingresos;
        }
        public long Cuit { get; set; }
        public double Ingresos { get; set; }
    }

    //Completar
    public class PersonaJuridica : Contribuyente
    {
        public PersonaJuridica(long cuit, double ingresos, double montoContratoSocial)
        {
            Cuit = cuit;
            Ingresos = ingresos;
            MontoContratoSocial = montoContratoSocial;
        }
        public long Cuit { get; set; }
        public double Ingresos { get; set; }
        public double MontoContratoSocial { get; set; }
    }

    //Completar
    public class Inmueble : Contribuyente
    {
        public Inmueble(int numeroPadron, double valorFiscal)
        {
            NumeroPadron = numeroPadron;
            ValorFiscal = valorFiscal;
        }
        public int NumeroPadron {get;set;}
        public double ValorFiscal { get; set; }
    }

    //Completar
    public class Organizacion : Contribuyente
    {
        public Organizacion(int numeroRegistro, double aporteMensual)
        {
            NumeroRegistro = numeroRegistro;
            AporteMensual = aporteMensual;
        }
        public int NumeroRegistro { get; set; }
        public double AporteMensual { get; set; }
    }

    #region No requieren cambios
    public abstract class Tributo
    {
        public double Monto { get; set; }
        public Contribuyente Contribuyente { get; set; }
    }
    public abstract class Contribuyente { }

    public class Impuesto : Tributo
    {
        private double _porcentaje = 0.05;

        public Impuesto(Contribuyente contribuyente, double importe)
        {
            Contribuyente = contribuyente;
            Monto = importe * _porcentaje;
        }
    }

    public class Tasa : Tributo
    {
        private double _porcentaje = 0.03;

        public Tasa(Contribuyente contribuyente, double valorFiscal)
        {
            Contribuyente = contribuyente;
            Monto = valorFiscal * _porcentaje;
        }
    }

    public class Contribucion : Tributo
    {
        public Contribucion(Contribuyente contribuyente, double monto)
        {
            Contribuyente = contribuyente;
            Monto = monto;
        }
    }
    #endregion
}
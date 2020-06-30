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
    //funcion1(funcion2(funcion que devuelve un tributo) tributo)

    public interface ICalculador<T>
        where T: Tributo
    {
        void GenerarTributo(Action<Func<T>> generar);
    }

    public class EnteRecaudador
    {
        //Instanciado
        private LiquidadorDelegado _liquidador;
        private List<Tributo> _tributos = new List<Tributo>();

        public List<Tributo> Tributos => _tributos;

        //Completar, no se puede modificar la firma
        public void SetContribuyente<T>(ICalculador<T> contribuyente)
            where T: Tributo
        {
            //Suscripcion del delegado
            _liquidador += contribuyente.GenerarTributo;
        }

        //Completar, no se puede modificar la firma
        public void LiquidarTributos()
        {
            //Ejecucion del delegado
            _liquidador(this.AcumularTributosGenerados);
        }

        //Completar, no se puede modificar la firma
        private void AcumularTributosGenerados(Func<Tributo> acumular)
        {
            _tributos.Add(acumular()); 
        }
    }

    //Completar
    public class PersonaFisica : Contribuyente, ICalculador<Impuesto>
    {
        public PersonaFisica(long cuit, double ingresos)
        {
            Cuit = cuit;
            Ingresos = ingresos;
        }
        public long Cuit { get; set; }
        public double Ingresos { get; set; }

        public void GenerarTributo(Action<Func<Impuesto>> generar)
        {
            var impuesto = new Impuesto(this, this.Ingresos);
            generar(Crear);
        }
        public Impuesto Crear()
        {
            return new Impuesto(this, this.Ingresos);
        }
    }

    //Completar
    public class PersonaJuridica : Contribuyente, ICalculador<Impuesto>, ICalculador<Tasa>
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

        public void GenerarTributo(Action<Func<Impuesto>> generar)
        {
            generar(CrearImpuesto);
           
        }
        public void GenerarTributo(Action<Func<Tasa>> generar)
        {
            generar(CrearTasa);
        }
        public Impuesto CrearImpuesto()
        {
            return new Impuesto(this, this.Ingresos);
        }
        public Tasa CrearTasa(){
            return new Tasa(this,this.MontoContratoSocial);
        }


        

    }

    //Completar
    public class Inmueble : Contribuyente, ICalculador<Tasa>
    {
        public Inmueble(int numeroPadron, double valorFiscal)
        {
            NumeroPadron = numeroPadron;
            ValorFiscal = valorFiscal;
        }
        public int NumeroPadron {get;set;}
        public double ValorFiscal { get; set; }

        public void GenerarTributo(Action<Func<Tasa>> generar)
        {
            generar(CrearTasa);
        }
        public Tasa CrearTasa()
        {
            return new Tasa(this, this.ValorFiscal);
        }
    }

    //Completar
    public class Organizacion : Contribuyente, ICalculador<Contribucion>
    {
        public Organizacion(int numeroRegistro, double aporteMensual)
        {
            NumeroRegistro = numeroRegistro;
            AporteMensual = aporteMensual;
        }
        public int NumeroRegistro { get; set; }
        public double AporteMensual { get; set; }

        public void GenerarTributo(Action<Func<Contribucion>> generar)
        {
            generar(CrearContribucion);
        }
        public Contribucion CrearContribucion()
        {
            return new Contribucion(this, this.AporteMensual);
        }
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
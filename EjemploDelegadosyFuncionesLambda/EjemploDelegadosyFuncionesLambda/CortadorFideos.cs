﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegadosyFuncionesLambda
{
    
    public class CortadorFideos : Maquina
    {
        public CortadorFideos() : base()
        {

        }

        public override void IniciarMaquinaria()
        {
            Console.WriteLine("Inicie el cortador de fideos");
        }

       
        
        
    }
}

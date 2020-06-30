using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ParcialPAV
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            Console.WriteLine(ejercicio3.EncontrarBrechaMaxima(9).ToString());
            Console.ReadKey();
        }
    }
}

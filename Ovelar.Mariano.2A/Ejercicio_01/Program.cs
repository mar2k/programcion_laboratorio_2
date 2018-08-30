using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros.ingresoDeNumeros();
            Numeros.calcularPromedio();
            Numeros.imprimirPorPantalla();

            Console.ReadKey();
        }
    }
}

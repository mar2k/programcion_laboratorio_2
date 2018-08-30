using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Numeros
    {
        #region ATRIBUTOS

        public static Int32 numero;
        public static Int32 acumulador = 0;
        public static Int32 conMax = 5;
        public static Int32 numMax = 0;
        public static Int32 numMin = 0;
        public static Single promedio = 0;

        #endregion

        #region METODOS

        public static void ingresoDeNumeros()
        {
            for (Int32 i = 0; i < conMax; i++)
            {
                Console.Write("INGRESE NUMERO {0}: ", i + 1);

                numero = Int32.Parse(Console.ReadLine());
                if (i == 0)
                {
                    numMax = numero;

                    numMin = numero;
                }
                else
                {
                    if (numero > numMax)
                    {
                        numMax = numero;
                    }
                    else if (numero < numMin)
                    {
                        numMin = numero;
                    }
                }
                Numeros.acumular();
            }
        }

        public static void acumular()
        {
            Numeros.acumulador += Numeros.numero;
        }

        public static void calcularPromedio()
        {
            promedio = (Single)acumulador / (Single)conMax;
        }

        public static void imprimirPorPantalla()
        {
            Console.WriteLine("PROMEDIO ES: {0:#,###.00} \nNUMERO MAX: {1:#,###.00} \nNUMERO MIN: {2:#,###.00}", Numeros.promedio, Numeros.numMax, Numeros.numMin);
        }

        #endregion
    }
}

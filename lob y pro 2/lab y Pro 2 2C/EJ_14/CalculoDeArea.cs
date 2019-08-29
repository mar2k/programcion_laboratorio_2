using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double Base, double altura)
        {
            return (Base * altura) / 2;
        }
        //(A = π r²)
        public static double CalcularCirculo(double radio)
        {
            return Math.PI* Math.Pow(radio, 2);
        }
    }
}

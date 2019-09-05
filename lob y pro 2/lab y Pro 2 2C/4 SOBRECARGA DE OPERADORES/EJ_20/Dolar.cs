﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 Euro equivale a 1,16 dólares 
//1 dólar equivale a 38,33 pesos

namespace Billetes
{
    class Dolar
    {
        private double cantida;
        private static double cotizRespectoDolar;

        private Dolar()
        {
        }

        public Dolar(double cantida)
        {
            this.cantida = cantida;
        }

        public Dolar(double cantida, double cotizRespectoDolar) : this(cantida)
        {
            Dolar.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            
        }
        public static explicit operator Pesos(Dolar d)
        {

        }
        public double GetCantidad()
        {
            return 0;
        }
        public static double GetCotizacion()
        {
            return 0;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d,Euro e)
        {
            if (d is null && e is null)
            {

            }
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d,Pesos p)
        {
            if (d is null && p is null)
            {

            }
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1,Dolar d2)
        {
            if (d1 is null && d2 is null)
            {

            }
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

    }
}

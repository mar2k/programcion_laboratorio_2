using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected string _patente;

        public string Patente
        {
            get { return _patente; }
            //set { _patente = value; }
        }
        protected EMarca _marca;

        public EMarca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        protected sbyte _cantidadRuedas;

        public sbyte CantidadRuedas
        {
            get { return _cantidadRuedas; }
            set { _cantidadRuedas = value; }
        }

        protected double _precio;

        public abstract double Precio
        {
            get;
            set;
        }

        public abstract double CalcularPrecioConIVA();

        public Vehiculo(string patente, sbyte canidadRueda, EMarca marca)
        {
            this.CantidadRuedas = canidadRueda;
            this._patente = patente;
            this.Marca = marca;
        }

        protected string MostrarVehiculo()
        {
            return "Patente: " + this.Patente + " - " + "Marca: " + this.Marca + " - " + "Ruedas: " + this.CantidadRuedas;
        }

        public override string ToString()
        {
            return this.MostrarVehiculo();
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            bool retorno = false;
            if (!Equals(vehiculo1, null) && !Equals(vehiculo2, null))
            {
                if (vehiculo1.CantidadRuedas == vehiculo2.CantidadRuedas && vehiculo1.Marca == vehiculo2.Marca && vehiculo1.Patente == vehiculo2.Patente)
                {
                    retorno = true;
                }

            }
            else if (Equals(vehiculo1, null) && Equals(vehiculo2, null))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
    }
}

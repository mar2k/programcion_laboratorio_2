using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private bool _esIndustrial;

        public bool EsIndustrial
        {
            get { return _esIndustrial; }
            set { _esIndustrial = value; }
        }

        private double _precio;

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this.Codigo = codigo;
            this.EsIndustrial = esIndustrial;
            this.Precio = precio;
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Cocina)
            {
                retorno = (((Cocina)obj) == this);
            }
            return retorno;
        }
        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool retorno = false;
            if (a.Codigo == b.Codigo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return "Código: " + this.Codigo.ToString() + " - Precio: " + this.Precio.ToString() + " - Es industrial? " + this.EsIndustrial.ToString() + "\n";
        }
    }
}

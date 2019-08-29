using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Depósito___Autos
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get { return this._codigo; }  }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }

        public Cocina(int codigo,double precio,bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public override bool Equals(object obj)
        {
            bool retorno = true;

            if (obj is Cocina)
            {
                retorno = false;
            }

            return retorno;
        }


        public static bool operator ==(Cocina a, Cocina b)
        {
            return (a.Codigo == b.Codigo && a.EsIndustrial == b.EsIndustrial && a.Precio==b.Precio);
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "\nCODIGO: " + this.Codigo.ToString() + "--";
            retorno += "\nINDUSTRIAL: " + this.EsIndustrial.ToString() + "--";
            retorno += "PRECIO: " + this.Precio.ToString() + "\n";

            return retorno;
        }


    }
}

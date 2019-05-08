using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        public double PrecioDeExportadores { get { return 0; } }
        public double PrecioDeImportadores { get { return 0; } }
        public double PrecioTotal { get { return 0; } }

        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }
        private Shopping(int capacida) : this()
        {
            this._capacidad = capacida;
        }
        public static string Mostrar(Shopping s)
        {
            string retorno = "";
            foreach (Comercio item in s._comercios)
            {
                if (item is Importador)
                {
                    retorno += ((Importador)item).Mostrar();

                }
                if (item is Exportador)
                {
                    retorno += ((Exportador)item).Mostrar();
                }
                
            }
            return retorno;
        }
        private double ObtenerUnPrecio(EComercio tipoComercio)
        {
            double retorno=0;
            switch (tipoComercio)
            {
                case EComercio.Importador:
                    retorno= this.PrecioDeExportadores;
                    break;
                case EComercio.Exportador:
                    retorno = this.PrecioDeImportadores;
                    break;
                case EComercio.Ambos:
                    retorno = this.PrecioTotal;
                    break;
                default:
                    break;
            }
            return retorno;
        }
        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;
            foreach (Comercio item in s._comercios)
            {
                if (item == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }
        public static Shopping operator +(Shopping s, Comercio c)
        {
            if (s._comercios.Count < s._capacidad && s != c)
            {
                s._comercios.Add(c);
            }
            else
            {
                Console.WriteLine("ya esta el comercio en el shopping");
            }
            return s;
        }

        public static implicit operator Shopping(int capacidad)
        {
            return new Shopping(capacidad);
        }
    }
}

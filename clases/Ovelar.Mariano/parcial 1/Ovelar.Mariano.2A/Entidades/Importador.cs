using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importador:Comercio
    {
        public EPaises paisOrigen;

        public Importador(string nombreComercio, float precioAlquiler, string nombre, string apellido, EPaises paisOrigen) : base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.paisOrigen = paisOrigen;
        }
        public static implicit operator double(Importador n)
        {
            return n._precioAlquiler;
        }
        public string Mostrar()
        {
            return (string)this +"\ntipo: "+ this.paisOrigen.ToString();
        }
        public static bool operator ==(Importador a, Importador b)
        {
            bool retorno = false;
            if (a.paisOrigen == b.paisOrigen && a._comerciante == b._comerciante)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }
    }
}

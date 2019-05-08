using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador:Comercio
    {
        public ETipoProducto tipo;
        
        public Exportador(string nombreComercio,float precioAlquiler,string nombre,string apellido,ETipoProducto tipo):base(precioAlquiler,nombreComercio,nombre,apellido)
        {
            this.tipo = tipo;
        }
        public static implicit operator double(Exportador m)
        {
            return m._precioAlquiler;
        }
        public string Mostrar()
        {
            return (string)this+"\ntipo: "+this.tipo.ToString();
        }
        public static bool operator ==(Exportador a, Exportador b)
        {
            bool retorno = false;
            if (a.tipo == b.tipo && a._comerciante == b._comerciante)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }
    }
}

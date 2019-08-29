using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        private string _nombre;
        private string _apellido;

        public Comerciante(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        public static implicit operator string(Comerciante a)
        {
            return a._nombre + a._apellido;
        }
        public static bool operator ==(Comerciante a, Comerciante b)
        {
            bool retorno=false;
            if(a._nombre==b._nombre&&a._apellido==b._apellido)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Comerciante a, Comerciante b)
        {
            return !(a == b);
        }
    }
}

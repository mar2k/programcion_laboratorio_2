using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (!(c1 is null) && !(c2 is null))
            {
                if (c1.numero== c2.numero)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

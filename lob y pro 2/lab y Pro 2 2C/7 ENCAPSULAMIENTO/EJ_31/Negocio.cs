using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_31
{
    public class Negocio
    {
        private PuestoAtención caja;
        private string nombre;
        private Queue<Cliente> clientes;

        public Cliente Cliente
        {
            get
            {
                if (this.clientes.Count!=0)
                {
                    return this.clientes.Dequeue();
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                if (this != value)
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtención(PuestoAtención.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (!(n is null) && !(c is null))
            {
                foreach (Cliente item in n.clientes)
                {
                    if (item == c)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (!(n is null) && !(c is null))
            {
                if (n != c)
                {
                    n.Cliente = c;
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (!(n is null))
            {
                if (n.caja.Atender(n.Cliente))
                {
                    retorno = true;
                }
            }
            return retorno;
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

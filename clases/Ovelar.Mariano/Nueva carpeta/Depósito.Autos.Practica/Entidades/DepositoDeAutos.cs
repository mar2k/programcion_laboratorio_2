using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Auto a)
        {
            int i = -1;
            int retorno = i;
            foreach (Auto item in this._lista)
            {
                i++;
                if (a.Equals(item))
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public bool Agregar(Auto a)
        {
            return (this + a);
        }
        public bool Remover(Auto a)
        {
            return (this - a);
        }
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = true;

            foreach (Auto item in d._lista)
            {
                if (d._lista.Count >= d._capacidadMaxima || a.Equals(item))
                {
                    retorno = false;
                    break;
                }
            }

            if (retorno)
            {
                d._lista.Add(a);
            }

            return retorno;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice;

            indice = d.GetIndice(a);
            if (indice != -1)
            {
                d._lista.Remove(d._lista[indice]);
                retorno = true;
            }

            return retorno;
        }
        public override string ToString()
        {
            string retorno = "Capacidad maxima: " + this._capacidadMaxima + "\nLista de Auto:\n";
            foreach (Auto item in this._lista)
            {
                retorno += item.ToString();
            }
            return retorno;
        }
    }
}

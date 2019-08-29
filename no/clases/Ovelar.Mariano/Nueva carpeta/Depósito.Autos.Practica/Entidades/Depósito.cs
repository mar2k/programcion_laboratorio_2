using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(T a)
        {
            int i = -1;
            int retorno = i;
            foreach (T item in this._lista)
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

        public bool Agregar(T a)
        {
            return (this + a);
        }
        public bool Remover(T a)
        {
            return (this - a);
        }
        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = true;

            foreach (T item in d._lista)
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
        public static bool operator -(Deposito<T> d, T a)
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
            string retorno = "Capacidad maxima: " + this._capacidadMaxima + "\nLista "+ typeof(T).Name + ":\n";
            foreach (T item in this._lista)
            {
                retorno += item.ToString();
            }
            return retorno;
        }
    }
}

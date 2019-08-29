using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Depósito___Autos
{
    class DepósitoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;



        public static bool operator +(DepósitoDeAutos a, Auto b)
        {
            bool retorno = false;
            if (a._capacidadMaxima < a._lista.Count && b.Equals(b))
            {
                a._lista.Add(b);
                retorno = true;
            }

            return retorno;
        }
        public static bool operator -(DepósitoDeAutos a, Auto b)
        {
            bool retorno = false;
            int indice;
            indice = a.GetIndice(b);

            if (indice != -1)
            {
                a._lista.RemoveAt(indice);
                retorno = true;
            }
         

            return retorno;
        }
        public bool Remover(Auto a)
        {        
            return this - a;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public int GetIndice(Auto a)
        {
            int retorno=-1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (a == this._lista[i])
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;

        }

        public override string ToString()
        {
            string retorno = "";

            foreach(Auto a in this._lista)
            {
               retorno = a.ToString() + "---------";
            }

            return retorno;
        }

    }
}
 /*foreach (Auto aux in a._lista)
            {
                if(b==aux)
                {

                }
            }*/
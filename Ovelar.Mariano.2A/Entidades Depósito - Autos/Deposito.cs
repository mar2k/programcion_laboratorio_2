using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades_Depósito___Autos
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;


        public Deposito(int capasidad)
        {
            this._capacidadMaxima = capasidad;
        }

        public static bool operator +(Deposito<T> a, T b)
        {
            bool retorno = false;
            if (a._capacidadMaxima < a._lista.Count && b.Equals(b))
            {
                a._lista.Add(b);
                retorno = true;
            }

            return retorno;
        }
        public static bool operator -(Deposito<T> a, T b)
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
        public bool Remover(T a)
        {
            return this - a;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public int GetIndice(T a)
        {
            int retorno = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if ((Object)a == (Object)this._lista[i])
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

            foreach (T a in this._lista)
            {
                retorno = a.ToString() + "---------";
            }

            return retorno;
        }

        public bool Guardar(string a)
        {
            bool re = true;
            try
            {
                using (StreamWriter sw = new StreamWriter(a, true))
                {
                    sw.WriteLine(this.ToString());
                }
            }
            catch (Exception)
            {
                re = !re;
            }

            return re;

        }
        public bool Recuperar(string a)
        {
            bool re = true;

            try
            {
                using (StreamReader sw = new StreamReader(a, true))
                {
                    Console.WriteLine(sw.ReadToEnd());
                }
            }
            catch (Exception)
            {
                re = !re;
            }

            return re;

        }
    }
}

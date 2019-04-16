using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Tempera
{
    public class Paleta
    {
        private int _cantidadMaxima;

        // cambiar array por lista de Temperas (List<Tempera>)

        private List<Tempera> _temperas;

        public List<Tempera> MisTemperas
        {
            get { return this._temperas; }
        }


        private Paleta() : this(5)
        {
        }

        private Paleta(int cantidad)
        {
            this._cantidadMaxima = cantidad;
            this._temperas = new List<Tempera>(cantidad);
            for (int i = 0; i < this._cantidadMaxima; i++)
            {
                this._temperas.Insert(i, null);
            }
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }
        private string Mostrar()
        {
            string retorno = "TEMPERAS MAXIMA:" + this._cantidadMaxima.ToString() + "\n";
            foreach (Tempera tempera in this._temperas)
            {
                if (tempera != null)
                {
                    retorno += Tempera.Mostrar(tempera);
                }
            }
            return retorno;
        }
        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;
            foreach (Tempera item in paleta.MisTemperas)
            {
                if (item == tempera)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int lugar;
            if (paleta != tempera)
            {
                lugar = paleta.ObtenerIndice();
                if (lugar >= 0 && lugar < paleta._cantidadMaxima)
                {
                    paleta._temperas.Insert(lugar, tempera);
                }

            }
            return paleta;
        }
        private int ObtenerIndice()
        {
            int retornar = -1;
            int i = 0;
            if (this._temperas.Count != 0)
            {
                foreach (Tempera item in this.MisTemperas)
                {
                    if (Equals(item, null))
                    {
                        retornar = i;
                        break;
                    }
                    if (i >= this._cantidadMaxima)
                    {
                        break;
                    }
                    i++;
                }
            }
            return retornar;
        }

    }
}

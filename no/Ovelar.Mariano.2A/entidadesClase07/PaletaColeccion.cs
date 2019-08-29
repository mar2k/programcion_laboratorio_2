using System;
using System.Collections.Generic;
using System.Text;

namespace entidadesClase07
{
    public class PaletaColeccion
    {
        private List<Tempera> _colores;
        private int _cantidadMaximaElementos;

        #region COSTRUCTOR

        private PaletaColeccion() : this(5)
        {
        }

        public PaletaColeccion(Int32 x)
        {
            this._colores = new List<Tempera>(x);
            this._cantidadMaximaElementos = x;
        }
        #endregion

        public static implicit operator String(PaletaColeccion p)
        {
            return p.Mostrar();
        }

        private String Mostrar()
        {
            String retorna = "";

            foreach (Tempera color in this._colores)
            {
                if(!Object.Equals(color,null))
                { 
                // retorna += Tempera.Mostrar(color)
                retorna += color + "\n";
                }
            }

            return retorna;
        }

        public static bool operator ==(PaletaColeccion p, Tempera t)
        {
            bool retorna = false;

            foreach (Tempera color in p._colores)
            {
                if (!object.Equals(color, null))
                    if (t == color)
                    {
                        retorna = true;
                        break;
                    }
            }
            return retorna;
        }
        public static bool operator !=(PaletaColeccion p, Tempera t)
        {
            return !(p == t);
        }

        public static PaletaColeccion operator +(PaletaColeccion p, Tempera t)
        {
            int indice;
            if (p == t)
            {
                indice = p.obtenerIndice(t);
                if (indice != -1)
                {
                    p._colores[indice] += t;
                }
                else
                {
                    indice = p.obtenerIndice();
                    if (indice != -1)
                    {
                        p._colores.Add(t);
                    }
                }
            }
            return p;
        }

        /*public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice;
            if (p == t)
            {
                indice = p.obtenerIndice(t);
                if (indice != -1)
                {
                    if (!(p._colores[indice] - t <= 0))
                    {
                        p._colores[indice] -= t;
                    }
                    else
                    {
                        p._colores[indice] = null;
                    }
                }
            }
            return p;
        }*/

        /*public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice;
            Tempera aux1;
            SByte aux2;

            if (p == t)
            {
                indice = p.obtenerIndice(t);
                //aux1=(SByte) p._colores[indice];

                if (indice != -1)
                {
                    if (true)
                    {
                        p._colores[indice] -= t;
                    }
                    else
                    {
                        p._colores[indice] = null;
                    }
                }
            }
            return p;
        }*/

        private int obtenerIndice()
        {
            int retorno = -1;
            int i = 0;

            foreach (Tempera color in this._colores)
            {
                if (object.Equals(color, null))
                {
                    retorno = i;
                    break;
                }

                i++;
            }
            return retorno;
        }

        private int obtenerIndice(Tempera t)
        {
            int retorno = -1;
            int i = 0;

            foreach (Tempera color in this._colores)
            {
                if (t == color)
                {
                    retorno = i;
                    break;
                }

                i++;
            }
            return retorno;
        }


    }
}

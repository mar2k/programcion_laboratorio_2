using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase07
{
    class Tempera
    {
        private SByte _cantidad;
        private ConsoleColor _color;
        private String _marca;

        #region COSTRUCTOR

        public Tempera()
        {
            this._color = ConsoleColor.Blue;
            this._cantidad = 0;
            this._marca = "SIN MARCA";
        }
        public Tempera(ConsoleColor color) : this()
        {
            this._color = color;
        }
        public Tempera(String marca) : this()
        {
            this._marca = marca;
        }
        public Tempera(SByte cantidad) : this()
        {
            this._cantidad = cantidad;
        }
        public Tempera(String marca, ConsoleColor color, SByte cantidad)
        {
            this._marca = marca;
            this._cantidad = cantidad;
            this._color = color;
        }

        #endregion

        #region METODOS

        public static String Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        private String Mostrar()
        {
            String retorna = "";
            retorna += this._cantidad.ToString() + " ";
            retorna += this._color.ToString() + " ";
            retorna += this._cantidad.ToString() + " ";
            return retorna;
        }

        public static bool operator ==(Tempera p, Tempera t)
        {
            bool retorna = false;
            if(p._color == t._color && p._marca == t._marca)
            {
                retorna = true;
            }
            return retorna;
        }

        public static bool operator !=(Tempera p, Tempera t)
        {
            return !(p==t);
        }

        public static Tempera operator +(Tempera p, Tempera t)
        {
            Tempera retorno = new Tempera(p._marca,p._color,p._cantidad);
            if(p==t)
            {
                retorno._cantidad+= t._cantidad;
            }
            return retorno;
        }
        public static Tempera operator +(Tempera p, SByte t)
        {
            if (t>0)
            {
                p._cantidad += t;
            }
            return p;
        }

        #endregion




    }
}

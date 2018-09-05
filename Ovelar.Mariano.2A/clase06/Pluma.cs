using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Pluma
    {
        private String _marca;
        private Int32 _cantidad;
        private Tinta _tinta;

        #region COSTRUCTOR

        public Pluma()
        {
            this._marca = "sin marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(String marca):this()
        {
            this._marca = marca;
        }
        public Pluma(Int32 cantida) : this()
        {
            this._cantidad = cantida;
        }
        public Pluma(Tinta tinta) : this()
        {
            this._tinta = tinta;
        }
        public Pluma(Tinta tinta,Int32 cantidad) : this(cantidad)
        {
            this._tinta = tinta;
        }
        public Pluma(Tinta tinta,String marca ) : this(tinta)
        {
            this._marca = marca;
        }
        public Pluma(Int32 cantidad, String marca) : this(cantidad)
        {
            this._marca = marca;
        }
        public Pluma(Int32 cantidad, String marca,Tinta tinta) : this(tinta,cantidad)
        {
            this._marca = marca;
        }
        #endregion

        #region METODOS

        public static String Mostrar(Pluma p)
        {
            return p.Mostrar();
        }

        private String Mostrar()
        {
            String retorna = "";
            retorna += Tinta.Mostrar(this._tinta) + " ";
            retorna += this._marca + " ";
            retorna += this._cantidad.ToString() + " ";
            return retorna;
        }

        public static bool operator ==(Pluma p,Tinta t)
        {
            bool retorna = false;
            if(p._tinta == t)
            {
                retorna = true;
            }
            return retorna;
        }

        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p==t);
        }

        public static Pluma operator +(Pluma p, Tinta t)
        {
            if(p==t && p._cantidad < 90 && t!=null)
            {
                p._cantidad += 10;
            }
            return p;
        }
        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p == t && p._cantidad > 0 && t != null)
            {
                p._cantidad -= 10;
            }
            return p;
        }

        #endregion
    }
}

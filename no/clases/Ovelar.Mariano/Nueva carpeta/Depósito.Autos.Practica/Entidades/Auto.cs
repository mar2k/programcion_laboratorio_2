using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { this._marca = value; }
        }
        public string Color
        {
            get { return _color; }
            set { this._color = value; }
        }

        public Auto(string color, string marca)
        {
            Color = color;
            Marca = marca;
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                retorno = (((Auto)obj) == this);
            }
            return retorno;
        }

        public override int GetHashCode()
        {
            return 0;
        }


        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if (a.Color == b.Color && a.Marca == b.Marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return "Marca: "+this.Marca+" - Color: "+this.Color+"\n";
        }
    }
}

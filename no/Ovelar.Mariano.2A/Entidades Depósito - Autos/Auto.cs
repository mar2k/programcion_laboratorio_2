using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Depósito___Autos
{
    class Auto
    {
        private string _color;
        private string _marca;

        public string Marca { get { return this._marca;} }

        public string Color { get { return this._color; } }

        public Auto(string color, string marca)
        {
            color = this._color;
            marca = this._marca;
        }

        public override bool Equals(object obj)
        {
            bool retorno = true;

            if(obj is Auto)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return (a._color == b._color && a._marca == b._marca);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "\nCOLOR: " + this.Color + "--";
            retorno += "MARCA: " + this.Marca + "\n";

            return retorno;
        }
    }
}

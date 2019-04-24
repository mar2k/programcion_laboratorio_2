using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelar.Mariano._2A
{
    public abstract class Mascota
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            //set { _nombre = value; }
        }
        private string _raza;

        public string Raza
        {
            get { return _raza; }
            //set { _raza = value; }
        }

        protected virtual string DatosCompletos()
        {
            return this._nombre +" "+ this._raza;
        }

        protected abstract string Ficha();

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }




    }

}

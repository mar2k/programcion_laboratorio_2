using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelar.Mariano._2A
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string retorno = "";
            string aux = ",";
            if (this._esAlfa)
            {
                aux = ",alfa de la manda,";
            }
            retorno = base.DatosCompletos() + aux +"edad "+  this._edad.ToString();
            return retorno;
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro) {
              retorno =  ((Perro)obj == this);
            }
            return retorno;
        }
        public static explicit operator int(Perro p)
        {
            return p._edad;
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retono = false;
            if (p1.Nombre==p2.Nombre&&p1.Raza==p2.Raza&&p1._edad==p2._edad)
            {
                retono = true;
            }
            return retono;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelar.Mariano._2A
{
    public class Gato : Mascota
    {
        public Gato(string nombre,string raza) : base(nombre, raza)
        {

        }
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
            {
                retorno = ((Gato)obj == this);
            }
            return retorno;
        }
        public static bool operator ==(Gato g1,Gato g2)
        {
            bool retono = false;
            if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                retono = true;
            }
            return retono;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1==g2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public class Deportivo : Auto,IAFIP,IARBA
    {
        protected int _caballosFuerza;
        public Deportivo(double precio, string patente,int hp) : base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

        public override string Patente { get { return this._patente;} }

        double IAFIP.calculaImpuesto()
        {
            return this._precio * 0.28;
        }

        double IARBA.calculaImpuesto()
        {
            throw new NotImplementedException();
        }
    }
}

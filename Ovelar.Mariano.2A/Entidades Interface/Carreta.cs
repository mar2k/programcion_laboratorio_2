using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public class Carreta : Veiculo,IARBA
    {
        public Carreta(double precio):base(precio)
        {
        }

        double IARBA.calculaImpuesto()
        {
            return this._precio*0.18;
        }
    }
}

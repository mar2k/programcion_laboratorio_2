using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface
{
    public static class Gestion
    {
       public static double MostrarImpuestoNacional(IAFIP bienP)
        {
            return bienP.calculaImpuesto();
        }

        public static double MostrarImpuestoProvincial(IARBA bienP)
        {
            return bienP.calculaImpuesto();
        }
    }
}

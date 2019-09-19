using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_37_CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

        public float Costo
        {
            get { return this.costo; }
        }

        public Local(string nroOrigen, float duracion , string nroDestino,float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCostos(); }
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        private float CalcularCostos()
        {
            return this.costo * base.Duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine("Costo Llamada: " + this.CostoLlamada.ToString());

            return retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null) && obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}

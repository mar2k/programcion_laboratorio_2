using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_37_CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;

        public float Duracion
        {
            get { return this.duracion; }
        }

        protected string nroDestino;

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        protected string nroOrigen;

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            return "";
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 0;
        }
    }
}

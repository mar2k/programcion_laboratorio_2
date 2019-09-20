using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
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
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Numero origen: " + this.NroOrigen);
            retorno.AppendLine("Numero Destino: " + this.NroDestino);
            retorno.AppendLine("Duracion: " + this.Duracion.ToString());

            return retorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (!(llamada1 is null) && !(llamada2 is null))
            {
                if (llamada1.Duracion < llamada2.Duracion)
                {
                    retorno = 1;
                }
                else if (llamada1.Duracion > llamada2.Duracion)
                {
                    retorno = -1;
                }
            }
            return retorno;
        }
    }
}

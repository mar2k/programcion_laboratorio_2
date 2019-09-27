using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        Franja franjaHoraria;

        public override float CostoLlamada
        {
            get { return this.CalcularCostos(); }
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        private float CalcularCostos()
        {
            float precioPorFranja=0;

            if (this.franjaHoraria==Franja.Franja_1)
            {
                precioPorFranja = (float) 0.99 ;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                precioPorFranja = (float) 1.25;
            }
            else if (this.franjaHoraria == Franja.Franja_3)
            {
                precioPorFranja = (float) 0.66;
            }

            return precioPorFranja * base.Duracion;
        }

        new public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine("Costo Llamada: " + this.CostoLlamada.ToString());
            retorno.AppendLine("Franja Horaria: " + this.franjaHoraria.ToString());

            return retorno.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null) && obj is Provincial)
            {
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

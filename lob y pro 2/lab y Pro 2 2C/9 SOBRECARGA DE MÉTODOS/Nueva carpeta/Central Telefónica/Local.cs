using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_51;
namespace CentralitaHerencia
{
    public class Local<T> : Llamada, IGuardar<T>
    {
        private float costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCostos(); }
        }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            if (!(obj is null) && obj is Local<T>)
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

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }
    }
}

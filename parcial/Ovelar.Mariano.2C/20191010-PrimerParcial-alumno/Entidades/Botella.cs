using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public int CapacidadLitros
        {
            get
            {
                return (this.capacidadML / 1000);
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentajeContenido
        {
            get
            {
                float porcentaje = 0;
                porcentaje = (float) (this.contenidoML / 100.0) * this.capacidadML;
                return porcentaje;
            }
        }

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if (contenidoML > capacidadML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
        }
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Marca: ");
            sb.AppendLine(this.marca);
            sb.Append("Capacidad: ");
            sb.Append(this.CapacidadLitros.ToString());
            sb.AppendLine("L");
            sb.Append("Contenido: ");
            sb.Append(this.contenidoML.ToString());
            sb.AppendLine("ml");

            return sb.ToString();
        }
        public abstract int ServirMedida();
        
        public override string ToString()
        {
            return this.GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }

    }
}

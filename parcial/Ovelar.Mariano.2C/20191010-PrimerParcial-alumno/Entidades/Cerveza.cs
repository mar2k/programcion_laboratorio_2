using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {
        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.GenerarInforme());
            sb.Append("Botella de ");
            sb.AppendLine(this.tipo.ToString());

            return sb.ToString();
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        public override int ServirMedida()
        {
            int retorno = 0;

            retorno = (int)(MEDIDA * 0.8);
            if (base.Contenido - retorno >= 0)
            {
                base.Contenido = base.Contenido - retorno;
            }
            else
            {
                retorno = base.Contenido;
                base.Contenido = 0;
            }

            return retorno;
        }

    }
}

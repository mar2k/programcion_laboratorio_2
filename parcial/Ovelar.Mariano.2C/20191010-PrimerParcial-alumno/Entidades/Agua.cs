using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }

        protected override string GenerarInforme()
        {
            return base.GenerarInforme();
        }

        public override int ServirMedida()
        {
            int retorno = 0;

            retorno = this.ServirMedida(MEDIDA);

            return retorno;
        }
        public int ServirMedida(int medida)
        {
            int retorno = 0;
            if (medida <= base.Contenido)
            {
                base.Contenido = base.Contenido - medida;
                retorno = medida;
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

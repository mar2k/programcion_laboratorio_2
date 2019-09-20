using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        string razonSocial;
        private List<Llamada> listaLlamadas;

        public List<Llamada> Llamadas
        {
            get
            {
                return listaLlamadas;
            }

        }


        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Local);
            }
        }


        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(TipoLlamada.Todas);
            }
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float recaudacion = 0;
            int aux = 0;

            if (tipo == TipoLlamada.Local)
            {
                aux = 1;
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                aux = 2;
            }
            else if (tipo == TipoLlamada.Todas)
            {
                aux = 3;
            }
            foreach (Llamada item in this.listaLlamadas)
            {
                if ((aux == 1 || aux == 3) && item is Local)
                {
                    recaudacion = recaudacion + ((Local)item).CostoLlamada;
                }
                if ((aux == 2 || aux == 3) && item is Provincial)
                {
                    recaudacion = recaudacion + ((Provincial)item).CostoLlamada;
                }
            }
            return recaudacion;
        }

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("razón social: " + this.razonSocial);
            retorno.AppendLine("ganancia total: " + this.GananciasPorTotal.ToString());
            retorno.AppendLine("ganancia por llamados locales: " + this.GananciasPorLocal.ToString());
            retorno.AppendLine("ganancia por llamados provinciales: " + this.GananciasPorProvincial.ToString());

            foreach (Llamada item in this.listaLlamadas)
            {
                if (item is Local)
                {
                    retorno.AppendLine(((Local)item).Mostrar());
                }
                else
                {
                    retorno.AppendLine(((Provincial)item).Mostrar());
                }
            }
            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {

        }
    }
}

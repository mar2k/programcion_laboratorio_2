using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaException_EJ_41;
using EJ_51;

namespace CentralitaHerencia
{
    public class Centralita<T>: IGuardar<T>
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
                return this.CalcularGanancias(Llamada.TipoLlamada.Local);
            }
        }


        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Todas);
            }
        }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private float CalcularGanancias(Llamada.TipoLlamada tipo)
        {
            float recaudacion = 0;
            int aux = 0;

            if (tipo == Llamada.TipoLlamada.Local)
            {
                aux = 1;
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                aux = 2;
            }
            else if (tipo == Llamada.TipoLlamada.Todas)
            {
                aux = 3;
            }
            foreach (Llamada item in this.listaLlamadas)
            {
                if ((aux == 1 || aux == 3) && item is Local<T>)
                {
                    recaudacion = recaudacion + ((Local<T>)item).CostoLlamada;
                }
                if ((aux == 2 || aux == 3) && item is Provincial<T>)
                {
                    recaudacion = recaudacion + ((Provincial<T>)item).CostoLlamada;
                }
            }
            return recaudacion;
        }

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("razón social: " + this.razonSocial);
            retorno.AppendLine("ganancia total: " + this.GananciasPorTotal.ToString());
            retorno.AppendLine("ganancia por llamados locales: " + this.GananciasPorLocal.ToString());
            retorno.AppendLine("ganancia por llamados provinciales: " + this.GananciasPorProvincial.ToString());

            foreach (Llamada item in this.listaLlamadas)
            {
                retorno.AppendLine(item.ToString());
            }
            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada(Llamada NuevaLlamada)
        {
            this.listaLlamadas.Add(NuevaLlamada);
        }
        public static bool operator ==(Centralita<T> c, Llamada llamada)
        {
            bool retorno = false;
            if (!(c is null) && !(llamada is null))
            {
                foreach (Llamada item in c.listaLlamadas)
                {
                    if (item == llamada)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Centralita<T> c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita<T> operator +(Centralita<T> c, Llamada NuevaLlamada)
        {

            if (!(c is null) && !(NuevaLlamada is null))
            {
                if (c != NuevaLlamada)
                {
                    c.AgregarLlamada(NuevaLlamada);
                }
                else
                {
                    throw new CentralitaException("Ya esta la llamada en la cental", "Centralita", "operador +");
                }
            }
            return c;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Guardadr()
        {
            this.ToString();
            return true;
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EJ_47
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo(string nombre)
        {
            
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool yaEstaElQuipo = false;
            if (!(torneo is null) && !(equipo is null))
            {
                foreach (T item in torneo.equipos)
                {
                    if (item.nombre == equipo.nombre)
                    {
                        yaEstaElQuipo = true;
                        break;
                    }
                }
            }
            return yaEstaElQuipo;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T nuevoEquipo)
        {
            if (torneo != nuevoEquipo)
            {
                torneo.equipos.Add(nuevoEquipo);
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Torneo: {0}\n", this.nombre);
            datos.AppendLine("Equipos");

            foreach (T item in this.equipos)
            {
                datos.AppendLine(item.Ficha());
            }
            return datos.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random resultado = new Random();
            StringBuilder resultadoDelPartido = new StringBuilder();
            int e1Puntos = 0;
            int e2Puntos = 0;

            e1Puntos = resultado.Next(0, 20);
            Thread.Sleep(500);//hilos
            e2Puntos = resultado.Next(0, 20);

            resultadoDelPartido.AppendFormat("{0} {1}", e1.nombre, e1Puntos);
            resultadoDelPartido.Append(" - ");
            resultadoDelPartido.AppendFormat("{0} {1}", e2.nombre, e2Puntos);

            return resultadoDelPartido.ToString();
        }
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                int aux1;
                int aux2;
                aux1 = random.Next(0, this.equipos.Count);
                T equipo1 = this.equipos[aux1];
                do
                {
                    aux2 = random.Next(0, this.equipos.Count);
                    Thread.Sleep(250);//hilos
                } while (aux1 == aux2);
                T equipo2 = this.equipos[aux2];

                return this.CalcularPartido(equipo1, equipo2);
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}

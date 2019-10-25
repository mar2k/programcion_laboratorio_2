using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EJ_47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo()
        {
            Random random = new Random();
            Thread.Sleep(250);//hilos
            this.fechaCreacion = new DateTime(random.Next(1950, 2019), random.Next(1, 12), random.Next(1, 28));
        }

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            bool sonIguales = false;
            if (!(equipo1 is null) && !(equipo2 is null))
            {
                if (equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion)
                {
                    sonIguales = true;
                }
            }
            return sonIguales;
        }
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        public string Ficha()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion.ToShortDateString());
            return ficha.ToString();
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

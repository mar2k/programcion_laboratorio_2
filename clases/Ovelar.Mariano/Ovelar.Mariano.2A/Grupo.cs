using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelar.Mariano._2A
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        public static EtipoManada Tipo
        {
            //get { return _tipo; }
            set { Grupo._tipo = value; }
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            //this._nombre = nombre;
            Grupo.Tipo = tipo;
        }
        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }
        private Grupo()
        {
            this._manada = new List<Mascota>();
        }
        static Grupo()
        {
            Grupo.Tipo = EtipoManada.Unica;
        }
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retono = false;
            foreach (Mascota item in g._manada)
            {
                if (item == m)
                {
                    retono = true;
                    break;
                }
            }

            return retono;
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("ya esta el {0} en el grupo", m);
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("no esta el {0} en el grupo", m);
            }
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            string retorno = "Grupo: "+g._nombre+" - Tipo: "+Grupo._tipo.ToString()+"\nIntegrantes <"+g._manada.LongCount()+">:\n";
            foreach (Mascota item in g._manada)
            {
                retorno += item.ToString()+"\n";
            }
            return retorno;
        }
    }
}

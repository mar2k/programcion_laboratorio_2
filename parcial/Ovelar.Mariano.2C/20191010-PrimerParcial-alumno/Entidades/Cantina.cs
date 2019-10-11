using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        public List<Botella> Botellas
        { get; }
        private Cantina(int espacio)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacio;
        }
        public static Cantina GetCantina(int espacio)
        {
            if (Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacio);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacio;
            }
            return Cantina.singleton;
        }
        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;

            if (!(c is null) && !(b is null))
            {
                if (c.espaciosTotales-c.botellas.Count>=0)
                {
                    c.botellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}

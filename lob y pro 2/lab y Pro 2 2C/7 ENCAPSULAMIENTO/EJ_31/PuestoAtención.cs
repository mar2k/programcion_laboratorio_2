using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EJ_31
{
    public class PuestoAtención
    {

        public enum Puesto
        {
            Caja1,
            Caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return PuestoAtención.numeroActual;
            }
        }
        static PuestoAtención()
        {
            PuestoAtención.numeroActual = 0;
        }
        public PuestoAtención(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (!(cli is null))
            {
                Console.WriteLine("atendiendo a " + cli.Nombre);
                Thread.Sleep(10000);
                retorno = true;
            }
            
            return retorno;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EJ_67
{
    public sealed class Temporizador
    {
        public delegate void EncargadoTiempo();
        private Thread hilo;
        private int intervalo;
        public EncargadoTiempo EventoTiempo;

        public bool Activo
        {
            get { return true; }
            set {
                //if (value == true && this.hilo.)
                //{

                //}
                bool a = value; }
        }
        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }
        private void Corriendo()
        {

        }
    }


}

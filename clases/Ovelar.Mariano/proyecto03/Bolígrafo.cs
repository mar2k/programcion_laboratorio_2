using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto03
{
    class Bolígrafo
    {
        public static short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;

        public Bolígrafo(short tinta,ConsoleColor color)
        {
            SetTinta(tinta);
            this.color = color;
        }
        static Bolígrafo()
        {
            Bolígrafo.cantidadTintaMaxima = 100;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gastar , out string dibujo)
        {
            dibujo = "";
            return true;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            if(tinta<0)
            {
                if(this.tinta+tinta>=0)
                {
                    this.tinta += tinta;
                }
                else
                {
                    Console.WriteLine("ERROR:FALTA TINTA!!!!");
                }
            }
            else
            {
                if (Bolígrafo.cantidadTintaMaxima >= tinta+this.tinta)
                {
                    this.tinta += tinta;
                }
                else
                {
                    Console.WriteLine("YA TIENE TINTA / LA CANTIDAD DE TINTA QUE QUIERE INGRESAR NO ENTRA EN EL CARTUCHO");
                }
            }
        }

    }
}

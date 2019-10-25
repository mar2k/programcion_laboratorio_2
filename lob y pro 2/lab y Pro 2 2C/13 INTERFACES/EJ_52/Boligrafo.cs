using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float UnidadesDeEscriptura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper("", this.Color); ;

            if (this.tinta - (texto.Length / 100.0f) * 3 >= 0)
            {
                this.tinta = this.tinta - (texto.Length / 100.0f);
                escrituraWrapper = new EscrituraWrapper(texto, this.Color);
            }
            else
            {
                string aux = "";

                if (this.tinta > 0)
                {
                    foreach (char item in texto.ToList())
                    {
                        if (this.tinta - 03f >= 0)
                        {
                            aux = aux + item;
                            this.tinta = this.tinta - 0.3f;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                escrituraWrapper = new EscrituraWrapper(aux, this.Color);


            }

            return escrituraWrapper;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}

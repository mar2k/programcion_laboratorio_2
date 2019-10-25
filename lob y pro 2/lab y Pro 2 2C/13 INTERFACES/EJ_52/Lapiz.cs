using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        public override string ToString()
        {
            return "Tamaño De La Mina:" + this.tamanioMina.ToString();
        }


         ConsoleColor IAcciones.Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
         float IAcciones.UnidadesDeEscriptura { get => this.tamanioMina ; set => throw new NotImplementedException(); }

         EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper("", ConsoleColor.Gray); ;

            if (this.tamanioMina - (texto.Length/100.0f) >= 0)
            {
                this.tamanioMina = this.tamanioMina - (texto.Length / 100.0f);
                escrituraWrapper = new EscrituraWrapper(texto, ConsoleColor.Gray);
            }
            else
            {
                string aux = "";

                if (this.tamanioMina>0)
                {
                    foreach (char item in texto.ToList())
                    {
                        aux = aux + item;
                        this.tamanioMina= this.tamanioMina-0.1f;
                        if (this.tamanioMina==0)
                        {
                            break;
                        }
                    }
                }
                
                escrituraWrapper = new EscrituraWrapper(aux, ConsoleColor.Gray);


            }

            return escrituraWrapper;
        }

         bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}

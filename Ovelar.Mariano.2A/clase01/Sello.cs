using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase01
{
    class Sello
    {
        #region ATRIBUTOS


        static public String mensaje = "HOLA MUNDO";


        #endregion


        #region METODOS


        static public String imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        static public void imprimirEnColor()
         {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Red;
        }

        static public void borrar()
        {
            Sello.mensaje = "";
        }

        static private String ArmarFormatoMensaje()
        {
            string ateriscos = "";
            int i;
            int tam = 0;
            string retorno = "";
            string cadena = "";

            if (Sello.TryParse(Sello.mensaje, out cadena))
            {
                tam = Sello.mensaje.Length;

                for (i = 0; i < tam + 2; i++)
                {
                    ateriscos += "*";
                }
                ateriscos += "\n";

                retorno = ateriscos.ToString() + "*" + Sello.mensaje + "*\n" + ateriscos.ToString();
            }
            else
            {
                retorno = cadena;
            }

            return retorno;
        }

        private static bool TryParse(string mensaje, out string cadena)
        {
            bool retorno = true;
            if (mensaje.Length < 1)
            {
                retorno = false;
            }

            cadena = "ERROR!!!!";

            return retorno;
        }
        

        #endregion

    }
}

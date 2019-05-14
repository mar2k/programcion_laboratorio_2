using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.clase._14
{
    public static class ParseadoraDeEnteros
    {
        public static bool TryParse(string x, out int y)
        {
            bool retorno = true;
            y = 0;


            try
            {
                y = int.Parse(x);
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;

        }
        public static int Parse(string x)
        {
            int a = 0;
            try
            {
                a = int.Parse(x);
            }
            catch (FormatException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido  por error de formato", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido por tamaño del dato", e);
            }
            return a;
        }

    }
}

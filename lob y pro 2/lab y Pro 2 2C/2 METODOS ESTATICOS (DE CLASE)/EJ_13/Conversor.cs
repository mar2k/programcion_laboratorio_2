using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_13
{
    public static class Conversor
    {
        public static string DecimalBinario(double dato)
        {
            string retorno = "";
            if (dato > 0)
            {
                while (dato > 0)
                {
                    if (dato % 2 == 0)
                    {
                        retorno = "0" + retorno;
                    }
                    else
                    {
                        retorno = "1" + retorno;
                    }
                    dato = (int)(dato / 2);
                }
            }
            else
            {
                retorno = "0";
            }

            return retorno;
        }
        public static double BinarioDecimal(string dato)
        {
            char[] array = dato.ToCharArray();
            
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }
}

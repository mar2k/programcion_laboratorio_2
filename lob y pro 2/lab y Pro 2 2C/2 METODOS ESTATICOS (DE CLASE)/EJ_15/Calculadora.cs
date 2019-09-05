using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_15
{
    public static class Calculadora
    {
        public static float Calcular (float num1, float num2,string operador)
        {
            float resultado = 0;
            if (operador =="+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "*")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                if(Calculadora.Validar(num2))
                {
                    resultado = num1 / num2;
                }
            }
            
            return resultado;
        }

        private static bool Validar(float num)
        {
            return (num!=0);
        }
    }
}

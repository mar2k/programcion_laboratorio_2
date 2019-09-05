using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_11
{
    public static class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            return (min <= valor && valor <= max);
        }
    }
}

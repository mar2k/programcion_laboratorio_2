using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_58
{
    class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje)
        {

        }
        public ArchivoIncorrectoException(string mensaje,Exception innerException)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_42
{
    public class NuevaException : Exception
    {
        public NuevaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        { }
        public NuevaException(string mensaje) : base(mensaje)
        { }
    }
}

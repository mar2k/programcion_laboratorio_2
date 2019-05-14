using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.clase._14
{
    public class ErrorParserException:Exception
    {
        public ErrorParserException(string mensaje):base(mensaje)
        { }
        public ErrorParserException(String message, Exception inner) : base(message, inner)
        { }
    }
}

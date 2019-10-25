using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_51
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo { get; set; }

        bool Guardadr();
        T Leer();
    }
}

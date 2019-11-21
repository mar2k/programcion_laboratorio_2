using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivos<T>
    {
        void Guardar(string archivo, T datos);
        void leer(string archivo, out T datos);
    }
}

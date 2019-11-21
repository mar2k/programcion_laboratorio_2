using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql<T>:IArchivos<T>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public void Guardar(string archivo, T datos)
        {
            throw new NotImplementedException();
        }

        public void leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }
    }
}

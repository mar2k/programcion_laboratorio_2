using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EJ_54
{
    public static class ArchivoTexto
    {
        public static void Guardar(string path,string datos)
        {
            using (StreamWriter escritura = new StreamWriter(@path))
            {
                escritura.Write(datos);
            }
        }
        public static string Leer(string path)
        {
            string datos="";
            if (File.Exists(path))
            {
                using (StringReader lectura = new StringReader(@path))
                {
                    datos += lectura.ReadToEnd();
                }
               
            }
            else
            {
                throw new FileNotFoundException();
            }

            return datos;
        }

    }
}

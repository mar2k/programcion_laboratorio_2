using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EJ_54;

namespace EJ_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase miClase=new MiClase();
            string aux = "";
            DateTime fecha = DateTime.Now;
            string nombreArchivo = "";
            

            try
            {
                miClase.Metodo();
            }
            catch (Exception e)
            {
                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e;
                    do
                    {
                        aux=aux+ex.Message+" ";
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                    nombreArchivo += fecha.Year.ToString() + fecha.Month.ToString() + fecha.Day.ToString() + "-" + fecha.Hour.ToString() + fecha.Minute.ToString() + ".txt";
                    ArchivoTexto.Guardar(nombreArchivo, aux);
                }
            }
            Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
    public class Texto<T>
    {
        public void Guardar(string archivo, T datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @archivo, false))
                {
                    sw.WriteLine(datos.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        public void leer(string archivo, out Queue<Patente> datos)
        {
            try
            {
                datos = new Queue<Patente>();
                using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @archivo, true))
                {
                    while (sr.EndOfStream == false)
                    {
                        
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}

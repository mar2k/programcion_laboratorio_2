using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T> where T : new()
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer;
            XmlSerializer ser;
            writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
            try
            {
                ser = new XmlSerializer(typeof(T));

                ser.Serialize(writer, objeto);
    
            }
            catch (Exception)
            {
                return false;

           
            }
            finally
            {
                writer.Close();
            }

            return true;
        }

        public T Leer(string rutaArchivo)
        {
            /*T p = new T();
            try
            {


                using (TextReader tr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @rutaArchivo, true))
                {
                    XmlSerializer xmlS = new XmlSerializer(typeof(T));
                    p = (T)xmlS.Deserialize(tr);
                    Console.WriteLine(p.ToString());
                }

                return p;
            }
            catch (Exception)
            {
                return p;
                //throw new ArchivosException("No se pudo leer el archivo XML");
            }*/
            return new T();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivos<T> where T : new()
    {
        public void Guardar(string archivo, T datos)
        {
            try
            {
                XmlTextWriter writer;
                XmlSerializer ser;

                using (writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, datos);
                }
            }
            catch (Exception)
            {

            }
        }

        public void leer(string archivo, out T datos)
        {
            datos = new T();
            try
            {
                XmlTextReader reader;
                XmlSerializer ser;

                using (reader = new XmlTextReader(archivo))
                {
                    ser = new XmlSerializer(typeof(T));

                    datos = (T)ser.Deserialize(reader);
                }

            }
            catch (Exception)
            {

            }
        }
    }
}

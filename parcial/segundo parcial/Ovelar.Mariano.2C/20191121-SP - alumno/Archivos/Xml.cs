using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
namespace Archivos
{
    public class Xml<T> : IFiles<T> where T : new()
    {

        public string GetDirectoryPath
        {
            get
            {
                return Environment.SpecialFolder.DesktopDirectory.ToString();
            }
        }
        public void Guardar(string nombreArchivo, T objeto)
        {
            try
            {
                this.Guardar(nombreArchivo, objeto, Encoding.UTF8);
            }
            catch (ErrorArchivosException e)
            {
                throw e;
            }

        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            try
            {
                XmlTextWriter writer;
                XmlSerializer ser;

                using (writer = new XmlTextWriter(this.GetDirectoryPath + nombreArchivo, encoding))
                {
                    ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, objeto);
                }
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("", e);
            }
        }

        public bool FileExists(string archivoPlanetas)
        {
            return Directory.Exists(archivoPlanetas);
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            objeto = new T();
            try
            {
                this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
                return true;
            }
            catch (ErrorArchivosException e)
            {
                // return false;
                throw e;
            }
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            objeto = new T();
            try
            {
                XmlTextReader reader;
                XmlSerializer ser;

                using (reader = new XmlTextReader(this.GetDirectoryPath + nombreArchivo))
                {
                    ser = new XmlSerializer(typeof(T));

                    objeto = (T)ser.Deserialize(reader);
                }
                return true;
            }
            catch (Exception e)
            {
                //return false;
                throw new ErrorArchivosException("", e);
            }

        }
    }
}

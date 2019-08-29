using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Persona :Humano,Interface1
    {
        public string apellido;
        public string nombre;

        public Persona():this("A","X")
        {
        }

        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public bool IDeserializar()
        {
            throw new NotImplementedException();
        }

        public bool ISerializarXML(object obj)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(object));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\Lista.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, obj);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

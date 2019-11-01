using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace EJ_57
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static void Guardar(string path, Persona persona)
        {
            try
            {
                using (FileStream fs = new FileStream(@path, FileMode.Create))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, persona);
                }
            }
            catch (Exception e)
            {
                Persona.LansamientoDeError(e, "Metodo Guardar");
            }

        }

        public static void Leer(string path, out Persona persona)
        {
            persona = null;
            try
            {
                using (FileStream fs = new FileStream(@path, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    persona = (Persona)ser.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                Persona.LansamientoDeError(e, "Metodo Leer");
            }
        }

        private static void LansamientoDeError(Exception e, string metodoDelException)
        {
            try
            {
                throw e;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(metodoDelException + ":\nLa ruta de acceso no existe.");
            }
            catch (NotSupportedException)
            {
                throw new NotSupportedException(metodoDelException + ":\nUn nombre de archivo o de directorio de la ruta de acceso contiene un signo \nde dos puntos (:) o tiene un formato no válido.");
            }
            catch (PathTooLongException)
            {
                throw new PathTooLongException(metodoDelException + ":\nLa ruta supera la longitud máxima definida por el sistema.");
            }

            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(metodoDelException + ":\nLa ruta de acceso no es válida porque es una cadena de longitud cero, contiene sólo espacios en blanco, o contiene caracteres no válidos.");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException(metodoDelException + ":\nLa ruta de acceso no es válida porque la ruta de acceso es Null");
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException(metodoDelException + ":\nLa ruta de acceso no existe.");
            }
            catch (IOException)
            {
                throw new IOException(metodoDelException + ":\nEl archivo está en uso por otro proceso o hay un error de E/S.");
            }
            catch (Exception)
            {
                throw new Exception(metodoDelException + ":\nOtro Error!!!.");
            }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre:{0} Apellido:{1}", this.nombre, this.apellido);

            return datos.ToString();
        }
    }
}

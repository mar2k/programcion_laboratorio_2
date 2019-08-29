using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml.Serialization;
using System.IO;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Persona persona = new Persona("ovelar", "mariano");
            Alumno alumno = new Alumno();
            Profesor profesor = new Profesor();
            
            

            List<Humano> lista = new List<Humano>();

            humano.Dni = 111;
            persona.Dni = 222;
            alumno.Dni = 333;
            alumno.Legajo = 1000;
            alumno.apellido = "perez";
            alumno.nombre = "juan";
            profesor.Dni = 444;
            profesor.Titulo = "SSSSS";

            lista.Add(alumno);
            lista.Add(profesor);
            lista.Add(persona);
            lista.Add(humano);

            if (Program.SerializarAlumno(alumno))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Alumno a = Program.DeserializarAlumno();
            if (a != null)
            {
                string s = a.apellido + " " + a.nombre + " " + a.Legajo;
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Error");
            }



            if (Program.SerializarHumano(humano))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Humano h = Program.DeserializarHumano();
            if (a != null)
            {
                string s = h.Dni.ToString();
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Error");
            }


            if (Program.SerializarHumano(profesor))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Humano h2 = Program.DeserializarHumano();
            if (a != null)
            {
                string s = h2.Dni.ToString();
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Error");
            }




            if (Program.SerializarLista(lista))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Error");
            }
            List<Humano> l = Program.DeserializarLista();
            if (a != null)
            {
                foreach (Humano item in l)
                {
                    Console.WriteLine(item.Dni.ToString());
                }


            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }

        public static bool SerializarAlumno(Alumno alumno)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\nombre.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, alumno);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static Alumno DeserializarAlumno()
        {
            Alumno alumno;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Alumno));
                using (StreamReader streamReader = new StreamReader(@"D:\nombre.XML"))
                {
                    alumno = (Alumno)xmlSerializer.Deserialize(streamReader);

                }
            }
            catch (Exception)
            {
                return null;
            }
            return alumno;
        }
        public static bool SerializarHumano(Humano humano)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\Humano.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, humano);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static Humano DeserializarHumano()
        {
            Humano humano;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Humano));
                using (StreamReader streamReader = new StreamReader(@"D:\Humano.XML"))
                {
                    humano = (Humano)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return humano;
        }

        public static bool SerializarLista(List<Humano> lista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Humano>));
                using (StreamWriter streamWriter = new StreamWriter(@"D:\Lista.XML"))
                {
                    xmlSerializer.Serialize(streamWriter, lista);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static List<Humano> DeserializarLista()
        {
            List<Humano> lista;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Humano>));
                using (StreamReader streamReader = new StreamReader(@"D:\Lista.XML"))
                {
                    lista = (List<Humano>)xmlSerializer.Deserialize(streamReader);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return lista;
        }


        /*public static bool SerializarXML( o)
        {
            return o.;
        }
        public static DeserializarXML()
        {

        }*/


    }
}
/*
 * XML-->atributo--->publico
 *    |          |--->propiedades L/E
 *    |          |--->propiedades S/L --->solo colecciones
 *    |
 *    |--->costructor X defolt
 *    |--->clase publica
 *    
 *    interfaces:
 *    contine metodos y/o propiedad sin modificador de visivilidad , sin implementacion ,estan las clase obligadas
 *    a implementar cada metodo y/o propiedad publicos y de instacia 
 *    
 *    
 */

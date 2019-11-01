using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace EJ_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Mariano", "Ovelar");
            Persona aux= new Persona("ERROR", "ERROR"); ;

            try
            {
                Persona.Guardar("Persona.txt", persona1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);               
            }

            try
            {
                Persona.Leer("Persona.txt:", out aux);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(aux);

            Console.ReadKey();
        }
    }
}

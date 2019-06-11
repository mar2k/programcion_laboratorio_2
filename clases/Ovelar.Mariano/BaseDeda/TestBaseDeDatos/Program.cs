using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;

namespace TestBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos a = new AccesoDatos();

            List<Persona> lp = new List<Persona>();

            lp=a.TraerTodos();

            foreach (Persona item in lp)
            {
                Console.WriteLine(item.ToString());
            }
            Persona p1 = new Persona(15, "mariano", "ovelar", 20);




            Console.ReadKey();

        }
    }
}

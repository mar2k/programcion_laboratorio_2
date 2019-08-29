using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.WriteLine("HOLA MUNDO!!!!");
            Console.Write("\nINGRESE SU NOMBRE: ");
            nombre = Console.ReadLine();
            Console.Write("INGRESE SU EDAD: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\nSU NOMBRE ES {0} Y SU EDAD ES {1}", nombre, edad);
            Console.ReadKey();
        }
    }
}

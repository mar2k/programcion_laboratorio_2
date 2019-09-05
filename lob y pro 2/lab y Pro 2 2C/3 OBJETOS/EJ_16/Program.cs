using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.legajo = 1;
            alumno1.nombre = "Mariano";
            alumno1.apellido = "Ovelar";
            alumno1.Estudiar(10, 8);
            alumno1.CalcularFinal();

            alumno2.legajo = 2;
            alumno2.nombre = "Juan";
            alumno2.apellido = "Chavez";
            alumno2.Estudiar(4, 2);
            alumno2.CalcularFinal();
            

            alumno3.legajo = 3;
            alumno3.nombre = "Lucia";
            alumno3.apellido = "Lopez";
            alumno3.Estudiar(4, 6);
            alumno3.CalcularFinal();
            
            Console.WriteLine("{0}\n--------------\n{1}\n--------------\n{2}", alumno1.Mostrar(), alumno2.Mostrar(), alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}

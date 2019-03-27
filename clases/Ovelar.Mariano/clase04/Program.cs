using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase04.Entidades;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa laCosa = new Cosa(666666, DateTime.Now,"BBBBBBBBB");

            Console.WriteLine(Cosa.Mostrar(laCosa));

            laCosa.Establecervalor(44444);
            laCosa.Establecervalor("AAAAAAAAAAAAAA");
            laCosa.Establecervalor(DateTime.Now);

            Console.WriteLine(Cosa.Mostrar(laCosa));

            Console.ReadKey();

        }
    }
}
